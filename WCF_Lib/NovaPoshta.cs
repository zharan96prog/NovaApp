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

        public void CreatePackage(Package package)
        {
            context.Package.Add(package);
            context.SaveChanges(); 
        }
    }
}
