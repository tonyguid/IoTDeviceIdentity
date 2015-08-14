using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace Device.Interfaces
{
    public interface IDevice : IActor
    {
        bool UserHasAccess(string UserId);

        string[] GetUsers();
        string[] GetOrganizations();
        //string GetUserAccessToken(string UserId);

        void AddUser(string UserId);

        void RemoveUser(string UserId);

        void AddOrganization(string OrgId);

        void RemoveOrganization(string OrgId);
        
    }
}
