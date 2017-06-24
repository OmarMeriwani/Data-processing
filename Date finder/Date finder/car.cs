using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Date_finder
{
    enum FuelType
    {
        Diesel,
        Hybrid,
        Electric,
        Petrol
    }
    abstract class car
    {
        Color car_color;
        int number_of_doors;
        float engine_size;
        FuelType fuel_type;
    }
}
