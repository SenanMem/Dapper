using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dapper_Console;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "data source=STHQ0123-04;initial catalog=CarDb;persist security info=True;user id=admin;password=admin;MultipleActiveResultSets=True;App=EntityFramework";
            connection.Open();
            var sqlCommand = "SELECT * FROM Cars INNER JOIN Owner ON Cars.Owner_Id = Owner.id";
            List<Car> cars=connection.Query<Car, Owner,Car>(sqlCommand,(car,owner)=>
            {
                car.owner = owner;
                return car;
            }).ToList();
            cars.ForEach(x => Console.WriteLine(x.ToString()));

        }
    }
}
