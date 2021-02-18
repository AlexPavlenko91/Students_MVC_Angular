using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Asset : DbEntity
    {

        [Column("fileName")]
        [MaxLength(260)]
        public string FileName { get; set; }

        [Column("fileExtention")]
        [MaxLength(32)]
        public string FileExtention { get; set; }

        [Column("originalFileName")]
        [MaxLength(260)]
        public string OriginalFileName { get; set; }

        [Column("mimeType")]
        [MaxLength(64)]
        public string MimeType { get; set; }

         


    }
}