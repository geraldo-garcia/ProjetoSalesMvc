using SalesMvc.Data;
using SalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesMvcContext _context;
        public DepartmentService(SalesMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()   //metodo que retorna todos os departamentos
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();  //OrderBy retorna a lista organizada por nomes
        }
    }
}
