using Microsoft.AspNetCore.Mvc;
using TrainingProgram.Models;
using Week1.DAL;

namespace TrainingProgramm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {


        private readonly ILogger<EmployeesController> _logger;
        private readonly ManagerDAL _managerDAL;
        private readonly LeadDeveloperDAL _leadDeveloperDAL;
        private readonly HrDAL _hrDAL;
        private readonly SalesDAL _salesDAL;
        private readonly DeveloperDAL _developerDAL;
        public EmployeesController(ILogger<EmployeesController> logger, ManagerDAL managerDAL, LeadDeveloperDAL leadDeveloperDAL, HrDAL hrDAL, SalesDAL salesDAL, DeveloperDAL developerDAL)
        {
            _logger = logger;
            _managerDAL = managerDAL;
            _leadDeveloperDAL = leadDeveloperDAL;
            _hrDAL = hrDAL;
            _salesDAL= salesDAL;
            _developerDAL= developerDAL;
        }

        [HttpGet]
        [Route("GetManagerSalary")]
        public decimal GetManagerSalary(Guid guid)
        {
            Manager? manager = _managerDAL.GetManagerByGuid(guid);
            return  manager?.GetSalary() ?? -1;
        }

        [HttpGet]
        [Route("GetLeadDeveloperSalary")]
        public decimal GetLeadDeveloperSalary(Guid guid)
        {
           
            LeadDeveloper? leadDeveloper = _leadDeveloperDAL.GetLeadDeveloperByGuid(guid, _managerDAL);

            return leadDeveloper?.GetSalary()?? -1;
        }

        [HttpGet]
        [Route("GetDeveloperSalary")]
        public decimal GetDeveloperSalary(Guid guid)
        {

            Developer? developer = _developerDAL.GetDeveloperByGuid(guid);
            return developer?.GetSalary() ?? -1;
        }

        [HttpGet]
        [Route("GetHrSalary")]
        public decimal GetHrSalary(Guid guid)
        {
            HR? hr = _hrDAL.GetHrByGuid(guid);
            return hr?.GetSalary() ?? -1;
        }

        [HttpGet]
        [Route("GetSalesSalary")]
        public decimal GetSalesSalary(Guid guid)
        {
            Sales sales = _salesDAL.GetSalesByGuid(guid);
            return sales.GetSalary();
        }

    }
}