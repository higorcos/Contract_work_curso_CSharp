using System.Collections.Generic;
using Services.Enums;
using Services;


namespace Services
{
    class Worker
    {
        public string Name {get; set;}
        public WorkerLevel Level {get; set;}
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContracts> Contracts { get; set; } = new List<HourContracts>();


        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContracts contract){

            Contracts.Add(contract);

        }
        public void RemoveContract(HourContracts contract){
            Contracts.Remove(contract);
        }
        public double Income(int year, int month){
            double sum = BaseSalary;

            foreach(HourContracts contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month){
                  sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
    }
}