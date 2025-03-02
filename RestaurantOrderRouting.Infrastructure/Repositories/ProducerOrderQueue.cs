using RestaurantOrderRouting.Domain.Domain.Entities;
using RestaurantOrderRouting.Domain.Domain.Interfaces;
using RestaurantOrderRouting.Infrastructure.ServiceBus;

namespace RestaurantOrderRouting.Infrastructure.Repositories
{
    public class ProducerOrderQueue : IProducerRepository
    {
        public void PublishAnOrderMessage(Order order)
        {
            RabbitFacade.SendMessageToQueue(order);
        }

        //public void PublishAnOrderExchangeStack(Order order)
        //{
        //    RabbitExchangeFacade.PublishExchangeMessage(order);
        //}       
    }
}