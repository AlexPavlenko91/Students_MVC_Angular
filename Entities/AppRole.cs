using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        //[Column("Id")]
        //private new Guid Id;

        [Column("Name")]
        [MaxLength(64)]
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string Name { get; set; }
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword


    }
}
