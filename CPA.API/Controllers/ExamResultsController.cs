using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CPA.Services;
using CPA.Entities;

namespace CPA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamResultsController : ControllerBase
    {
        private readonly ILogger<ExamResultsController> _logger;
        private readonly IExamResultsService _examResultsService;
        public ExamResultsController(IExamResultsService examResultsService, ILogger<ExamResultsController> logger)
        {
            _examResultsService = examResultsService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<ExamResult>> Get()
        {
           var results =  _examResultsService.GetExamResults();
            return Ok(results);
        }
    }
}
