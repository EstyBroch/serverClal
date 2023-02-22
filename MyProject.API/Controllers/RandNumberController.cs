using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Services.Interfaces;
using MyProject.Services.Model;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandNumberController : ControllerBase
    {
        private readonly IRandNumber _randNumber;

        public RandNumberController(IRandNumber randNumber)
        {
            _randNumber= randNumber;
        }

        [HttpGet("{n1}/{n2}")]
        public int GetRandNumber(int n1,int n2)
        {
          return _randNumber.GetRandNumber(n1, n2);
        }
    }
}
