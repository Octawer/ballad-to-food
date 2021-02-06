using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ballad_to_food.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        private readonly IConfiguration _config;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        public void OnGet()
        {
            Message = _config["Message"];
        }
    }
}
