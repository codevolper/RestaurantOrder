using RestaurantOrderRouting.Domain.Application.Interfaces;
using RestaurantOrderRouting.Domain.Domain.Entities;
using RestaurantOrderRouting.Domain.Domain.Interfaces;

namespace RestaurantOrderRouting.Domain.Application.Services
{
    public class ProducerService(IProducerRepository order) : IProducerOrderService
    {
        private readonly IProducerRepository _order = order;

        // Publish a message in a queue
        public void PublishAnOrder(Order order)
        {
            _order.PublishAnOrderMessage(order);
        }

        // Publish a message in an exchange that send to queues
        public void PublishAnOrderExchangeStack(Order order)
        {
            //_order.PublishAnOrderExchangeStack(order);
        }
    }
}
