using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class IndexerModel : PageModel, ICSharpMarker
    {
        int[] ints = Enumerable.Range(0, 10).ToArray();
        public int this[int i]
        {
            get
            {
                return ints[i];
            }
            set
            {
                ints[i] = value;
            }
        }
        public void OnGet()
        {
        }
    }
}
