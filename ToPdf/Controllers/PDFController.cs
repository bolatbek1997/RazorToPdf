using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToPdf.Models;

namespace ToPdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFController : ControllerBase
    {
        private readonly IPDFService _pdfService;
        public PDFController(IPDFService pdfService)
        {
            _pdfService = pdfService;
        }
        [HttpGet("Create")]
        public async Task<IActionResult> CreatePdf()
        {
            try
            {
                var file = await _pdfService.Create();
                return File(file, "application/pdf");
            }
            catch (Exception e)
            {

                return Ok(e.ToString());
            }
           
        }
    }
}