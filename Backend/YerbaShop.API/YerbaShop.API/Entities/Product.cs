using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YerbaShop.API.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal ProductPrice { get; set; }

        [Required]
        public double ProductWeight { get; set; }

        [Required]
        public string ProductImage { get; set; }

        [Required]
        public string ProductBrand { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string LongDescription { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}