namespace Entities.Dtos
{
    public class CategoryListDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public byte OrderNumber { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
