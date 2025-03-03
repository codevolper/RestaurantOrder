using RestaurantOrderRouting.Domain.Domain.Interfaces;
using RestaurantOrderRouting.Infrastructure.ServiceBus;

namespace RestaurantOrderRouting.Infrastructure.Repositories
{
    public class ConsumerOrderQueue : IConsumerRepository
    {
        public string ConsumerAnOrderInQueue()
        {
            return RabbitFacade.GetMessageInQueue();
        }
    }
}