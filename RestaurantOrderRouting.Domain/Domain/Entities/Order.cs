using System.Text.Json.Serialization;

namespace RestaurantOrderRouting.Domain.Domain.Entities
{
    public class Order
    {
        public string Description { get; set; } = string.Empty;

        public IList<string> Items { get; set; } = [];

        [JsonIgnore]
        public IList<Items> FoodItem { get; set; } = [];

        public string PrepareOrderDetails()
        {
            return Description + ":" + Items.Aggregate("", (current, next) => current + ":" + next);
        }
    }
}
