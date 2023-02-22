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
            int temp = 0;
            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int n = DateTime.Now.Millisecond % n2;
            while (n > n2 || n < n1)
            {
                if (n > n2)
                    n -= DateTime.Now.Millisecond % n2;
                if (n <n1)
                    n += DateTime.Now.Millisecond % n2;
            }

            return n;
        }

    }
}
