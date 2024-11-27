using AdmissionManagement.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagement.Repository
{
    public class StudentRepository: IRepository
    {
        private readonly Dictionary<int, Student> _students = new Dictionary<int, Student>();
        private int _currentId = 1;

        public void Create(IEntity entity)
        {
            var student = entity as Student;
            student.StudentId = _currentId++;
            _students[student.StudentId] = student;
        }

        public IEntity Read(int StudentId)
        {
            _students.TryGetValue(StudentId, out var student);
            return student;
        }

        public void Update(IEntity entity)
        {
            var student = entity as Student;
            _students[student.StudentId] = student;
        }

        public void Delete(int StudentId)
        {
            _students.Remove(StudentId);
        }
    }
}
