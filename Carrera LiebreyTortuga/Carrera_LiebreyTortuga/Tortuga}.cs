using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_LiebreyTortuga
{
    class Tortuga_ 
    {
        private int _pasoRapido = 0;
        private int _resbalon = 0;
        private int _pasoLento = 0;
        private string _tortuga;

        Random random = new Random(Guid.NewGuid().GetHashCode());


        public int PasosRapidos
        {
            get { return _pasoRapido; }
        }

        public int PasosLentos
        {
            get { return _pasoLento; }
        }

        public int Resbalon
        {
            get { return _resbalon; }
        }

        public string Tortuga
        {
            get { return _tortuga; }

        }



        public void CarreraTortuga()
        {
            int pasos = random.Next(1, 81);

            if (pasos == 40)
            {
                _pasoRapido += 3;
            }
            if (pasos == 16)
            {
                _resbalon -= 6;
            }
            if (pasos == 24)
            {
                _pasoLento += 1;
            }
            if (pasos >= 80)
            {
                _tortuga = "Tortuga ganadora";
            }
        }

        public override string ToString()
        {
            return _tortuga + " " + "Está en " + _pasoRapido.ToString();
            return _tortuga + " " + "Está en " + _pasoLento.ToString();
            return _tortuga + " " + "Está en " + _resbalon.ToString();

        }
    
    }
}
