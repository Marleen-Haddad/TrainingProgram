using Microsoft.AspNetCore.Mvc;
using Training_Programm___Week_1.Models;

namespace Training_Programm___Week_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetEmployeesSalariesController : ControllerBase
    {


        private readonly ILogger<GetEmployeesSalariesController> _logger;

        public GetEmployeesSalariesController(ILogger<GetEmployeesSalariesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSalary")]
        public double Get(string type)
        {
            Manager manager = new Manager(2000, 2000);
            LeadDeveloper leadDeveloper = new LeadDeveloper(1000, manager);
            Developer developer = new Developer(700, leadDeveloper);
            HR hR = new HR(80,manager);
            Sales sales = new Sales(400, manager, 500);

            switch (type)
            {
                case "manager":
                    return manager.GetSalary();
                case "lead":
                    return leadDeveloper.GetSalary();
                case "developer":
                    return developer.GetSalary();
                case "sales":
                    return sales.GetSalary();
                    default:
                  return  -1;

            }
        }
    }
}