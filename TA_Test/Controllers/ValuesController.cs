using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TA_Test.BL;
using TA_Test.DAL;

namespace TA_Test.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Details> Get()
        {
            return GetData();
        }

        private List<Details> GetData()
        {
            List<Details> result = new List<Details>();
            try
            {
                using (DataFromFile dataFromFile = new DataFromFile())
                {
                    string data = dataFromFile.GetDetails();
                    result = JsonConvert.DeserializeObject<List<Details>>(data);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
    }
}
