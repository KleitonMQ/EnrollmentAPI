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
    public class Insert : ControllerBase
    {
        private readonly DataBaseContext _context;

        public Insert(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult InsertStudent(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return Ok();
        }
    }
}