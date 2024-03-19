using ProductCatalog.Entities;

namespace OrderManagement.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
