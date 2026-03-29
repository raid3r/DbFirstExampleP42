using System;
using System.Collections.Generic;

namespace EfDatabaseFirst.Models;

public partial class Car
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public string Color { get; set; } = null!;

    public bool InStock { get; set; }

    public decimal Price { get; set; }

    public virtual CarMaker Make { get; set; } = null!;

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
