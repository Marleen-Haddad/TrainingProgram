using Newtonsoft.Json;
using TrainingProgram.Models;
using Week1.Common;

namespace Week1.DAL
{
    public class SalesDAL
    {
        public  Sales? GetSalesByGuid(Guid guid)
        {
            List<Sales> sales = JsonConvert.DeserializeObject<List<Sales>>(Helpers.GetModelFileContent("salesData"));
            return sales.Where(s => s.guid == guid).FirstOrDefault();
        }
    }
}
