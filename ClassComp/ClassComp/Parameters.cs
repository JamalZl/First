using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComp
{
    class Parameters
    {
        public string CPU;
        public string GPU;
        public string RAM;
        public string Storage;
        public string ScreenResolution;
        public string Mouse;
        public string Keyboard;
        public string Speaker;
        public Parameters() 
        { 
        }
        public Parameters(string cpu, string gpu, string ram, string storage, string screenresolution)
        {
            CPU = cpu;
            GPU = gpu;
            RAM = ram;
            Storage = storage;
            ScreenResolution = screenresolution;
        }
        public Parameters(string cpu, string gpu, string ram, string storage, string screenresolution, string mouse, string keyboard, string speaker) : this(cpu, gpu, ram, storage, screenresolution) 
        {
            Mouse = mouse;
            Keyboard = keyboard;
            Speaker = speaker;
        }
        public string GetParams() 
        {
            return $"{CPU} {GPU} {RAM} {Storage} {ScreenResolution}";
        }
        public string GetFullParam()
        {
            return $"{GetParams()} {Mouse} {Keyboard} {Speaker}";

        }
    }
}
