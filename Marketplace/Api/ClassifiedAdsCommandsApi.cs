﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Api
{
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post(
            Contracts.ClassifiedAds.V1.Create request)
        {
            // handle the request here
            return Ok();
        }
    }
}
