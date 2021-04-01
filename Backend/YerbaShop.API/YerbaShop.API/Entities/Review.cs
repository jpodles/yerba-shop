﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YerbaShop.API.Entities
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public string ReviewText { get; set; }

        [Required]
        public string TypeOfReview { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

    }
}
