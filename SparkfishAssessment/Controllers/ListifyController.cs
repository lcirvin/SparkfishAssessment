using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SparkfishAssessment.Contracts.Services;
using SparkfishAssessment.Utility.Listifier;

namespace SparkfishAssessment.Controllers
{
    /// <summary>
    /// Controller for Listify-related functionality.
    /// </summary>
    [ApiController]
    public class ListifyController : ControllerBase
    {
        private readonly IListifierService listifierService;
        
        /// <summary>
        /// ListifyController constructor
        /// </summary>
        /// <param name="_listifierService">Injected implementation of IListifierService</param>
        public ListifyController(IListifierService _listifierService)
        {
            this.listifierService = _listifierService;
        }

        /// <summary>
        /// Given an enumerable range based on the provided start and end values, retrieve the value at
        /// the specified index.
        /// </summary>
        /// <param name="start">Starting value for the range in the collection</param>
        /// <param name="end">Ending value for the range in the collection</param>
        /// <param name="idx">Index of the value in the collection to retrieve</param>
        /// <returns></returns>
        [Route("listify/{start}/{end}/index/{idx}")]
        [HttpGet]
        public ActionResult<int> Get(int start, int end, int idx)
        {
            return listifierService.GetValueByIndex(start, end, idx);
        }
    }
}
