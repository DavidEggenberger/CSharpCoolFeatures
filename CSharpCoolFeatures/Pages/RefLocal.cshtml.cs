using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class RefLocalModel : PageModel, ICSharpMarker
    {
        public int[] integers = Enumerable.Range(0, 100).ToArray();
        private ref int RefLokal => ref GetRefToInt(9);
        public ref int GetRefToInt(int i)
        {
            return ref integers[i];
        }
        public void OnGet()
        {
            RefLokal *= 200;
        }
    }
}
