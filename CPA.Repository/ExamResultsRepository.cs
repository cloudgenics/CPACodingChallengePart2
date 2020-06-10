using System.Linq;
using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Repository
{
   public class ExamResultsRepository: IExamResultsRepository
    {

        public List<ExamResult> GetExamResults()
        {
            List<ExamResult> output = new List<ExamResult>();
            var rawResultsList = DataSet.Data.GroupBy(o => o.Subject).ToList();

            foreach (var results in rawResultsList)
            {
                ExamResult subjectResult = new ExamResult()
                {
                    Subject = results.First().Subject,
                    Results = results.Select(o => new Score()
                    {
                        Year = o.Year,
                        Grade = o.IsPassed ? "PASS" : "FAIL"
                    }).ToList()
                };
                output.Add(subjectResult);
            }
            return output;
        }
    
    }
}
