using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Department
    {
        private static string _name; 
        public string Name //Name must be minimum 2 letter
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 2)
                {
                    Console.WriteLine("Departamentin adi minimum 2 herfden ibaret ola biler");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private static int _workerlimit;
        public int WorkerLimit //worker limit must be minimum 1
        {
            get
            {
                return _workerlimit;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Worker limit 2-den awaqi ola bilmez");
                }
                else
                {
                    _workerlimit = value;
                }
            }
        }
        private static int _salarylimit;
        public int SalaryLimit // salarylimit must be minimum 250
        {
            get
            {
                return _salarylimit;
            }
            set
            {
                if (value <= 250)
                {
                    Console.WriteLine("Salary limiti 250 den awaqi ola bilmez");
                }
                else
                {
                    _salarylimit = value;
                }
            }
        }
        
        public Employee[] Employes;

        public int CalcSalaryAverage()
        {

            int salaryaverage;
            int result = 0; 
            foreach (Employee item in Employes)
            {
                result += item.Salary;
            }
            salaryaverage = result / WorkerLimit;
            return salaryaverage;
        }

        public Department(string name,int workerlimit, int salarylimit)
        {
            Employes = new Employee[0];
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            
            

        }
        public int Average()
        {
            int salaryaverage =0;
            return salaryaverage;
        }
        

        //public void AddEmployee(Employee employee)
        //{

        //    Array.Resize(ref Employes, Employes.Length + 1);
        //    Employes[Employes.Length - 1] = employee;
        //}
    }
}
