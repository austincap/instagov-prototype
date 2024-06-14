using MongoDB.Bson;
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
            using (var cursor = TxCollectionSingleton.collectioninstance.Find(filter).ToCursor())
            {
                foreach (var r in cursor.ToEnumerable())
                {
                    Debug.WriteLine(r);
                    string[] row = { "trtes", "testes", "4343" };
                    var listViewItem = new ListViewItem(row);
                    lawView.Items.Add(listViewItem);
                }
            }
                
        }
    }
}
