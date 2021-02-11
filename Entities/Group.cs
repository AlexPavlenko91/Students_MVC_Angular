using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Group : DbEntity
    {
        [Column("name")]
        [MaxLength(32)]
        public string Name { get; set; }


        [Column("facultyId")]
        public Guid FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Student> Students { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}