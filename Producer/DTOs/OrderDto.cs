namespace Producer.DTOs
{
    public class OrderDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string ProductDescription { get; set; }

        = string.Empty;
        public string ProductType { get; set; }
        public decimal PriceUnitPrice { get; set; }
        
        public ProductCategory ProductCategory { get; set; }    

        public ProductCertificate ProductCertifacate {  get; set; } 

        public Calory Calory {  get; set; }
    }

}
