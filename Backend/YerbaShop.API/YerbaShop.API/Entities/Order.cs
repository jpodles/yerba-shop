using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YerbaShop.API.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal OrderPrice { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrderDetailsId { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }

    //public int OrderHistoryId { get; set; }
    //public OrderHistory OrderHistory { get; set; }
}