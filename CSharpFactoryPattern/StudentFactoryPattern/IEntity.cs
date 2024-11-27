using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagement.FactoryPattern
{
    public interface IEntity
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
        string StudentPhone { get; set; }
        string StudentEmail { get; set; }
        string StudentGender { get; set; }
        DateTime AdmissionDate { get; set; }
        double AdmissionFees { get; set; }
    }
}
