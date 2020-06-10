using System.Linq;
using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Repository
{
   public class ExamResultsRepository: IExamResultsRepository
    {

        public List<ExamResult> GetExamResults()
        {
            return DataSet.examResults;
        }
    
    }
}
