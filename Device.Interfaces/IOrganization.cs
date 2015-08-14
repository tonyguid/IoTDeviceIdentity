﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace Device.Interfaces
{
    public interface IOrganization : IActor
    {
        Task<int> GetCountAsync();

        Task SetCountAsync(int count);
    }
}
