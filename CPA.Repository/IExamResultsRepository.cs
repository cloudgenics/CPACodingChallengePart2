using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Repository
{
    public interface IExamResultsRepository
    {
        List<ExamResult> GetExamResults();
    }
}
