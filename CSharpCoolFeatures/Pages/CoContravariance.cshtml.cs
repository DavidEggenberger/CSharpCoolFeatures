using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class CoContravarianceModel : PageModel, ICSharpMarker
    {
        public void OnGet()
        {
            Func<object> GiveString = () => "Func<out T> contravariant T";
            GiveString += () => "Func<out T> contravariant T";

            Func<string, object> GiveObject = st => st;
            Func<object, object> Func = st => st;
            GiveObject = Func;


        }
    }
}
