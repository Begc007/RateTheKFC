using RateTheKFC.Data;
using RateTheKFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateTheKFC.Services {
    public class CompanyService {
        private readonly AppDbContext _context;
        public CompanyService(AppDbContext context) {
            _context = context;
        }

        public List<Company> GetCompanies() {
            return _context.Companies.OrderBy(x => x.Name).ToList();
        }
    }
}
