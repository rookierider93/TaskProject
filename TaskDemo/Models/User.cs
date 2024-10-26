using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskDemo.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    [MaxLength(10)]
    [DisplayName("User Name")]
    public string Name { get; set; }
    [Required]
    [MaxLength(10)]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }
}
