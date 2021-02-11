using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        //[Column("Id")]
        //private new Guid Id;

        [Column("FirstName")]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Column("LastName")]
        [MaxLength(64)]
        public string LastName { get; set; }
    }
}
