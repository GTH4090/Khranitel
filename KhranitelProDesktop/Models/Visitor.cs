using System;
using System.Collections.Generic;

namespace KhranitelProDesktop.Models;

public partial class Visitor
{
    public int Id { get; set; }

    public byte[]? Photo { get; set; }

    public int Visitid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Organisation { get; set; }

    public DateOnly Birthdate { get; set; }

    public string Passportserial { get; set; } = null!;

    public string Passportnumber { get; set; } = null!;

    public byte[]? Passportscan { get; set; }

    public string? Remark { get; set; }

    public virtual Visit Visit { get; set; } = null!;
}
