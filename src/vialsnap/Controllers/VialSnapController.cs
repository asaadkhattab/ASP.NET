﻿using Microsoft.AspNetCore.Mvc;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vialsnap.Controllers
{
    public class VialSnapController : Controller
    {
        public ActionResult Detail()
        {
            return Content("Hey!");
        }
    }
}