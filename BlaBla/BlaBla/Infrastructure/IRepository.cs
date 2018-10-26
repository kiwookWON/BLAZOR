using BlaBla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBla.Infrastructure
{
    public interface IRepository
    {
        IReadOnlyList<Student> GetStudents();
    }
}
