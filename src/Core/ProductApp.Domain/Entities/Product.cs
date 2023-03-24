using ProductApp.Domain.Common;

namespace ProductApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public Decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}