using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateTheKFC.Models {
    public class City {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Company> Companies { get; set; } = Enumerable.Empty<Company>().ToList();
    }
}
