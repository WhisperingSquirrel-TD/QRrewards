using System.Collections.Generic;

namespace LoyaltyApp.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public RewardScheme RewardScheme { get; set; }
    }
}
