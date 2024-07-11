using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeriMvcAsp.Models
{
    public class StudentModel
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Confirm_Password { get; set; }
    }
}