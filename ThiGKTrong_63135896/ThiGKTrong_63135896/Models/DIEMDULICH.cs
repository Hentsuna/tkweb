﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThiGKTrong_63135896.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DIEMDULICH
    {
        [Display(Name = "Mã điểm du lịch")]
        public string Madiemdl { get; set; }

        [Display(Name = "Tên điểm du lịch")]
        public string Tendiemdl { get; set; }

        [Display(Name = "Ngày cập nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngaycapnhat { get; set; }

        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Anhdaidien { get; set; }

        [Display(Name = "Mã tỉnh thành phố")]
        public string Matinh_Thanhpho { get; set; }

        public virtual TINH_THANHPHO TINH_THANHPHO { get; set; }
    }
}
