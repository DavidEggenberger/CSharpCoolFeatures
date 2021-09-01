using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class RefStructModel : PageModel, ICSharpMarker
    {
        //Struct structt; => not possible => would mean allocation on the heap
        public void OnGet()
        {
            Struct canOnlyBeAllocatedOnTheStack = new Struct();
        }
        public ref struct Struct
        {
            public int Property { get; set; }
        }
    }
}
