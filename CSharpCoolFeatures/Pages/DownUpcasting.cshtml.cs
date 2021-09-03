using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class DownUpcastingModel : PageModel, ICSharpMarker
    {
        public void OnGet()
        {
            Base @base = new Derived();//Upcast
            Derived derived1 = (Derived)@base;//Downcast
        }
    }
    public class Base { }
    public class Derived : Base { }
}
