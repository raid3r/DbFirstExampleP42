



using DbExample.Models;
using Microsoft.Data.SqlClient;

var connectionString = "Data Source=SILVERSTONE\\SQLEXPRESS;Initial Catalog=DbFirstExampleP42;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";

var database = new Database(connectionString);

Console.WriteLine("Menu:");
Console.WriteLine("1. Get all cars");
Console.WriteLine("2. Get cars by color");
Console.WriteLine("3. Add new car");
Console.WriteLine("6. Update existing car");
Console.WriteLine("7. Delete car by Id");

Console.WriteLine("Enter your choice:");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        var allCars = database.GetAllCars();
        foreach (var car in allCars)
        {
            Console.WriteLine($"{car.Id}: {car.Make} {car.Model} ({car.Year}) - {car.Color} - In Stock: {car.InStock} - Price: {car.Price}");
        }
        break;
    case "2":
        Console.WriteLine("Enter color:");
        var color = Console.ReadLine();
        var carsByColor = database.GetCarsByColor(color);
        foreach (var car in carsByColor)
        {
            Console.WriteLine($"{car.Id}: {car.Make} {car.Model} ({car.Year}) - {car.Color} - In Stock: {car.InStock} - Price: {car.Price}");
        }
        break;
    case "3":
        Console.WriteLine("Enter Make:");
        var make = Console.ReadLine();
        Console.WriteLine("Enter Model:");
        var model = Console.ReadLine();
        Console.WriteLine("Enter Year:");
        var year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Color:");
        var newColor = Console.ReadLine();
        Console.WriteLine("Is it in stock? (true/false):");
        var inStock = bool.Parse(Console.ReadLine());
        Console.WriteLine("Enter Price:");
        var price = decimal.Parse(Console.ReadLine());

        var newCar = new Car
        {
            Make = make,
            Model = model,
            Year = year,
            Color = newColor,
            InStock = inStock,
            Price = price
        };

        database.AddCar(newCar);
        break;
    case "4":
        Console.WriteLine("Enter Id of the car to update:");
        var idToUpdate = int.Parse(Console.ReadLine());
        var carToUpdate = database.GetAllCars().FirstOrDefault(c => c.Id == idToUpdate);
        if (carToUpdate == null)
        {
            Console.WriteLine("Car not found");
            break;
        }
        Console.WriteLine("Enter new Make (leave empty to keep current):");
        var newMake = Console.ReadLine();
        carToUpdate.Make = string.IsNullOrEmpty(newMake) ? carToUpdate.Make : newMake;
        Console.WriteLine("Enter new Model (leave empty to keep current):");
        var newModel = Console.ReadLine();
        carToUpdate.Model = string.IsNullOrEmpty(newModel) ? carToUpdate.Model : newModel;
        Console.WriteLine("Enter new Year (leave empty to keep current):");
        var newYearInput = Console.ReadLine();
        carToUpdate.Year = string.IsNullOrEmpty(newYearInput) ? carToUpdate.Year : int.Parse(newYearInput);
        Console.WriteLine("Enter new Color (leave empty to keep current):");
        var newColorInput = Console.ReadLine();
        carToUpdate.Color = string.IsNullOrEmpty(newColorInput) ? carToUpdate.Color : newColorInput;
        Console.WriteLine("Is it in stock? (true/false, leave empty to keep current):");
        var inStockInput = Console.ReadLine();
        carToUpdate.InStock = string.IsNullOrEmpty(inStockInput) ? carToUpdate.InStock : bool.Parse(inStockInput);
        Console.WriteLine("Enter new Price (leave empty to keep current):");
        var priceInput = Console.ReadLine();
        carToUpdate.Price = string.IsNullOrEmpty(priceInput) ? carToUpdate.Price : decimal.Parse(priceInput);
        database.UpdateCar(carToUpdate);
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}




// SQL Injection Example (небезпечно, не використовуйте в реальних додатках!)
// SELECT Id, Make, Model, Year, Color, InStock, Price FROM Cars WHERE COLOR = '{color}'
// з видаленням усієї таблиці:
// GetCarsByColor("Black'; DROP TABLE Cars; --")

//var cars = database.GetCarsByColor("Black");
//// SELECT Id, Make, Model, Year, Color, InStock, Price FROM Cars WHERE Color = 'Black\'\; DROP TABLE Cars\; --'
//foreach (var car in cars)
//{
//    Console.WriteLine($"{car.Id}: {car.Make} {car.Model} ({car.Year}) - {car.Color} - In Stock: {car.InStock} - Price: {car.Price}");
//}


/*
 * Реалізувати 
 * - оновлення існуючого автомобіля 
 * - видалення автомобіля за Id
 * 
 * 
 * 
 */
