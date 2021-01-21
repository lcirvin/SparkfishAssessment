using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SparkfishAssessment.Utility.Listifier;

namespace SparkfishAssessment.Controllers
{

    [ApiController]
    public class ListifyController : ControllerBase
    {
        [Route("listify/{start}/{end}/index/{idx}")]
        [HttpGet]
        public ActionResult<int> Get(int start, int end, int idx)
        {
            // Given a list of numbers ranging from 100 to 200
            var list = new Listify(start, end);
            // When I access index position 50
            var val = list[idx];
            // Then I should get back a value of 150
            //val.Should().Equal(150);

            var newIndex = list.IndexOf(150);

            return val;
        }

        [Route("Test")]
        public ActionResult<string> Test()
        {
            return "Success";
        }
    }
}
