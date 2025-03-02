using RestaurantOrderRouting.Domain.Domain.Entities;

namespace RestaurantOrderRouting.Domain.Application.Interfaces
{
    public interface IProducerOrderService : IOrderService
    {
        void PublishAnOrder(Order order);

        void PublishAnOrderExchangeStack(Order order);
    }
}