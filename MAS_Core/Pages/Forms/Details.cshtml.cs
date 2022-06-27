﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MAS_Core.Context;
using MAS_Core.Models;

namespace MAS_Core.Pages.Forms
{
    public class DetailsModel : PageModel
    {
        private readonly MAS_Core.Context.CargoDatabaseContext _context;

        public DetailsModel(MAS_Core.Context.CargoDatabaseContext context)
        {
            _context = context;
        }

      public Form Form { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Forms == null)
            {
                return NotFound();
            }

            var form = await _context.Forms.FirstOrDefaultAsync(m => m.FormID == id);
            if (form == null)
            {
                return NotFound();
            }
            else 
            {
                Form = form;
            }
            return Page();
        }
    }
}
