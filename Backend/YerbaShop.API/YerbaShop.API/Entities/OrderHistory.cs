using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YerbaShop.API.Entities
{
    public class OrderHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        //public int OrderId { get; set; }
        //public Order Order { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}