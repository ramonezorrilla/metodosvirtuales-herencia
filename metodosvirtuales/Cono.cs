using Metodosvirtuales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosvirtuales
{

    public class Cono : CuerpoRevolucion

    {
        private double altura, generatriz;

        public Cono(double radio, double altura, double generatriz): base(radio)
        { 
            this.altura = altura;
            this.generatriz = generatriz;
        
        }

        public override double Volumen()
        {
            return (1.0/3.0)*base.Volumen()*altura;
        }

    }
    
}
