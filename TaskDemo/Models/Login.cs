using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskDemo.Models;

public class Login
{
    [DisplayName("User Name")]
    [Required]
    public string Name { get; set; }
    [DisplayName("Password")]
    [Required]
    public string Password { get; set; }

}
