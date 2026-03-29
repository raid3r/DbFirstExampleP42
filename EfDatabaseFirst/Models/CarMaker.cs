using System;
using System.Collections.Generic;

namespace EfDatabaseFirst.Models;

public partial class CarMaker
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
