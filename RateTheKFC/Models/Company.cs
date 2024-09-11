using System;
namespace RateTheKFC.Models {
    public class Company {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CityId { get; set; }
        public string? Address { get; set; }
        public string? TwoGisLink { get; set; }
        public string? Comments { get; set; }
        public List<Feedback> Feedbacks { get; set; } = Enumerable.Empty<Feedback>().ToList();
    }
}
