using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.Models;

namespace Sharder.Kubernetes
{
    public class Shard
    {
        public int Id { get; init; }

        public ValueTask StartAsync()
        {
            var newShard = new V1Namespace()
            {
                ApiVersion = "v1",
                Metadata = new V1ObjectMeta()
                {
                    Name = "discord-client"
                },
                Spec = new V1NamespaceSpec()
                {
                    
                }
            };

            var result = newShard.Initialize();

            throw new NotImplementedException();
        }

        public ValueTask IdentifyAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask RestartAsync()
        {
            throw new NotImplementedException();
        }
    }
}
