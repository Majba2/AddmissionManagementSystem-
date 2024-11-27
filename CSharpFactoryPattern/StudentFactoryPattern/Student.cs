using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagement.FactoryPattern
{
     class Student : IEntity
     {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public string StudentGender { get; set; }
        public DateTime AdmissionDate { get; set; } 
        public double AdmissionFees { get; set; }

    }
}
