using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Subject: DbEntity
    {
        [Column("name")]
        [MaxLength(128)]
        public string Name { get; set; }

        public List<Schedule> Schedules { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Marks> Marks { get; set; }
        public List<TeacherSubject> TeacherSubjects { get; set; }
    }
}