using System;

namespace LoyaltyApp.Models
{
    public class Stamp
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BusinessId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
