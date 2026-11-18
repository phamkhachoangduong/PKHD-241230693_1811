using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PKHD_241230693_1811.Models;

public partial class Sach
{
    public int MaSach { get; set; }
    [Display(Name = " the loai")]

    public int MaTL { get; set; }
    [Display(Name = "ten sach")]
    [Required(ErrorMessage = "ten sach ten sach khong duoc bo trng")]

    public string TenSach { get; set; } = null!;
    [Display(Name = " gia")]
    [Required(ErrorMessage = "nhap gia")]
    [Range(50, 1000, ErrorMessage =" gia phai nam trong khoang 50-1000")]
    public decimal? Gia { get; set; }
    [Display(Name = " anh")]

    public string? Anh { get; set; }

    public virtual TheLoai? MaTLNavigation { get; set; } 
}
