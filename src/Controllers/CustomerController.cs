using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LoyaltyApp.Data;
using LoyaltyApp.Models;

namespace LoyaltyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CustomerController(DatabaseContext context)
        {
            _context = context;
        }

        // Other methods for handling HTTP requests related to customers...
    }
}
