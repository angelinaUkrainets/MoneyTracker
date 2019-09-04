using MoneyTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Category
    {
        [Key] public int ID { get; set; }

        [Required] public string Name { get; set; }

        [ForeignKey("UserOf")] public int UserId { get; set; }

        public virtual User UserOf { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }

        public double Summ { get; set; }
        
        [Required] public string ImageSource { get; set; }
    }
}
