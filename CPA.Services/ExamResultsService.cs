using System;
using System.Collections.Generic;
using CPA.Entities;
using CPA.Repository;

namespace CPA.Services
{
   public class ExamResultsService: IExamResultsService
    {
        private readonly IExamResultsRepository _subjectsRepository;
        public ExamResultsService(IExamResultsRepository subjectsRepository)
        {
            _subjectsRepository = subjectsRepository ?? throw new ArgumentNullException(nameof(subjectsRepository));
        }


       public List<ExamResult> GetExamResults()
        {
            return _subjectsRepository.GetExamResults();
        }
    }
}
