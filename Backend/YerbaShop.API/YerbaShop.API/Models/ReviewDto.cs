using System.Text.Json.Serialization;

namespace YerbaShop.API.Models
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfReview TypeOfReview { get; set; }
        public UserReviewDto User { get; set; }

    }
}