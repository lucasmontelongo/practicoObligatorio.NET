using MongoDB.Bson;
using MongoDB.Driver;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesMongo : IDALEmployees
    {
        private IMongoDatabase _db;

        public DALEmployeesMongo()
        {
            _db = this.Connect();
        }

        private IMongoDatabase Connect()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("practicoObligatorioNET");
            return database;
        }

        private int MongoIdCount()
        {
            int id = 0;
            var filter = Builders<BsonDocument>.Filter.Eq("id", 1);
            _db.GetCollection<BsonDocument>("idCount").Find(new BsonDocument()).ToList().ForEach(x => {
                id = x["count"].AsInt32 + 1;
                var update = Builders<BsonDocument>.Update.Set("count", id);
                _db.GetCollection<BsonDocument>("idCount").UpdateOne(filter, update);
            });
            return id;
        }
        
        public void AddEmployee(Employee emp)
        {
            if(emp.GetType().Name == "FullTimeEmployee")
            {
                FullTimeEmployee ft = (FullTimeEmployee)emp;
                _db.GetCollection<BsonDocument>("employees").InsertOne(new BsonDocument()
                {
                    { "Id", this.MongoIdCount() },
                    { "Name", ft.Name },
                    { "StartDate", ft.StartDate },
                    { "Type_emp", 1 },
                    { "Salary", ft.Salary }
                });
            }
            else
            {
                PartTimeEmployee pt = (PartTimeEmployee)emp;
                _db.GetCollection<BsonDocument>("employees").InsertOne(new BsonDocument()
                {
                    { "Id", this.MongoIdCount() },
                    { "Name", pt.Name },
                    { "StartDate", pt.StartDate },
                    { "Type_emp", 1 },
                    { "HourlyRate", pt.HourlyRate }
                });
            }
        }

        public void DeleteEmployee(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Id", id);
            _db.GetCollection<BsonDocument>("employees").DeleteOne(filter);
        }

        public void UpdateEmployee(Employee emp)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Id", emp.Id);
            var update = Builders<BsonDocument>.Update.Set("Name", emp.Name);
            update.AddToSet("StartDate", emp.StartDate);
            if (emp.GetType().Name == "FullTimeEmployee")
            {
                FullTimeEmployee fte = (FullTimeEmployee)emp;
                update.AddToSet("Salary", fte.Salary);
            }
            else
            {
                PartTimeEmployee pte = (PartTimeEmployee)emp;
                update.AddToSet("HourlyRate", pte.HourlyRate);
            }
            _db.GetCollection<BsonDocument>("employees").UpdateOne(filter, update);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            _db.GetCollection<BsonDocument>("employee").Find(new BsonDocument()).ToList().ForEach(x =>
            {
                if (x["Type_emp"].AsInt32 == 1)
                {
                    employees.Add(new FullTimeEmployee()
                    {
                        Id = x["Id"].AsInt32,
                        Name = x["Name"].AsString,
                        StartDate = x["StartDate"].AsDateTime,
                        Salary = x["Salary"].AsInt32
                    });
                }
                else
                {
                    employees.Add(new PartTimeEmployee()
                    {
                        Id = x["Id"].AsInt32,
                        Name = x["Name"].AsString,
                        StartDate = x["StartDate"].AsDateTime,
                        HourlyRate = x["HourlyRate"].AsInt32
                    });
                }
            });
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Id", id);
            var emp = _db.GetCollection<BsonDocument>("employees").Find(filter).Single();
            if (emp["Type_emp"].AsInt32 == 1)
            {
                return new FullTimeEmployee()
                {
                    Id = emp["Id"].AsInt32,
                    Name = emp["Name"].AsString,
                    StartDate = emp["StartDate"].AsDateTime,
                    Salary = emp["Salary"].AsInt32
                };
            }
            else
            {
                return new PartTimeEmployee()
                {
                    Id = emp["Id"].AsInt32,
                    Name = emp["Name"].AsString,
                    StartDate = emp["StartDate"].AsDateTime,
                    HourlyRate = emp["HourlyRate"].AsInt32
                };
            }
        }
    }
}
