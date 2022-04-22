using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Soft.Controllers
{
    public class GeneratePDFController : Controller
    {
        [HttpGet]
        [Route("DownloadPdf")]
       public IActionResult DownloadPDFFile(string pageName)
        {
            var pdf = new Data.classes.GeneratePDF($"https://{Request.Host.Value}/{pageName}");
            var pdfFile = pdf.GetPdf();

            var pdfStream = new System.IO.MemoryStream(pdfFile);
            return new FileStreamResult(pdfStream, "application/pdf");
        }
    }
}
