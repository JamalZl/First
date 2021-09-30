using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComp
{
    class PC:Parameters 
    {
        public string Monitor;

        public PC(string monitor)
        {
            Monitor = monitor;
        }
        public PC(string cpu, string gpu, string ram, string storage, string screenresolution, string mouse, string keyboard, string speaker) : base(cpu, gpu, ram, storage, screenresolution, mouse, keyboard, speaker)
        {
        }
        public string PcParams()
        {
            return $"{GetFullParam()} {Monitor}";
        }
    }
}

