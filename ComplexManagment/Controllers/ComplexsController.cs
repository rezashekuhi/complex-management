using ComplexManagment.Dto.Complexs;
using ComplexManagment.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplexManagment.Controllers
{
    [Route("complexs")]
    [ApiController]
    public class ComplexsController : ControllerBase
    {
        private readonly EFDataContext _context;

        public ComplexsController(EFDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Add([FromBody] AddComplexDto dto)
        {
            var complex = new Complex
            {
                Name = dto.Name,
                UnitCount = dto.UnitCount,
            };

            _context.Complexs.Add(complex);
            _context.SaveChanges();
        }
    }
}
