﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace LoxNET.Transport.Http.Integrations
{
    public interface ILxHttpConnection
    {
        Task<ILxHttpResult> RequestStringAsync(string path, CancellationToken token);

        Task<ILxHttpResult> RequestByteArrayAsync(string path, CancellationToken token);
    }
}
