using RestaurantOrderRouting.Domain.Application.Interfaces;
using RestaurantOrderRouting.Domain.Domain.Entities;
using RestaurantOrderRouting.Domain.Domain.Interfaces;

namespace RestaurantOrderRouting.Domain.Application.Services
{
    public class ProducerService(IProducerRepository repository) : IProducerOrderService
    {
        private readonly IProducerRepository _repository = repository;

        // Publish a message in a queue
        public void PublishAnOrder(Order order)
        {
            _repository.PublishAnOrderMessage(order);
        }

        // Publish a message in an exchange that send to queues
        public void PublishAnOrderExchangeStack(Order order)
        {
            _repository.PublishAnOrderExchangeStack(order);
        }
    }
}
