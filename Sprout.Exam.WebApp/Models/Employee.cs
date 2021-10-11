using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sprout.Exam.WebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public DateTime Birthdate { get; set; }
        public string Tin { get; set; }
        public int EmployeeTypeId { get; set; }
    }
}
