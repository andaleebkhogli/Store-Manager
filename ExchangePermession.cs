//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store_Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExchangePermession
    {
        public int ep_id { get; set; }
        public Nullable<System.DateTime> ep_date { get; set; }
        public int s_id { get; set; }
        public string s_name { get; set; }
        public int c_id { get; set; }
        public Nullable<int> c_quantity { get; set; }
        public int cust_id { get; set; }
        public string cust_name { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
    }
}
