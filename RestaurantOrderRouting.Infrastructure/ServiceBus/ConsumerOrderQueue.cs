using RestaurantOrderRouting.Domain.Application.Interfaces;

namespace RestaurantOrderRouting.Infrastructure.ServiceBus
{
    public class ConsumerOrderQueue : IConsumerOrderService
    {      
        public async Task<string> ConsumerAnOrderInQueue()
        {
            return await RabbitFacade.GetMessageInQueue();
        }
    }
}