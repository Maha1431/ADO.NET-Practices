using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET_Practice
{
    class Employee_Model
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public int  StartDate { get; set; }
        public int Phone { get; set; }
        public string Department { get; set; }
        public string address { get; set; }
        public float Basicpay { get; set; }
        public float deductions { get; set; }
        public float Taxablepay { get; set; }
        public float netpay { get; set; }
    }
}
