using Newtonsoft.Json;
using TrainingProgram.Models;
using Week1.Common;

namespace Week1.DAL
{
    public class DeveloperDAL
    {
        public  Developer? GetDeveloperByGuid(Guid guid)
        {
            List<Developer> developers = JsonConvert.DeserializeObject<List<Developer>>(Helpers.GetModelFileContent("developerData"));
            return developers.Where(m => m.guid == guid).FirstOrDefault();
        }
    }
}
