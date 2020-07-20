using Dapr.Actors;
using Dapr.Actors.Runtime;
using System.Threading.Tasks;

namespace ActorServer
{
    internal class DemoActor : Actor, IDemoActor
    {
        public DemoActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
        }

        public Task<byte[]> SizeTest(byte[] bytes)
        {
            return Task.FromResult(bytes);
        }
    }
}