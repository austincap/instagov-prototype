using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareIds.NET;
using WindowsMonitor.Software;
using Newtonsoft.Json;

namespace instagov_prototype
{
    public class GenesisKernel
    {
        
        //async public void startup()
        //{
        //    var Hwid = await HardwareIds.GetHwidAsync(new HardwareIdsConfig
        //    {
        //        ScanLocalNetworkDevices = false,
        //        ScanNeighborEndpoints = true,
        //        DurationOfNetworkScan = TimeSpan.FromSeconds(5)
        //    });
        //} 

        public string hardware_id { get; set; }
        public string blockchain_name { get; set; }
        public string this_kernel_hash { get; set; }
        public uint chain_genesis_timestamp { get; set; }
        public double voter_threshold { get; set; }
        public uint this_block_difficulty { get; set; }





    }
}
