﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public IList<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        public Department FindById(int id)
        {
            return _context.Department.FirstOrDefault(x => x.Id == id);
        }

    }
}
