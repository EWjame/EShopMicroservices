using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand,TResponse>
    {
        
    }
}