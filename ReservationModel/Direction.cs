//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direction
    {
        public Direction()
        {
            this.Business = new HashSet<Business>();
        }
    
        public int directionId { get; set; }
        public string number { get; set; }
        public string street { get; set; }
        public string colony { get; set; }
        public string city { get; set; }
        public int postalCod { get; set; }
    
        public virtual ICollection<Business> Business { get; set; }
    }
}
