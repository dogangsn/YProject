namespace Entities.Dtos
{
    public class ProductListDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ColorName { get; set; }
        public string Name { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public string Barcode { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool ShowHomePage { get; set; }
        public string Image{ get; set; }
        public byte OrderNumber { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        
    }
}
