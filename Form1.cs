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


namespace instagov_prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //"66677dddbac414c38f9faef8",
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string text = System.IO.File.ReadAllText(@"records.JSON");
                string text = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    legal_action = this.comboBox1.SelectedItem,
                    legal_object = this.comboBox2.SelectedItem,
                    legal_type = this.comboBox3.SelectedItem,
                    originator_id = this.textBox2.Text,
                    target_id = "0000000000000000000",
                    db_id = "needs to be same as object id and generated dynamically",
                    output_id = "needs to be same format but unique, mostly for new wallet outputs",
                    amount = this.numericUpDown1.Value,
                    title = this.textBox1.Text,
                    desc = this.richTextBox1.Text,
                    bonus_vars = "???????",
                    deadline = 1761644493000
                });
                var document = BsonSerializer.Deserialize<BsonDocument>(text);
                TxCollectionSingleton.collectioninstance.InsertOne(document);
                this.label9.Text = "Sucessful transaction!";
            }
            catch
            {
                this.label9.Text = "Transaction failed";
            }
        }
    }
}
