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
        public void OnGet()
        {
        }
        private ref struct ICanOnlyBeAllocatedOnTheStack
        {

        }
    }
}
