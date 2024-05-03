using System;
using System.Collections.Generic;

namespace TestAPPBackend.Models;

public partial class Book
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public long? Pages { get; set; }
}
