using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessOpg.Model
{
    internal class TraningMachine
    {
        public int ID { get; set; }
        public string MachineName { get; set; }
        public string MachineVersion { get; set; }

        public TraningMachine() { }

        public TraningMachine(string machineName, string machineVersion)
        {
            MachineName = machineName;
            MachineVersion = machineVersion;
        }
    }
}
