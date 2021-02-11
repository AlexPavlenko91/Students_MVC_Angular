using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Schedule : DbEntity
    {
        [Column("lessonId")]
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }


        [Column("classRoomId")]
        public Guid ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }


        [Column("subjetId")]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }


        [Column("teacherId")]
        public Guid Teacherd { get; set; }
        public Teacher Teacher { get; set; }


        [Column("groupId")]
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}