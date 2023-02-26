using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Models
{
    public class DayModel
    {
        public string Avgtemp_c { get; set; }
        public string Avgvis_km { get; set; }
        public ConditionModel Condition { get; set; }
       
    }
}
