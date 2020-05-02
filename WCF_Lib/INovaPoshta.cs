using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Lib
{
    [ServiceContract]
    public interface INovaPoshta
    {
        [OperationContract]
        string GetData(int value);
    }
 }
