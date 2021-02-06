using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shard.Infrastructure
{
    public interface IShard
    {
        int Id { get; set; }

        ValueTask Stop(CancellationToken token = default);

        ValueTask Start(CancellationToken token = default);
    }
}
