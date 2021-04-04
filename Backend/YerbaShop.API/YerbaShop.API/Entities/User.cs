using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YerbaShop.API.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<OrderHistory> OrdersHistory { get; set; } = new List<OrderHistory>();


        public User()
        {

        }

        public User(int id)
        {
            Id = id;
        }

        public User(int id, string firstName, string lastName, string email, string password, int addressFK) : this(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            AddressId = addressFK;
        }
    }
}