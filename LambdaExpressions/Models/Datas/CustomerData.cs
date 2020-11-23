using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions.Models.Datas
{
    class CustomerData
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>() {
            new Customer{
            Id=1,
            FirstName="Oliver",
            LastName="Mitchell",
            },
            new Customer{
            Id=2,
            FirstName="David",
            LastName="Hancock",
            },
            new Customer{
            Id=3,
            FirstName="Mara",
            LastName="Whittle",
            },
            new Customer{
            Id=4,
            FirstName="Mandy",
            LastName="Mccall",
            },
            new Customer{
            Id=5,
            FirstName="Mark",
            LastName="Williams",
            },
            new Customer{
            Id=6,
            FirstName="Gabriel",
            LastName="Darcy",
            },
            new Customer{
            Id=7,
            FirstName="Ronald",
            LastName="Moreno",
            },
            new Customer{
            Id=8,
            FirstName="Chad",
            LastName="Calderwood",
            },
            new Customer{
            Id=9,
            FirstName="Tom",
            LastName="Wise"
            },
            new Customer{
            Id=10,
            FirstName="Mary",
            LastName="Gray",
            }
        };
    }
}
