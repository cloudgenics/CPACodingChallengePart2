using System;
using System.Collections.Generic;

namespace CPA.Entities
{
    public class ExamResult
    {
        public string Subject { get; set; }
        public List<Score> Results { get; set; }
    }
}
