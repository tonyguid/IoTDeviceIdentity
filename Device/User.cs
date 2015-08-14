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
    public class User : Actor<UserState>, IUser
    {
        public override Task OnActivateAsync()
        {
            if (this.State == null)
            {
                // todo: validate ActorIdKind is string
                this.State = new UserState() { UserId = this.GetActorId().GetStringId() };
            }

            ActorEventSource.Current.ActorMessage(this, "State initialized to {0}", this.State);
            return Task.FromResult(true);
        }

        public Task<string[]> GetDevices()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAccessPolicyToken()
        {
            throw new NotImplementedException();
        }

        public Task<string[]> GetOrganizations()
        {
            throw new NotImplementedException();
        }
    }
}
