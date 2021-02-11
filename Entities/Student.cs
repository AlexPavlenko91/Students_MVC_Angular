using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Student : DbEntity
    {
        [Column("firstName")]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [MaxLength(64)]
        public string LastName { get; set; }


        [Column("groupId")]
        public Guid GroupId { get; set; }
        public Group Group { get; set; }//Shell we do this?

        public List<Marks> Marks { get; set; }
    }
}