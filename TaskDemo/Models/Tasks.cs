using System;
using System.ComponentModel.DataAnnotations;

namespace TaskDemo.Models;

public class Tasks
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string TaskName { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public bool IsDone { get; set; }
}
