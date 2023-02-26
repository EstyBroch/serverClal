using MyProject.Services.Interfaces;
using MyProject.Services.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class RandNumberService : IRandNumber
    {
        public RandNumberService() { }
        public int GetRandNumber(int n1, int n2)
        {
            int temp ,n;
            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            n = DateTime.Now.Millisecond;
            n = n % (n2 - n1 + 1) + n1;
            return n;
        }

    }
}
