using MVCSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSamples.DataAccess
{
    /// <summary>
    /// Mock in-memory DB. But this would really be some external
    /// data store: e.g: SQL Server, Postgres, MySQL, 
    /// </summary>
    public class Database
    {
        public IEnumerable<Person> People
        {
            get
            {
                return new List<Person>
                {
                    new Person
                    {
                        Id = 1,
                        FirstName = "Adam",
                        Surname = "Smith",
                        Age = 29,
                        Occupation = new Occupation
                        {
                            Id = 1,
                            JobTitle = "Software Developer",
                            Salary = 100000m
                        },
                        HomeAddress = new Address
                        {
                            Id = 1,
                            Street = "9880 Id Road",
                            District = "ON",
                            City = "Quinte West",
                            County = "Vanier",
                            PostalCode = "14841",
                            Country = "Bulgaria"
                        }
                    },
                    new Person
                    {
                        Id = 1,
                        FirstName = "Graham",
                        Surname = "Hensley",
                        Age = 45,
                        Occupation = new Occupation
                        {
                            Id = 1,
                            JobTitle = "Project Manager",
                            Salary = 200000m
                        },
                        HomeAddress = new Address
                        {
                            Id = 1,
                            Street = "P.O. Box 764 9227 Magna Rd.",
                            District = "Bahia",
                            City = "Itabuna",
                            County = "Delaware",
                            PostalCode = "737975",
                            Country = "India"
                        }
                    },
                    new Person
                    {
                        Id = 1,
                        FirstName = "Hayden",
                        Surname = "Schmidt",
                        Age = 41,
                        Occupation = new Occupation
                        {
                            Id = 1,
                            JobTitle = "Doctor",
                            Salary = 250000m
                        },
                        HomeAddress = new Address
                        {
                            Id = 1,
                            Street = "284-3742 Et, Street",
                            District = "Iowa",
                            City = "Davenport",
                            County = "Doloslaskie",
                            PostalCode = "01560",
                            Country = "Somalia"
                        }
                    },
                    new Person
                    {
                        Id = 1,
                        FirstName = "Edan",
                        Surname = "Collins",
                        Age = 22,
                        Occupation = new Occupation
                        {
                            Id = 1,
                            JobTitle = "Software Developer",
                            Salary = 100000m
                        },
                        HomeAddress = new Address
                        {
                            Id = 1,
                            Street = "9880 Id Road",
                            District = "ON",
                            City = "Quinte West",
                            County = "Vanier",
                            PostalCode = "14841",
                            Country = "Bulgaria"
                        }
                    },
                    new Person
                    {
                        Id = 1,
                        FirstName = "Ferris",
                        Surname = "Clayton",
                        Age = 65,
                        Occupation = new Occupation
                        {
                            Id = 1,
                            JobTitle = "Lawyer",
                            Salary = 190000m
                        },
                        HomeAddress = new Address
                        {
                            Id = 1,
                            Street = "AP #248-915 Aenean St.",
                            District = "KD",
                            City = "Kaduna",
                            County = "MN",
                            PostalCode = "78830",
                            Country = "Heard Island and Mcdonald Islands"
                        }
                    }
                };
            }
        }
    }
}
