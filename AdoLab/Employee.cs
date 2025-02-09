using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLab
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Fname} {Lname} {DeptId} {DeptName}";
        }
    }
}
