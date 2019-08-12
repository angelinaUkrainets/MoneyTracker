using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class WayOfPay
    {
        [Key] public int Id { get; set; }

        [Required] public bool IsCashPayment { get; set; } 

        public virtual ICollection<Operation> Operations { get; set; }
    }
}
