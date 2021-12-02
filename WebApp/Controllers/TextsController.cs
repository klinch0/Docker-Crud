using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextsController : Controller
    {
        private readonly TextContext _context;

        public TextsController(TextContext context)
        {
            _context = context;
        }

        // GET: Texts
        [HttpGet]
        public string GetTexts()
        {
            return DateTime.Now.ToString();
        }

    }
}
