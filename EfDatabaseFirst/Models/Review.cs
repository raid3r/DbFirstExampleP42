using System;
using System.Collections.Generic;

namespace EfDatabaseFirst.Models;

public partial class Review
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public string Comment { get; set; } = null!;

    public int Rating { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Car Car { get; set; } = null!;
}
