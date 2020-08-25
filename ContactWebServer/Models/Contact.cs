using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace ContactWebServer.Models
{
    public class Contact
    {
        [Key]
        [StringLength(32)]
        public string ID { get; set; }

        [StringLength(128)]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }
        
        public string Nickname { get; set; }
        
        public string Company { get; set; }

        public string Email { get; set; }
        
        public string JobTitle { get; set; }
        
        public string Phone { get; set; }
        
        public string Address { get; set; }
        
        public DateTime? Birthday { get; set; }
        
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}