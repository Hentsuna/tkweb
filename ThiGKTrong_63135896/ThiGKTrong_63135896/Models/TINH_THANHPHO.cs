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

    public partial class TINH_THANHPHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINH_THANHPHO()
        {
            this.DIEMDULICHes = new HashSet<DIEMDULICH>();
        }
    
        [Display(Name = "Mã tỉnh")]
        public string Matinh { get; set; }

        [Display(Name = "Tên tỉnh")]
        public string Tentinh { get; set; }

        [Display(Name = "Ghi chú")]
        public string Ghichu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEMDULICH> DIEMDULICHes { get; set; }
    }
}
