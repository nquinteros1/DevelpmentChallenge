using DevelopmentChallenge.Data.Models.Lenguajes;
using DevelopmentChallenge.Repository.Interfaces;
using DevelopmentChallenge.Repository.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevelpmentChallenge.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ShapeReportController : ControllerBase
    {
        private readonly IReporteFigurasService _reporteFigurasService;
        private readonly ILogger<ShapeReportController> _logger;

        public ShapeReportController(ILogger<ShapeReportController> logger, IReporteFigurasService reporteFigurasService)
        {
            _logger = logger;
            _reporteFigurasService = reporteFigurasService;
        }

        [HttpGet]
        public IEnumerable<ReporteFigura> Get()
        {
            return _reporteFigurasService.GetReportes(new Castellano()).ToArray();
        }
        [HttpGet("GetDetails")]
        public IEnumerable<ReporteFigura> GetDetails()
        {
            return _reporteFigurasService.GetReportes(new Castellano()).ToArray();
        }
    }
}
