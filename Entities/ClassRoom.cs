using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ClassRoom : DbEntity
    {
        [Column("name")]
        [MaxLength(64)]
        public string Name { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}