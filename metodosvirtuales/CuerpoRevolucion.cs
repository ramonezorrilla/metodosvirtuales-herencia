﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodosvirtuales
{


    public class CuerpoRevolucion
    {
        public const double PI = Math.PI;
        protected double radio;

        public CuerpoRevolucion(double radio)
        {
            this.radio = radio;

        }

        public virtual double Volumen()
        {
            return PI*radio*radio;
        }

    }

}
