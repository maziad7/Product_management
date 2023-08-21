using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
