using RestaurantOrderRouting.Domain.Application.Interfaces;
using RestaurantOrderRouting.Domain.Domain.Interfaces;

namespace RestaurantOrderRouting.Domain.Application.Services
{
    public class ConsumerService(IConsumerRepository repository) : IConsumerOrderService
    {
        private readonly IConsumerRepository _repository = repository;

        public string ConsumerAnOrderInQueue()
        {
            return _repository.ConsumerAnOrderInQueue();
        }      
    }
}
