using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<HelloWorld>/
        public string Index()
        {
            return "Hello this is Index.";
        }


        // GET: /<HelloWorld>/
        public string welcome(string name="Who", int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {id}");
        }
    }
}
