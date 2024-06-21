using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections;
using MongoDB.Bson.Serialization;
using SequentialGuid;

namespace instagov_prototype
{


    public sealed class TxCollectionSingleton
    {
        private static volatile TxCollectionSingleton instance;
        private static object syncRoot = new Object();

        private TxCollectionSingleton() { }

        public static TxCollectionSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new TxCollectionSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        public static MongoDB.Driver.IMongoCollection<BsonDocument> collectioninstance = new MongoClient("mongodb+srv://austin:fucksluts@instagov.uludw0r.mongodb.net/").GetDatabase("maindb").GetCollection<BsonDocument>("transactions");
    
    

    }





    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
  
            //Environment.SetEnvironmentVariable("MONGODB_URI", "mongodb+srv://austin:fucksluts@instagov.uludw0r.mongodb.net/");
            //var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
            //if (connectionString == null)
            //{
            //    //mongodb+srv://austin:fucksluts@instagov.uludw0r.mongodb.net/
            //    Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
            //    Environment.Exit(0);
            //}
            //var client = new MongoClient(connectionString);
            //var collection = client.GetDatabase("maindb").GetCollection<BsonDocument>("transactions");
            //var filter = Builders<BsonDocument>.Filter.Eq("title", "austin");

            //var document = TxCollectionSingleton.collectioninstance.Find(filter).First();

            //Console.WriteLine(document);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }
}
