﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MAS_Core.Context;
using MAS_Core.Models;

namespace MAS_Core.Pages.Employees.E2
{
    public class IndexModel : PageModel
    {
        private readonly MAS_Core.Context.CargoDatabaseContext _context;

        public IndexModel(MAS_Core.Context.CargoDatabaseContext context)
        {
            _context = context;
        }

        public IList<Dispatcher> Dispatcher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dispatchers != null)
            {
                Dispatcher = await _context.Dispatchers.ToListAsync();
            }
        }
    }
}
