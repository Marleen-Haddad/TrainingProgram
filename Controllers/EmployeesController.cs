using Microsoft.AspNetCore.Mvc;
using TrainingProgram.Models;

namespace TrainingProgramm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {


        private readonly ILogger<EmployeesController> _logger;
        
        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetManagerSalary")]
        public decimal GetManagerSalary(decimal baseSalary, decimal bonus)
        {
            Manager manager = new Manager(baseSalary, bonus);
            return manager.GetSalary();
        }

        [HttpGet]
        [Route("GetLeadDeveloperSalary")]
        public decimal GetLeadDeveloperSalary(decimal mangerBaseSalary, decimal managerBonus , decimal baseSalary)
        {
            Manager manager = new Manager(mangerBaseSalary, managerBonus);
            LeadDeveloper leadDeveloper = new LeadDeveloper(baseSalary, manager);

            return leadDeveloper.GetSalary();
        }

        [HttpGet]
        [Route("GetDeveloperSalary")]
        public decimal GetDeveloperSalary(decimal mangerBaseSalary, decimal managerBonus, decimal leadDeveloperbaseSalary , decimal baseSalary)
        {
            Manager manager = new Manager(mangerBaseSalary, managerBonus);
            LeadDeveloper leadDeveloper = new LeadDeveloper(baseSalary, manager);
            Developer developer = new Developer(baseSalary, leadDeveloper);
            return developer.GetSalary();
        }

        [HttpGet]
        [Route("GetHrSalary")]
        public decimal GetHrSalary(decimal mangerBaseSalary, decimal managerBonus,decimal baseSalary)
        {
            Manager manager = new Manager(mangerBaseSalary, managerBonus);
            HR hr = new HR(baseSalary, manager);
            return hr.GetSalary();
        }

        [HttpGet]
        [Route("GetSalesSalary")]
        public decimal GetSalesSalary(decimal mangerBaseSalary, decimal managerBonus, double preTarget, decimal baseSalary)
        {
            Manager manager = new Manager(mangerBaseSalary, managerBonus);
            Sales sales = new Sales(400, manager, 500);
            return sales.GetSalary();
        }
       
    }
}