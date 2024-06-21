using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using SequentialGuid;
using System.Diagnostics;
using System.IO;
using MongoDB.Bson.Serialization.IdGenerators;
using NBitcoin;
using System.Security.Cryptography;

namespace instagov_prototype
{
    
    public partial class Form1 : Form
    {

        public uint currentBlockNumber = 0;
        public string prevBlockHash = "34242342342342";
        private Form2 availableBills = new Form2();
        private Form3 passedBills = new Form3();
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("seed.json"))
            {
                Debug.WriteLine("Seed file exists.");
            }
            else
            {
                Debug.WriteLine("NO SEED FILE");
            }
            voteby.Value = DateTime.Today;
            Debug.WriteLine(this.voteby.Value.ToUniversalTime());
        }
        //"66677dddbac414c38f9faef8",
        private void button1_Click(object sender, EventArgs e)
        {

            var validObjId_orig = this.origId.Text;
            var validObjId_targ = this.targId.Text;

            Debug.WriteLine(validObjId_targ);
            makeTransaction((string)this.comboBox1.SelectedItem, (string)this.comboBox2.SelectedItem, this.subtypeMetaSelector.Text, this.origId.Text, this.targId.Text, (double)this.numericUpDown1.Value, this.titleinput.Text, this.descinput.Text, (uint)this.voteby.Value.ToUniversalTime().Ticks, this.currentBlockNumber);

            //if targetID is not used
            //if (validObjId_targ == "")
            //{
            //    if (ObjectId.TryParse(validObjId_orig, out _) && ObjectId.TryParse(validObjId_targ, out _))
            //    {

            //        this.status.Text = "Valid IDs";
            //    }
            //    else
            //    {
            //        this.status.Text = "Invalid IDs";
            //    }
                
            //    try
            //    {
            //        string text = Newtonsoft.Json.JsonConvert.SerializeObject(new
            //        {
            //            legal_action = this.comboBox1.SelectedItem, 
            //            legal_object = this.comboBox2.SelectedItem,
            //            legal_type = this.subtypeMetaSelector.Text,
            //            originator_id = this.origId.Text,
            //            target_id = validObjId_targ,
            //            db_id = SequentialGuidGenerator.Instance.NewGuid(),
            //            output_id = "needs to be same format but unique, mostly for new wallet outputs",
            //            amount = this.numericUpDown1.Value,
            //            title = this.titleinput.Text,
            //            desc = this.descinput.Text,
            //            deadline = this.voteby.Value.ToUniversalTime(),
            //            currentblocknumber = this.currentBlockNumber
            //        });
            //        var document = BsonSerializer.Deserialize<BsonDocument>(text);
            //        TxCollectionSingleton.collectioninstance.InsertOne(document);
            //        this.status.Text = "Sucessful transaction!";
            //    }
            //    catch
            //    {
            //        this.status.Text = "Transaction failed";
            //    }
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.citizenComboBox.Visible = false;
            this.definitionComboBox.Visible = false;
            this.billComboBox.Visible = false;
            this.assetComboBox.Visible = false;
            this.disputeComboBox.Visible = false;
            this.organizationComboBox.Visible = false;
            this.contractComboBox.Visible = false;
            this.status.Text = this.comboBox2.SelectedItem.ToString();
            switch (this.comboBox2.SelectedItem)
            {
                case "CITIZEN":
                    this.citizenComboBox.Visible = true;
                    break;
                case "BILL":
                    this.billComboBox.Visible = true;
                    break;
                case "ASSET":
                    this.assetComboBox.Visible = true;
                    break;
                case "DISPUTE":
                    this.disputeComboBox.Visible = true;
                    break;
                case "ORGANIZATION":
                    this.organizationComboBox.Visible = true;
                    break;
                case "CONTRACT":
                    this.contractComboBox.Visible = true;
                    break;
            }
        }

        private void disputeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.disputeComboBox.SelectedItem.ToString();
        }

        private void billComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.billComboBox.SelectedItem.ToString();
        }

        private void citizenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.citizenComboBox.SelectedItem.ToString();
        }

        private void definitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.definitionComboBox.SelectedItem.ToString();
        }

        private void organizationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.organizationComboBox.SelectedItem.ToString();
        }

        private void contractComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subtypeMetaSelector.Text = this.contractComboBox.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            availableBills.ShowDialog(); // Shows Form2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passedBills.ShowDialog();
        }

        private void genesisBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genesisBox.Checked)
            {
                genesisChainName.Visible = true;
                genesisInputLabel.Visible = true;
                genesisThresholdLabel.Visible = true;
                genesisThresholdValue.Visible = true;
                createGenesisChain.Visible = true;
            }
        }

        private void createNewBlock_Click(object sender, EventArgs e)
        {

        }


        //private void createGenesisChain(object sender, EventArgs e)
        //{
        //GenesisKernel kernel = new GenesisKernel();
        //kernel.hardware_id = "444";
        //kernel.blockchain_name = this.genesisChainName.Text;
        //kernel.chain_genesis_timestamp = (int)this.dateTimePicker1.Value.ToUniversalTime().Ticks;
        //kernel.this_block_difficulty = 3;
        //kernel.voter_threshold = (float)this.genesisThresholdValue.Value;

        //}



        public void makeTransaction(string l_action, string l_object, string l_type, string orig_id, string targ_id, double amt, string titl, string descrip, uint voteby, uint blocknum)
        {
            var validObjId_orig = orig_id;
            var validObjId_targ = targ_id; // this.textBox3.Text

            Debug.WriteLine(validObjId_targ);
            //if targetID is not used
            if (validObjId_targ == "")
            {
                if (ObjectId.TryParse(validObjId_orig, out _) && ObjectId.TryParse(validObjId_targ, out _))
                {
                    this.status.Text = "Valid IDs";
                }
                else
                {
                    this.status.Text = "Invalid IDs";
                }
                try
                {
                    string text = Newtonsoft.Json.JsonConvert.SerializeObject(new
                    {
                        legal_action = l_action,
                        legal_object = l_object,
                        legal_type = l_type,
                        originator_id = validObjId_orig,
                        target_id = validObjId_targ,
                        db_id = SequentialGuidGenerator.Instance.NewGuid(),
                        output_id = "needs to be same format but unique, mostly for new wallet outputs",
                        amount = amt,
                        title = titl,
                        desc = descrip,
                        deadline = voteby,
                        currentblocknumber = blocknum
                    });
                    var document = BsonSerializer.Deserialize<BsonDocument>(text);
                    TxCollectionSingleton.collectioninstance.InsertOne(document);
                    this.status.Text = "Sucessful transaction!";
                }
                catch
                {
                    this.status.Text = "ERROR";
                }
            }
        }

        private void createGenesisChain_Click(object sender, EventArgs e)
        {
            if (File.Exists("seed.json"))
            {
                Debug.WriteLine("Seed file exists. Delete seed file and existing blocks to genesisize new chain.");
            }
            else
            {
                if (this.genesisChainName.Text != "" && this.titleinput.Text != "")
                {
                    GenesisKernel kernel = new GenesisKernel();
                    kernel.hardware_id = "444";
                    kernel.blockchain_name = this.genesisChainName.Text;
                    kernel.chain_genesis_timestamp = (uint)DateTime.Now.ToUniversalTime().Ticks;
                    kernel.this_block_difficulty = 3;
                    kernel.voter_threshold = (double)this.genesisThresholdValue.Value;
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(kernel);
                    File.WriteAllText("seed.json", json.ToString());
                    makeTransaction("MAKE", "CITIZEN", "CITIZEN", ObjectId.GenerateNewId(DateTime.Now.ToUniversalTime()).ToString(), "", 1.0, this.titleinput.Text, "autocreated administrator", (uint)this.voteby.Value.ToUniversalTime().Ticks, 0);
                    //ADD OTHER DEFAULT LAWS ETC
                    Block block = new Block();
                    block.number_of_tx_in_block = 0;
                    byte[] bytes = Encoding.UTF8.GetBytes(kernel.blockchain_name);
                    byte[] hash = SHA256.Create().ComputeHash(bytes);
                    string hash2 = HexadecimalEncoding.ByteArrayToString(hash);
                    block.prev_block_hash = hash;
                    block.nonce = 0;
                    block.this_block_hash = hash; ///need to hash actual block
                    block.number_of_tx_in_block = 1;
                    block.this_block_timestamp = kernel.chain_genesis_timestamp;
                    block.this_block_height = this.currentBlockNumber;
                    string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(block);
                    File.WriteAllText("block0.json", json2.ToString());
                    this.currentBlockNumber += 1;
                    this.prevBlockHash = hash2;
                }
                else
                {
                    this.status.Text = "FILL OUT YOUR NAME IN TITLE AND CHAIN NAME IN CHANGE NAME";
                }
            }
        }
    }

    public interface IIdGenerator
    {
        Guid NewId();
    }
    public class SequentialIdGenerator : IIdGenerator
    {
        public Guid NewId() => SequentialGuidGenerator.Instance.NewGuid();
    }
}
