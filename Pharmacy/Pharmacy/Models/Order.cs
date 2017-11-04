using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public class Order :ActiveRecord
    {
        int ID { get; set; }
        DateTime Date { get; set; }
        decimal Cost { get; set; }



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
