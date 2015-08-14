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
    public class DeviceState
    {
        //[DataMember]
        //public string[] Organizations;

        [DataMember]
        public Dictionary<string, string> UserPolicies;

        [DataMember]
        public Dictionary<string, string> OrgPolicies;

        [DataMember]
        public string DeviceId;

        //public override string ToString()
        //{
        //    return string.Format(CultureInfo.InvariantCulture, "DeviceState[Count = {0}]", Count);
        //}
    }
}