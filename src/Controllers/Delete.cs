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
    public class Delete : ControllerBase
    {
        private readonly DataBaseContext _context;

        public Delete(DataBaseContext context)
        {
            _context = context;
        }

        [HttpDelete]
        public IActionResult DeleteEnrollment(int enrollment)
        {
            if (enrollment == 0 || enrollment == null)
            return BadRequest("Favor inserir um número válido de matrícula.");

            var studentDB = _context.Students.Where(p => p.Enrollment == enrollment);

            if (studentDB == null)
            return NotFound("Número de matrícula inválido");

            _context.Students.Remove(studentDB);
            return Ok();
        }
    }
}