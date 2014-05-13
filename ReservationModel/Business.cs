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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Business
    {
        public Business()
        {
            this.Message = new HashSet<Message>();
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int userId { get; set; }
        [Required(ErrorMessage = "business nameis required")]
        public string businessName { get; set; }
        [Required(ErrorMessage = "telephone is required")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "description is required")]
        public string description { get; set; }
        [Required(ErrorMessage = "style is required")]
        public Nullable<int> syleId { get; set; }
        [Required(ErrorMessage = "number of spaces is required")]
        public int numSpaces { get; set; }
        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }
        [Required(ErrorMessage = "price range is required")]
        public string priceRange { get; set; }
        public int directionId { get; set; }
        public int businessId { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime rDay { get; set; }
        [DataType(DataType.DateTime)]
        public System.TimeSpan rTime { get; set; }
        [Range(typeof(decimal), "0", "15")]
        public int people { get; set; }
        public virtual Account Account { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Style Style { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
