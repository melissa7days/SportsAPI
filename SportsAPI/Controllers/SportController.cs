using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsAPI.BusinessLogicLayer;
using SportsAPI.DataAccessLayer;

namespace SportsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportController : Controller
    {
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            var sports = new DataLogic();
            return sports.Sports().ToArray();
        }
    }
}