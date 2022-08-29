using Newtonsoft.Json;
using TrainingProgram.Models;
using Week1.Common;

namespace Week1.DAL
{
    public class ManagerDAL
    {
        public  Manager? GetManagerByGuid(Guid guid)
        {
            List<Manager> managers = JsonConvert.DeserializeObject<List<Manager>>(Helpers.GetModelFileContent("managerData"));
            return managers.Where(m => m.guid == guid).FirstOrDefault();
        }
    }
}
