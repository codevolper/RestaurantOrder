namespace RestaurantOrderRouting.Domain.Application.Interfaces
{
    public interface IConsumerOrderService : IOrderService
    {
        string ConsumerAnOrderInQueue();
    }
}
