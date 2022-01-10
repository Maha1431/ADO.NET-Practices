using System;

namespace ADO.NET_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee_Repos repos = new Employee_Repos();
            Employee_Model _Model = new Employee_Model();
            repos.GetAllEmployee();
        }
    }
}
