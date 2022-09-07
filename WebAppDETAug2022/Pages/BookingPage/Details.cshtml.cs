﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022.Data;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages.BookingPage
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppDETAug2022.Data.WebAppDETAug2022Context _context;

        public DetailsModel(WebAppDETAug2022.Data.WebAppDETAug2022Context context)
        {
            _context = context;
        }

      public Booking Booking { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FirstOrDefaultAsync(m => m.ID == id);
            if (booking == null)
            {
                return NotFound();
            }
            else 
            {
                Booking = booking;
            }
            return Page();
        }
    }
}
