using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker.Entities
{
    public class User
    {
        [Key] public int ID { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Surname { get; set; }

        [Required, StringLength(50), Index(IsUnique = true)] public string Login { get; set; }

        [Required, EmailAddress] public string Email { get; set; }

        [Required, StringLength(30, MinimumLength = 6), DataType(DataType.Password)] public string Password { get; set; }

        [Required] public double CardBalance { get; set; }

        [Required] public double CashBalance { get; set; }
    }
}
