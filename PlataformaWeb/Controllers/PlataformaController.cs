﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWeb.Controllers
{
    public class PlataformaController:Controller
    {
       public IActionResult Index()
        {

            return View();

        }
        
    }
}
