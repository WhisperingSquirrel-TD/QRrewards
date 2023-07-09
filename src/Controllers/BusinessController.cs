using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LoyaltyApp.Data;
using LoyaltyApp.Models;

namespace LoyaltyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BusinessController(DatabaseContext context)
        {
            _context = context;
        }

        // Other methods for handling HTTP requests related to businesses...
    }
}
