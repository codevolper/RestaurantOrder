using Microsoft.AspNetCore.Mvc;
using RestaurantOrderRouting.Domain.Application.Interfaces;
using RestaurantOrderRouting.Domain.Domain.Entities;

namespace RestaurantOrderRouting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerOrderController(ILogger<ProducerOrderController> logger, IProducerOrderService orderService) : ControllerBase
    {
        #region Private properties
        private readonly ILogger<ProducerOrderController> _logger = logger;

        private readonly IProducerOrderService _orderService = orderService;
        #endregion

        [HttpPost(Name = "SendAnOrder")]
        public async Task TargetARequest([FromBody] Order order)
        {
            _logger.LogInformation("Target a request to queue");
            _orderService.PublishAnOrder(order);
            _logger.LogInformation("Request to queue finished");

            await Task.CompletedTask;
        }

        //[HttpPost(Name = "SendAnOrderToStacks")]
        //public async Task PublishOrderToQueue([FromBody] Order order)
        //{
        //    _orderService.PublishAnOrderExchangeStack(order);
        //    await Task.CompletedTask;
        //}
    }
}
