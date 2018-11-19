using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendKelasA.Models
{
    public class Dokter
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
        public string NoTelpon { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
