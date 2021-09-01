using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpCoolFeatures.Pages
{
    public class DefensiveCopiesModel : PageModel, ICSharpMarker
    {
        public readonly ValueType valueType;
        public DefensiveCopiesModel() => valueType = new ValueType() { X = 9, Y = 9 };
        public void OnGet()
        {
            //We are operating on a defensive copy here
            valueType.ChangeCoordinates();
        }
        public struct ValueType
        {
            public int X { get; set; }
            public int Y { get; set; }
            public void ChangeCoordinates()
            {
                Random rnd = new Random();
                X = rnd.Next(0, int.MaxValue);
                Y = rnd.Next(0, int.MaxValue);
            }
            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
