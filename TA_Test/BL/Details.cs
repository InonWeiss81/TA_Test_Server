using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TA_Test.BL
{
    public class Details
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string RegistrationDate { get; set; }

        [JsonIgnore]
        public DateTime Date
        {
            get
            {
                return DateTime.ParseExact(RegistrationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}