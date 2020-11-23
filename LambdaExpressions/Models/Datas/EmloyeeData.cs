using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions.Models.Datas
{
    class EmloyeeData
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>() {
            new Employee{
            Id=1,
            FirstName="Oliver",
            LastName="Mitchell",
            },
            new Employee{
            Id=2,
            FirstName="David",
            LastName="Hancock",
            },
            new Employee{
            Id=3,
            FirstName="Mara",
            LastName="Whittle",
            },
            new Employee{
            Id=4,
            FirstName="Mandy",
            LastName="Mccall",
            },
            new Employee{
            Id=5,
            FirstName="Mark",
            LastName="Williams",
            },
            new Employee{
            Id=6,
            FirstName="Gabriel",
            LastName="Darcy",
            },
            new Employee{
            Id=7,
            FirstName="Ronald",
            LastName="Moreno",
            },
            new Employee{
            Id=8,
            FirstName="Chad",
            LastName="Calderwood",
            },
            new Employee{
            Id=9,
            FirstName="Tom",
            LastName="Wise"
            },
            new Employee{
            Id=10,
            FirstName="Mary",
            LastName="Gray",
            }
        };
    }
}
