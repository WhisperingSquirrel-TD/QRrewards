using System.Collections.Generic;

namespace LoyaltyApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Business> Businesses { get; set; }
    }
}
