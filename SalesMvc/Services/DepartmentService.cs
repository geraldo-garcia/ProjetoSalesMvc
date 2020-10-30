using SalesMvc.Data;
using SalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesMvcContext _context;
        public DepartmentService(SalesMvcContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()   //metodo que retorna todos os departamentos
        {
            return _context.Department.OrderBy(x => x.Name).ToList();  //OrderBy retorna a lista organizada por nomes
        }
    }
}
