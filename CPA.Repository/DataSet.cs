using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Repository
{
   public class DataSet
    {
         public static readonly List<ExamResult> examResults = new List<ExamResult>
        {
            new ExamResult
            {
                Subject = "Strategic Management Accounting",
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
                Subject = "Financial Reporting",
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
                Subject = "Advanced Taxation",
                Results = new List<Score>
                {
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
                        Grade = "PASS"
                    },

                }
            },
               new ExamResult
            {
                Subject = "Advanced Audit and Assurance",
                Results = new List<Score>
                {
                    new Score
                    {
                        Year = 2015,
                        Grade = "PASS"
                    },

                }
            }

        };
    }
}
