using System.Collections.Generic;
using CPA.Entities;

namespace CPA.Repository
{
   public class DataSet
    {
        public static List<Data> Data = new List<Data>()
        {
            new Data() {Year = 2015, Subject = "Strategic Management Accounting", IsPassed = false},
            new Data() {Year = 2016, Subject = "Strategic Management Accounting", IsPassed = true},

            new Data() {Year = 2015, Subject = "Financial Reporting", IsPassed = false},
            new Data() {Year = 2016, Subject = "Financial Reporting", IsPassed = true},

            new Data() {Year = 2016, Subject = "Advanced Taxation", IsPassed = true},

            new Data() {Year = 2015, Subject = "Financial Risk Management", IsPassed = true},

            new Data() {Year = 2015, Subject = "Advanced Audit and Assurance", IsPassed = true}
        };
    }
}
