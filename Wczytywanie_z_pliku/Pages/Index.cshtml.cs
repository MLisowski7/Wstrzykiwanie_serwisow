using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wczytywanie_z_pliku.Models;
using Wczytywanie_z_pliku.Services;

namespace Wczytywanie_z_pliku.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        private readonly ILogger<Pobrane_z_plikuModel> _logger;

        public Pobrane_z_plikuModel(ILogger<Pobrane_z_plikuModel> logger,
             JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
