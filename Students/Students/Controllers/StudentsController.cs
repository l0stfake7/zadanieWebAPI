using Microsoft.AspNetCore.Mvc;

namespace Students.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController: Controller
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }
    }
}