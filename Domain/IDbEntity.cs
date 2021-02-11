using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
