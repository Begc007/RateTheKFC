using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateTheKFC.Models {
    public class Feedback {
        public int Id { get; set; }
        public double? Fattiness { get; set; }
        public double? Salinity { get; set; }
        public double? Pepperiness { get; set; }
        public double? Politeness { get; set; }
        public int CompanyId { get; set; }
        public string? Comments { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
