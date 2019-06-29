using System.Threading.Tasks;
using Convey.CQRS.Events;

namespace Pacco.Services.Customers.Application.Services
{
    public interface IMessageBroker
    {
        Task PublishAsync(params IEvent[] events);
    }
}