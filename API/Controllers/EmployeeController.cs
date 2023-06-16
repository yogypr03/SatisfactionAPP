
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EmployeeController : BaseApiController
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context){
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppEmployee>>> GetEmployees(){
            var worker  = await _context.Employees.ToListAsync();
            return worker;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppEmployee>> GetEmployee(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
        
    }
}