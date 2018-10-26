using BlaBla.Infrastructure;
using BlaBla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBla.Repositories
{
    public class Repository : IRepository
    {
        
        public IReadOnlyList<Student> GetStudents()
        {

            Student[] students = new[]
             {
                new Student { Name = "Foo", Grade = "3학년" },
                new Student { Name = "Foo1", Grade = "4학년" },
                new Student { Name = "Foo2", Grade = "6학년" },
                new Student { Name = "Foo3", Grade = "3학년" },
                new Student { Name = "Foo4", Grade = "2학년" },
                new Student { Name = "Foo5", Grade = "5학년" },
                new Student { Name = "John", Grade = "2학년" }
            };

            return students;
        }
    }
}
