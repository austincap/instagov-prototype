using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace instagov_prototype
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            BsonDocument filter = new BsonDocument("$and", new BsonArray
            {
                new BsonDocument("legal_action", "CREATE"),
                new BsonDocument("$or",
        new BsonArray
        {
            new BsonDocument("legal_object", "LAW"),
            new BsonDocument("legal_object", "DEFINITION")
        })
            });
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            Debug.WriteLine(unixTimestamp.ToString());
            var findOptions = new FindOptions { BatchSize = 3 };
            using (var cursor = TxCollectionSingleton.collectioninstance.Find(filter).ToCursor())
            {
                lawView.View = View.Details;

                foreach (var elem in cursor.ToEnumerable())
                {
                    Debug.WriteLine(elem);
                    var settings = new JsonWriterSettings { Indent = true };
                    var jsonOutput = elem.ToJson(settings);
                    Console.WriteLine(jsonOutput);
                    Bill p = new Bill();


                    //JsonSerializer serializer = new JsonSerializer();
                    //Bill p = (Bill)serializer.Deserialize(new JTokenReader(jsonOutput), typeof(Bill));


                    //Bill reader = new JsonTextReader<Bill>(new StringReader(jsonOutput));
                    //Bill result = JsonSerializer.Deserialize<Bill>(reader);
                    Debug.WriteLine(elem["title"].AsString);
                    var listViewItem = new ListViewItem(new string[] { elem["db_id"].AsString, elem["title"].AsString, elem["legal_type"].AsString, elem["desc"].AsString, Convert.ToString(elem["deadline"].AsInt32) });
                    lawView.Items.Add(listViewItem);
                }
            }

        }

        private void refreshPage_Click(object sender, EventArgs e)
        {

        }
    }
}
