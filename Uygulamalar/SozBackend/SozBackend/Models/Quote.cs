using System;
using System.Collections.Generic;

namespace SozBackend.Models;

public partial class Quote
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; } = null!;

    public virtual ICollection<Like> Likes { get; } = new List<Like>();

    public virtual User User { get; set; } = null!;
}
