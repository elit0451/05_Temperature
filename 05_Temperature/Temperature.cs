using System;

namespace _05_Temperature
{
    enum Unit
    {
        Celcius
    }
    internal class Temperature
    {
        public Temperature(Unit u, int v)
        {
            Celcius = v;
        }
        public Temperature() { }
        public int Celcius { get; internal set; }

        public int Fahrenheit { get; internal set; }

        internal static double FahrenheitToCelcius(double v)
        {
            v= (v-32.0)*5.0/9.0;
            return v;
        }

        internal static double CelciusToFahrenheit(double v)
        {
            v = v * 9.0/5.0 + 32.0;
            return v;
        }
    }
}