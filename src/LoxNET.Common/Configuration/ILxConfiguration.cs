using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Binder;

namespace LoxNET.Configuration
{
    public interface ILxConfiguration
    {
        IEndpointSettings MiniServer { get; }

        IEventFlowSettings EventFlow { get; }
    }
}
