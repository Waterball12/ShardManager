using System.Threading;
using System.Threading.Tasks;
using Shard.Infrastructure;

namespace Sharder.Infrastructure
{
    public interface IShardManager
    {
        /// <summary>
        /// Starts monitoring
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task StartAsync(CancellationToken token = default);

        /// <summary>
        /// Stops the hard manager
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task StopAsync(CancellationToken token = default);

        /// <summary>
        /// Spawn the new shard
        /// </summary>
        /// <param name="shardInfo"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task Spawn(ShardInfo shardInfo, CancellationToken token = default);
    }
}