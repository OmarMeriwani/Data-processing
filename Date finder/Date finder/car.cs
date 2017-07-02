using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


    enum FuelType
    {
        Diesel,
        Hybrid,
        Electric,
        Petrol
    }
    abstract class car
    {
        protected Color car_color;
        protected int number_of_doors;
        protected float engine_size;
        protected FuelType fuel_type;
        public abstract Color color { get; }
        public abstract int Doors { get; }
        public abstract float EngineSize { get; }
        public abstract FuelType FuelType { get; }
    }

