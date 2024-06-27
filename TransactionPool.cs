using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instagov_prototype
{
    internal class TransactionPool
    {
        private static volatile TransactionPool instance;

        public List<Transaction> transactions = new List<Transaction>();
        public class Transaction
        {
            string legal_action { get; set; }
            string legal_object { get; set; }
            string legal_type { get; set; }
            string originator_id { get; set; }
            string target_id { get; set; }
            string db_id { get; set; }
            string output_id { get; set; }
            string title { get; set; }
            string desc { get; set; }
            double amount { get; set; }
            uint deadline { get; set; }
            uint currentblocknumber { get; set; }
        }
        private static object syncRoot = new Object();

        private TransactionPool() { }

        public static TransactionPool Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new TransactionPool();
                        }
                    }
                }
                return instance;
            }
        }
    }


}
