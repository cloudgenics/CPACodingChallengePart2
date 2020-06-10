using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Services
{
    public interface IExamResultsService 
    {
        public List<ExamResult> GetExamResults();
    }
}
