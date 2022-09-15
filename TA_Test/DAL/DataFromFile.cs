using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TA_Test.DAL
{
    public class DataFromFile: IDisposable
    {
        private readonly string _path = Path.Combine(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data"), "Data.txt");
        private readonly StreamReader _streamreader;

        public string GetDetails()
        {
            string result = _streamreader.ReadToEnd();
            return result;
        }

        public void Dispose()
        {
            if (_streamreader != null)
            {
                _streamreader.Dispose();
            }
        }
        public DataFromFile()
        {
            _streamreader = new StreamReader(_path);
        }

    }
}