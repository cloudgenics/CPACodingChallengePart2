using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using CPA.Entities;
using CPA.Repository;
using CPA.Services;
using CPA.API.Controllers;
using Microsoft.Extensions.Logging;

namespace CPA.API.UnitTests
{
  public abstract  class BaseExamControllerTests
    {
        protected readonly List<ExamResult> _examResults;
        private readonly Mock<ILogger<ExamResultsController>> _mockLogger;
        protected readonly Mock<IExamResultsService> _mockExamsService;
        protected readonly ExamResultsController _examResultsController;

        protected BaseExamControllerTests(List<ExamResult> examResults)
        {
            _examResults = examResults;
            _mockLogger = new Mock<ILogger<ExamResultsController>>();
            _mockExamsService = new Mock<IExamResultsService>();
            _mockExamsService.Setup(svc => svc.GetExamResults()).Returns(_examResults);
            _examResultsController = new ExamResultsController(_mockExamsService.Object, _mockLogger.Object);
        }
    }
}
