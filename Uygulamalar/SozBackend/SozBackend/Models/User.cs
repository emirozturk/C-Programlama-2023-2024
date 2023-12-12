using System;
using System.Collections.Generic;

namespace SozBackend.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Like> Likes { get; } = new List<Like>();

    public virtual ICollection<Quote> Quotes { get; } = new List<Quote>();
}
