using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample.Models;

public class Database
{
    private string _connectionString;
    public Database(string connectionString)
    {
        _connectionString = connectionString;
    }

    private Car MapReaderToCar(SqlDataReader reader)
    {
        return new Car
        {
            Id = reader.GetInt32(0), // або reader["Id"]
            Make = reader.GetString(1), // або reader["Make"]
            Model = reader.GetString(2), // або reader["Model"]
            Year = reader.GetInt32(3), // або reader["Year"]
            Color = reader.GetString(4), // або reader["Color"]
            InStock = reader.GetBoolean(5), // або reader["InStock"]
            Price = reader.GetDecimal(6) // або reader["Price"]
        };
    }


    public List<Car> GetAllCars()
    {
        var sql = "SELECT Id, Make, Model, Year, Color, InStock, Price FROM Cars";
        var cars = new List<Car>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sql, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cars.Add(MapReaderToCar(reader));
                }
            }
        }
        return cars;
    }


    public List<Car> GetCarsByColor(string color)
    {
        var cars = new List<Car>();

        var sql = "SELECT Id, Make, Model, Year, Color, InStock, Price FROM Cars WHERE Color=@color";
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@color", color);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cars.Add(MapReaderToCar(reader));
                }
            }
        }
        return cars;
    }


    public void AddCar(Car car)
    {
        var sql = """
            INSERT INTO Cars (Make, Model, Year, Color, InStock, Price) VALUES 
            (@make, @model, @year, @color, @inStock, @price)
            """;
            
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@make", car.Make);
            command.Parameters.AddWithValue("@model", car.Model);
            command.Parameters.AddWithValue("@year", car.Year);
            command.Parameters.AddWithValue("@color", car.Color);
            command.Parameters.AddWithValue("@inStock", car.InStock);
            command.Parameters.AddWithValue("@price", car.Price);
            var rows = command.ExecuteNonQuery();

            Console.WriteLine(rows > 0 ? "Car added successfully" : "Failed to add car");
        }
    }

    public void UpdateCar(Car car)
    {
        var sql = "UPDATE Cars SET Make=@make, Model=@model, Year=@year, Color=@color, InStock=@inStock, Price=@price WHERE Id=@id";
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@make", car.Make);
            command.Parameters.AddWithValue("@model", car.Model);
            command.Parameters.AddWithValue("@year", car.Year);
            command.Parameters.AddWithValue("@color", car.Color);
            command.Parameters.AddWithValue("@inStock", car.InStock);
            command.Parameters.AddWithValue("@price", car.Price);
            command.Parameters.AddWithValue("@id", car.Id);
            var rows = command.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Car updated successfully" : "Failed to update car");
        }
    }


    public void DeleteCar(int carId)
    {
        var sql = "DELETE FROM Cars WHERE Id=@id";
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", carId);
            var rows = command.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Car deleted successfully" : "Failed to delete car");
        }
    }


}
