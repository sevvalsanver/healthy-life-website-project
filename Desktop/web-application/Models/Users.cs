//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int id { get; set; }
        public string usernameSurname { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public Nullable<decimal> kg { get; set; }
        public Nullable<decimal> boy { get; set; }
        public Nullable<decimal> water { get; set; }
        public string area { get; set; }
        public string tel { get; set; }
        public Nullable<System.DateTime> birth { get; set; }
        public string address { get; set; }
    }
}