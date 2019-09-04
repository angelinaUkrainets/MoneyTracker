using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OperationAddModel
    {
        public double Summ { get; set; }

        public int CategoryId { get; set; }

        public int WayOfPayId { get; set; }

        public bool IsProfit { get; set; }
    }
}
