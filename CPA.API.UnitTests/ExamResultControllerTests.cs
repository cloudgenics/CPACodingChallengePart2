using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using CPA.Entities;


namespace CPA.API.UnitTests
{
    public class ExamResultControllerTests: BaseExamControllerTests
    {

        private static readonly List<ExamResult> examResults = new List<ExamResult>
        {
            new ExamResult
            {
                Subject = "Financial Accounting",
                Results = new List<Score>
                {
                    new Score
                    {
                        Year = 2015,
                        Grade = "FAIL"
                    },
                    new Score
                    {
                        Year = 2016,
                        Grade = "PASS"
                    },

                }
            },
            new ExamResult
            {
                Subject = "Financial Risk Management",
                Results = new List<Score>
                {
                    new Score
                    {
                        Year = 2015,
                        Grade = "FAIL"
                    },
                    new Score
                    {
                        Year = 2016,
                        Grade = "PASS"
                    },

                }
            }
        };

        public ExamResultControllerTests(): base(examResults)
        {
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _examResultsController.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnListOfExamResults()
        {
            var result = _examResultsController.Get().Result as OkObjectResult;

            var examResults = Assert.IsType<List<ExamResult>>(result.Value);
            Assert.Equal(2, examResults.Count());

        }
    }
}
