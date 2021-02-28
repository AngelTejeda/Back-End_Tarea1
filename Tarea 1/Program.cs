using System;
using System.Linq;
using Tarea_1.DataAccess;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext dbContext = new NorthwindContext();

            var empleados = dbContext.Employees.Select(s => new
            {
                Nombre = s.FirstName,
                Apellidos = s.LastName,
                Puesto = s.Title
            }
            ).ToList();


            Console.WriteLine("Hello World!");
        }
    }
}
