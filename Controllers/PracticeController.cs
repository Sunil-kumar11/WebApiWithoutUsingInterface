using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithoutUsingInterface.Controllers
{

    [ApiController]
    public partial class PracticeController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetMovies(int SL_No, String MovieName)
        {
            return Ok($"Top 5 Movies 2022 SL_No :{SL_No} movie Name :{MovieName}");
        }


    }
}