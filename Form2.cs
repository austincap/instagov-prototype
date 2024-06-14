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




namespace instagov_prototype


{
    public partial class Form2 : Form

    {

        public Form2()
        {
            InitializeComponent();
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
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
                    Bill result = Newtonsoft.Json.JsonConvert.DeserializeObject<Bill>(jsonOutput);
                    Debug.WriteLine(result.title);
                    var listViewItem = new ListViewItem(new string[] { "test"} );
                    listView1.Items.Add(listViewItem);
                }
            }
           
        }
    }
}
