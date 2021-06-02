using System;

namespace FlightsApi
{
    public class Flight
    {
        public int _number { get; set; }

        public string _departure { get; set; }

        public string _arrival => 32 + (int)(TemperatureC / 0.5556);

        public int _price { get; set; }
    }
}
