using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComp
{
    class Notebook:Parameters
    {
        public string Brand;
        public string Model;
        public Notebook(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Notebook(string cpu, string gpu, string ram, string storage, string screenresolution) :base( cpu, gpu, ram, storage, screenresolution  )
        {
        }
        public string NotebookParams()
        {
            return $"{GetParams()} {Brand} {Model}";
        }
    }
}
