
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace web_banvemaybay.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Chuyenbay
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Chuyenbay()
    {

        this.Ve = new HashSet<Ve>();

    }


    public int IDchuyenbay { get; set; }

    public string Diadiemdi { get; set; }

    public string Diadiemden { get; set; }

    public Nullable<System.DateTime> Ngaydi { get; set; }

    public Nullable<System.DateTime> Ngayve { get; set; }

    public Nullable<double> Giatien { get; set; }

    public Nullable<int> IDhang { get; set; }

    public Nullable<System.TimeSpan> Thoigiandi { get; set; }



    public virtual HangHK HangHK { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Ve> Ve { get; set; }

}

}
