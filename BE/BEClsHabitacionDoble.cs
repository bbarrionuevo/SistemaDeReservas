﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClsHabitacionDoble : BEClsHabitacion
    {
        public BEClsHabitacionDoble()
        { }
        public BEClsHabitacionDoble(string numeroHabitacion, int piso = 0, int capacidad = 0, double valorNoche = 0) : base(numeroHabitacion, piso, capacidad, valorNoche)
        {
        }

       
    }
}
