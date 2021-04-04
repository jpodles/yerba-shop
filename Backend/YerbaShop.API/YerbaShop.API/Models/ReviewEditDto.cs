using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YerbaShop.API.Models
{
    public class ReviewEditDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfReview TypeOfReview { get; set; }
        public string ReviewText { get; set; }

    }
}
