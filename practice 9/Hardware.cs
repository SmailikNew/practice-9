using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9
{
    struct Hardware
    {
        public string ProcessorType { get; set; }
        public int Memory { get; set; }
        public string HDD { get; set; }
        public string GPU { get; set; }

        public Hardware(string cpu, int memory, string hdd, string gpu)
        {
            ProcessorType = cpu;
            Memory = memory;
            HDD = hdd;
            GPU = gpu;
        }
    }
}
