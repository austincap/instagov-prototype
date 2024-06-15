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




namespace instagov_prototype


{
    public partial class Form2 : Form

    {

        public Form2()
        {
            InitializeComponent();
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            Debug.WriteLine(unixTimestamp.ToString());
            var findOptions = new FindOptions { BatchSize = 3 };
            using (var cursor = TxCollectionSingleton.collectioninstance.Find(new BsonDocument("deadline", new BsonDocument("$lt", unixTimestamp))).ToCursor())
            {
                listView1.View = View.Details;

                foreach ( var elem in cursor.ToEnumerable())
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
                    var listViewItem = new ListViewItem(new string[] { elem["db_id"].AsString, elem["title"].AsString, elem["legal_type"].AsString, elem["desc"].AsString, Convert.ToString(elem["deadline"].AsInt32)} );
                    listView1.Items.Add(listViewItem);
                }
            }
           
        }
    }
}
