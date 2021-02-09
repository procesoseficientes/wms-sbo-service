using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SBOService.Model;
using SBOService.Services;

namespace SBOService.Controllers
{
    [Route("/")]
    [ApiController]
    public class DraftDeliveryController : ControllerBase
    {
        private readonly SAPService _sapService;

        private readonly AppSettings _appSettings;

        public DraftDeliveryController(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
            _sapService = new SAPService(_appSettings);
        }

        [HttpGet]
        [Route("/")]
        public ActionResult Info()
        {
            return Ok("1.0.4");
        }

        [HttpGet]
        [Route("CloseDraft/{DocEntry}")]
        public ActionResult CancelDraftDelivery(int DocEntry)
        {
            _sapService.Connect();
            return Ok(_sapService.SaveDraftToDocument(DocEntry));
        }
    }
}