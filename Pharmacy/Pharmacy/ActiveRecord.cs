using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public abstract class ActiveRecord
    {
        public abstract void Save();
        public abstract void Reload();
        protected void Open()
        {

        }

        protected void Close()
        {

        }

        public void Query()
        {

        }
    }
}
