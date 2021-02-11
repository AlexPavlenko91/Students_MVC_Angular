using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Lesson : DbEntity
    {
        [Column("number")]
        public int Number { get; set; }

        [Column("beginTime")]
        [MaxLength(64)]
        public DateTime BeginTime { get; set; }

        [Column("endTime")]
        [MaxLength(64)]
        public DateTime EndTime { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}