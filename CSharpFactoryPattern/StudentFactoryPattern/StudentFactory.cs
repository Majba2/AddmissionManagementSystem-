using AdmissionManagement.Repository;
using CSharpFactoryPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagement.FactoryPattern
{
    public class StudentFactory : IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new Student();
        }

        
    }
}
