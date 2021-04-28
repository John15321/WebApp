using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class Index1Model : PageModel
    {
        private readonly ILogger<Index1Model> _logger;

        public Index1Model(ILogger<Index1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
