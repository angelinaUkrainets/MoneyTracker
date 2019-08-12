using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Operation
    {
        [Key] public int Id { get; set; }

        [Required] public double Summ { get; set; }

        [ForeignKey("CategoryOf")] public int CategoryId { get; set; }

        [ForeignKey("WayOfPayOf")] public int WayOfPayId { get; set; }

        [Required] public bool IsProfit { get; set; }

        public virtual Category CategoryOf { get; set; }

        public virtual WayOfPay WayOfPayOf { get; set; }

    }
}
