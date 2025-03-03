using Microsoft.AspNetCore.Mvc;
using RestaurantOrderRouting.Domain.Application.Interfaces;

namespace RestaurantOrderRouting.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerOrderController(ILogger<ConsumerOrderController> logger, IConsumerOrderService consumer) : ControllerBase
    {
        #region private properties
        private readonly ILogger<ConsumerOrderController> _logger = logger;

        private readonly IConsumerOrderService _consumer = consumer;
        #endregion

        [HttpGet(Name = "GetOrderItems")]
        public async Task<string> ConsumeOrderItems()  
        {
            _logger.LogInformation("Target order requested");
            await Task.CompletedTask;
            return _consumer.ConsumerAnOrderInQueue();
        }
    }
}
