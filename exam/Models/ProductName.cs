using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class ProductName
    {
        [Key]
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        public string Name { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}