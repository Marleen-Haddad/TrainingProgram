using Newtonsoft.Json;
using TrainingProgram;
using TrainingProgram.Models;
using Week1.Common;


namespace Week1.DAL
{
    public class LeadDeveloperDAL
    {
        public LeadDeveloper? GetLeadDeveloperByGuid(Guid guid, ManagerDAL managerDAL)
        {
            List<LeadDeveloper> leadDevelopers = JsonConvert.DeserializeObject<List<LeadDeveloper>>(Helpers.GetModelFileContent("leadDeveloperData"));
            LeadDeveloper leadDeveloper = leadDevelopers.Where(l => l.guid == guid).FirstOrDefault();
            if (leadDeveloper != null) {
                Employee manager = managerDAL.GetManagerByGuid(leadDeveloper.managerGuid);
                leadDeveloper.SetManager(manager);
            }

            return leadDeveloper;
        }
    }
}
