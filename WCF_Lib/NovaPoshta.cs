using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Lib
{
    public class NovaPoshta : INovaPoshta
    {
        NovaContext context = new NovaContext();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
