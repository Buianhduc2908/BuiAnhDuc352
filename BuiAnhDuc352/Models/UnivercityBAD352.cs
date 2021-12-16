using System;
using System.ComponentModel.DataAnnotations;

namespace BuiAnhDuc352.Models
{
    public class UnivercityBAD352

    {
        [Key]
[StringLength (20)]
private int UniversityId { get; set; }



[MaxLength (50)]
private int UniversityName { get; set; }

    }
}