using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Model
{
    public class LocationModel
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Tz_id { get; set; }
        public string Localtime_epoch { get; set; }
        public string Localtime { get; set; }

    }
}
