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


namespace instagov_prototype
{
    
    public partial class Form1 : Form
    {
        private Form2 availableBills = new Form2();
        private Form3 passedBills = new Form3();
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        //"66677dddbac414c38f9faef8",
        private void button1_Click(object sender, EventArgs e)
        {
            var validObjId_orig = this.textBox2.Text;
            var validObjId_targ = this.textBox3.Text;

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
                    //string text = System.IO.File.ReadAllText(@"records.JSON");
                    string text = Newtonsoft.Json.JsonConvert.SerializeObject(new
                    {
                        legal_action = this.comboBox1.SelectedItem,
                        legal_object = this.comboBox2.SelectedItem,
                        legal_type = this.subtypeMetaSelector.Text,
                        originator_id = this.textBox2.Text,
                        target_id = validObjId_targ,
                        db_id = SequentialGuidGenerator.Instance.NewGuid(),
                        output_id = "needs to be same format but unique, mostly for new wallet outputs",
                        amount = this.numericUpDown1.Value,
                        title = this.textBox1.Text,
                        desc = this.richTextBox1.Text,
                        deadline = (int)DateTime.UtcNow.Subtract(this.dateTimePicker1.Value.ToUniversalTime()).TotalSeconds
                    });
                    var document = BsonSerializer.Deserialize<BsonDocument>(text);
                    TxCollectionSingleton.collectioninstance.InsertOne(document);
                    this.status.Text = "Sucessful transaction!";
                }
                catch
                {
                    this.status.Text = "Transaction failed";
                }
            }
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
