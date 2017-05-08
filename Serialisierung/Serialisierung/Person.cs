using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    struct Person
    {
        public uint personennr { get; set; }
        public string nachname { get; set; }
        public string vorname { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public uint alter { get; set; }
    }
}
