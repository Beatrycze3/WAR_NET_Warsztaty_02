using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public class Medicine : ActiveRecord
    {
        int ID { get; set; }
        string Manufacturer { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }
        bool WithPrescription { get; set; }

        //to do
        public override void Save() 
        {
            throw new NotImplementedException();
        }

        //to do
        public override void Reload() 
        {
            throw new NotImplementedException();
        }

    }
}
