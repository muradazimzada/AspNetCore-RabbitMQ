using Producer.DTOs;

namespace Producer.Masstransit.SharedModels
{
    public interface OrderCreated
    {
        int Id { get; set; }

        string ProductName { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }

        string ProductDescription { get; set; }

        string ProductType { get; set; }
        decimal PriceUnitPrice { get; set; }

        ProductCategory ProductCategory { get; set; }

        ProductCertificate ProductCertifacate { get; set; }

        Calory Calory { get; set; }
    }
}
