using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MongoDB.Bson.Serialization;
using static System.Net.Mime.MediaTypeNames;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using ThirdParty.Json.LitJson;
using System.IO;
using Newtonsoft.Json.Linq;
using SequentialGuid;




namespace instagov_prototype


{
    public partial class Form2 : Form

    {
        public double votethreshold = 0.4;
        public Int32 totalCitizens = 11;
        public Form2()
        {
            InitializeComponent();
        
           
        }

        private void refreshPage_Click(object sender, EventArgs e)
        {
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            Debug.WriteLine(unixTimestamp.ToString());
            var findOptions = new FindOptions { BatchSize = 3 };

            BsonDocument filter = new BsonDocument("$and", new BsonArray
            {
                new BsonDocument("$and", new BsonArray
                {
                    new BsonDocument("legal_action", "MAKE"),
                    new BsonDocument("legal_object", "BILL")

                }),
                new BsonDocument("deadline", new BsonDocument("$lt", unixTimestamp))

            });
            using (var cursor = TxCollectionSingleton.collectioninstance.Find(filter).ToCursor())
            {
                listView1.View = View.Details;
                foreach (var elem in cursor.ToEnumerable())
                {
                    Debug.WriteLine(elem);
                    var settings = new JsonWriterSettings { Indent = true };
                    var jsonOutput = elem.ToJson(settings);
                    Console.WriteLine(jsonOutput);
                    Bill p = new Bill();
                    Debug.WriteLine(elem["title"].AsString);
                    var listViewItem = new ListViewItem(new string[] { elem["db_id"].AsString, elem["title"].AsString, elem["legal_type"].AsString, elem["desc"].AsString, Convert.ToString(elem["deadline"].AsInt32) });
                    listView1.Items.Add(listViewItem);
                }
            }
            using (var cursor = TxCollectionSingleton.collectioninstance.Find(new BsonDocument("deadline", new BsonDocument("$gt", unixTimestamp))).ToCursor())
            {
                //add any bills that have reached deadline and passed the voter threshold to the database as laws

                foreach (var elem in cursor.ToEnumerable())
                {     
                    Debug.WriteLine(elem);
                    var settings = new JsonWriterSettings { Indent = true };
                    var jsonOutput = elem.ToJson(settings);
                    Console.WriteLine(jsonOutput);
                    Bill p = new Bill();
                    if ( elem["amount"].AsInt32 / totalCitizens > votethreshold)
                    {
                        string text = Newtonsoft.Json.JsonConvert.SerializeObject(new
                        {
                            legal_action = "CREATE",
                            legal_object = "LAW",
                            legal_type = elem["legal_type"].AsString,
                            originator_id = elem["orignator_id"].AsString,
                            target_id = elem["db_id"].AsString,
                            db_id = SequentialGuidGenerator.Instance.NewGuid(),
                            output_id = "needs to be same format but unique, mostly for new wallet outputs",
                            amount = elem["amount"].AsString,
                            title = elem["title"].AsString,
                            desc = elem["desc"].AsString,
                            deadline = unixTimestamp+100000
                        });
                        var document = BsonSerializer.Deserialize<BsonDocument>(text);
                        TxCollectionSingleton.collectioninstance.InsertOne(document);
                    }
                }
            }
        }
    }
}
