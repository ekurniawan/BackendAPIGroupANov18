using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendKelasA.DAL
{
    public class Helper : IHelper
    {
        private IConfiguration _config;
        public Helper(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetConnectionString("DefaultConnection");
        }
    }
}
