using System;
using System.Collections.Generic;

namespace SozBackend.Models;

public partial class Like
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int QuoteId { get; set; }

    public virtual Quote Quote { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
