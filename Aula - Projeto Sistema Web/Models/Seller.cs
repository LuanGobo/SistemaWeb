using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Sales { get; set; } = new List<SallesRecord>();

        public Seller() { }

        public Seller(int id, string name, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SallesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSakes (SallesRecord sr)
        {

        Sales.Remove(sr); 
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
