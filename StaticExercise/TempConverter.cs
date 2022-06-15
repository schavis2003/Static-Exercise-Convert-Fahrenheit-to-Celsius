using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp) 
        {
            var celTemp = (fTemp - 32) * (5 / 9);
            return celTemp;
        }

        public static double CelsiusToFaharenheit(double cTemp)
        {   
            var celTemp = (cTemp - 32) * (5 / 9);
            return (cTemp = 32) * (5 / 9); 
        }

        //Now create a static class called TempConverter. The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double,
        //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

    }
}
