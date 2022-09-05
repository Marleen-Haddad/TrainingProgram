using Newtonsoft.Json;
using TrainingProgram.Models;
using Week1.Common;

namespace Week1.DAL
{
    public class HrDAL
    {
        public HR? GetHrByGuid(Guid guid)
        {
            List<HR> hrs = JsonConvert.DeserializeObject<List<HR>>(Helpers.GetModelFileContent("hrData"));
            return hrs.Where(h => h.guid == guid).FirstOrDefault();
        }
    }
}
