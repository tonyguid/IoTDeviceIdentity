using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Device.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;

namespace Device
{
    [DataContract]
    public class UserState
    {
        [DataMember]
        public int Count;

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "UserState[Count = {0}]", Count);
        }
    }
}