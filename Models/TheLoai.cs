using System;
using System.Collections.Generic;

namespace PKHD_241230693_1811.Models;

public partial class TheLoai
{
    public int MaTL { get; set; }

    public string TenTL { get; set; } = null!;

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
