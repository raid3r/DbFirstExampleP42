using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample.Models;

public class Car
{
    //Id, Make, Model, Year, Color, InStock, Price
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public bool InStock { get; set; }
    public decimal Price { get; set; }
}

/*
 * CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Make] NVARCHAR(50) NOT NULL,
	[Model] NVARCHAR(50) NOT NULL,
	[Year] INT NOT NULL,
	[Color] NVARCHAR(20) NOT NULL,
	[InStock] BIT NOT NULL,
	[Price] DECIMAL(18, 2) NOT NULL
)
 * 
 */