using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Device.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;

namespace Device
{
    public class Device : Actor<DeviceState>, IDevice
    {
        public override Task OnActivateAsync()
        {
            if (this.State == null)
            {
                this.State = new DeviceState() {
                    DeviceId = this.GetActorId().GetStringId(),
                    UserPolicies = new Dictionary<string, string>(),
                    OrgPolicies = new Dictionary<string, string>()
                };
            }

            ActorEventSource.Current.ActorMessage(this, "State initialized to {0}", this.State);
            return Task.FromResult(true);
        }

        public bool UserHasAccess(string UserId)
        {
            //throw new NotImplementedException();

            return this.State.UserPolicies.Keys.Contains(UserId);
        }

        public string[] GetUsers()
        {
            //throw new NotImplementedException();

            return this.State.UserPolicies.Keys.ToArray();
        }

        public string[] GetOrganizations()
        {
            //throw new NotImplementedException();
            return this.State.OrgPolicies.Keys.ToArray();
        }

        public string GetUserAccessToken(string UserId)
        {
            throw new NotImplementedException();
        }

        public void AddUser(string UserId)
        {
            //throw new NotImplementedException();
            this.State.UserPolicies.Add("UserId", string.Empty);
        }

        public void RemoveUser(string UserId)
        {
            //throw new NotImplementedException();
            this.State.UserPolicies.Remove(UserId);
        }

        public void AddOrganization(string OrgId)
        {
            //throw new NotImplementedException();
            this.State.OrgPolicies.Add(OrgId, string.Empty);
        }

        public void RemoveOrganization(string OrgId)
        {
            //throw new NotImplementedException();
            this.State.OrgPolicies.Remove(OrgId);
        }
    }
}
