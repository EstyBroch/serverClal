using MyProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Model
{
    public class CurrentModel
    {
        public string last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public string temp_c { get; set; }
        public string temp_f { get; set; }
        public string is_day { get; set; }
        public ConditionModel Condition { get; set; }


    }



}
