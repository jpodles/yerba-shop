using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YerbaShop.API.Models
{
    public class ReviewCreationDto
    {
        public string ReviewText { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfReview TypeOfReview { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
