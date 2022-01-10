using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET_Practice
{
 public   class Employee_Repos
    {
        public static string connectionString = @"Server=(localdb)\\MSSQLLOCALDB (DESKTOP-U23RQH1\\CSC);Database=EmployeePayroll";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetAllEmployee()
        {
            try
            {
               Employee_Model employee  = new Employee_Model();
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("spGetAllAddressBook", this.connection);
                    command.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            employee.id= dr.GetString(0);
                            employee.Name = dr.GetString(1);
                            employee.Salary = dr.GetString(2);
                            employee.StartDate = dr.GetInt32(3);
                            employee.Phone = dr.GetInt32(4);
                            employee.Department = dr.GetString(5);
                            employee.address = dr.GetString(6);
                            employee.Basicpay = dr.GetFloat(7);
                            employee.deductions = dr.GetFloat(8);
                            employee.Taxablepay = dr.GetFloat(9);
                            employee.netpay = dr.GetFloat(10);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", employee.id, employee.Name
                                , employee.Salary, employee.StartDate, employee.Phone, employee.Department, employee.address, employee.Basicpay, 
                                employee.deductions, employee.Taxablepay, employee.netpay);

                        }
                        dr.Close();
                        this.connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

    }
}
