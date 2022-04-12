using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    public enum Gender { M, F, X };
    class Employee
{
    public string name { get; set; }
    public int id;
        public Gender gender;
   

    public override string ToString()
    {
        return "name: " + name + " id: " + id + " gender: " + gender;
    }
    }
}
