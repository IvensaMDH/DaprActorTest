using Dapr.Actors;
using System.Threading.Tasks;

namespace ActorServer
{
    public interface IDemoActor : IActor
    {
        Task<byte[]> SizeTest(byte[] bytes);
    }
}