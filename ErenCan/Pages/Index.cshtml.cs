using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.WebSite.Services;
using ErenCan.Models;

namespace ErenCan.Pages
{
    public class IndexModel : PageModel
    {
        private ILogger<IndexModel> _logger;
        public JsonFileErenCanService ErenCanService { get; }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileErenCanService erenCanService)
        {
            _logger = logger;
            ErenCanService = erenCanService;
        }
        public IEnumerable<ErenCanInfo> ErenCanInfos { get; private set; }

        public void OnGet()
        {
            ErenCanInfos = ErenCanService.GetErenCans();
        }
    }
}
