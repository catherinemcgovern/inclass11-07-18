using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using classproj.Models;

using classproj.MathLibrary;

namespace classproj.Controllers
{
    public class ConverterController : Controller
    {
        public string Add(decimal left, decimal right)    
        {
            MyMathRoutines routines = new MyMathRoutines();
            decimal value = routines.Add(left, right);  
            return $"{left} plus {right} is: {left+right}";
            //Math.Ceiling(34.34);
           // return"";

        }

    public string Ceiling(decimal number)    
        {
            decimal result = Math.Ceiling(number);
            return $"The ceiling of {number} is {result}";

        }


    }
}

//AFter this close folder