//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EsemkaFoodcourt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.ReservationDetails = new HashSet<ReservationDetail>();
        }
    
        public int ID { get; set; }
        public int UserID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public int NumberOfPeople { get; set; }
        public int TableID { get; set; }
        public System.DateTime ReservationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; }
        public virtual Table Table { get; set; }
        public virtual User User { get; set; }
    }
}
