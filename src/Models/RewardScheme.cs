namespace LoyaltyApp.Models
{
    public class RewardScheme
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string RewardDescription { get; set; }
        public int StampsRequired { get; set; }
    }
}
