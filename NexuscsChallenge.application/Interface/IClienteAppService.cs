﻿using NexuscsChallenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexuscsChallenge.application.Interface
{
    public interface IClienteAppService:IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetClientesMaster();
    }
}