using Bootcamp.Data;
using Bootcamp.Models;
using Bootcamp.Models.Request;
using Bootcamp.Models.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public Controller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMsCar>>> Get()
        {
            var listCar = await _context.MsCar
            .Select(x => new GetMsCar{
                Name = x.Name,
                Year = x.Year,
                PricePerDay = x.PricePerDay
            }).ToListAsync();

            var response = new ApiResponse<IEnumerable<GetMsCar>>{
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = listCar

            };

            return Ok(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateRegistration request) 
        {
            var isUserExists = await _context.MsCustomer.Where(x => x.Name == request.Name).AnyAsync();
            if (isUserExists)
            {
                return BadRequest("User is already exists");
            }
            var newUser = new MsCustomer{
                Name = request.Name,
                Email = request.Email,
                Password = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address
            };

            _context.MsCustomer.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
