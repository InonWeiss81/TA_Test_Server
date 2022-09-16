using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TA_Test.BL;
using TA_Test.DAL;

namespace TA_Test.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Details> Get()
        {
            List<Details> result = null;
            try
            {
                result = GetData();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        private List<Details> GetData()
        {
            List<Details> result = new List<Details>();
            try
            {
                using (DataFromFile dataFromFile = new DataFromFile())
                {
                    string data = dataFromFile.GetDetails();
                    result = JsonConvert.DeserializeObject<List<Details>>(data, new IsoDateTimeConverter { DateTimeFormat = Helper.DATE_FORMAT });
                }
                result = result.OrderByDescending(x => x.RegistrationDate).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
