using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using student_api.Model;
using student_api.Services;
using student_api.Operations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace student_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BtechStudentController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public BtechStudentController(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        [HttpGet]
        public IEnumerable<StudentDetails> GetAllBtechStudent()
        {
            // Get all registered implementations of IReminderService
            var test = _serviceProvider.GetServices<ISchoolOperation>();

            // Get required implementation from the collection
            var btechService = test.FirstOrDefault(x => x.GetType() == typeof(BtechStudentOperation));

            return btechService.GetAllStudent();
        }
    }
}

