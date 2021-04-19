using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wczytywanie_z_pliku.Data;
using Wczytywanie_z_pliku.Models;

namespace Wczytywanie_z_pliku.Pages
{
    public class Pobrane_z_bazyModel : PageModel
    {
        private readonly ProductContext _context;
        private readonly ILogger<Pobrane_z_bazyModel> _logger;

        public Pobrane_z_bazyModel(ILogger<Pobrane_z_bazyModel> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Product> Product { get; set; }

        public void OnGet()
        {
            Product = _context.Product.ToList();
        }
    }
}
