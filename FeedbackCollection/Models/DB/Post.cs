//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeedbackCollection.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public System.Guid PostUniqueCode { get; set; }
        public System.DateTime MakeDate { get; set; }
        public string MadeBy { get; set; }
    }
}
