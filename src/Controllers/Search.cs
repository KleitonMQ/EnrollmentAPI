using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EnrollmentAPI.src.context;
using EnrollmentAPI.src.entities;

namespace EnrollmentAPI.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Search : ControllerBase
    {
        private readonly DataBaseContext _context;

        public Search(DataBaseContext context)
        {
            _context = context;
        }
    }
}