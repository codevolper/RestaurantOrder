using RestaurantOrderRouting.Domain.Domain.Entities;

namespace RestaurantOrderRouting.Domain.Domain.Interfaces
{
    public interface IProducerRepository
    {
        void PublishAnOrderMessage(Order order);

        void PublishAnOrderExchangeStack(Order order);
    }
}
