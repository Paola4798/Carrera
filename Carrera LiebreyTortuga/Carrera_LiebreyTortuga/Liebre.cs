using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_LiebreyTortuga
{
    class Liebre 
    {
        private int _dormir = 0;
        private int _saltoGrande = 0;
        private int _resbalonGrande = 0;
        private int _saltoPequeño = 0;
        private int _resbalonPequeño = 0;
        private string _liebre;

        Random random = new Random(Guid.NewGuid().GetHashCode());


        public int Dormir
        {
            get { return _dormir; }
        }

        public int SaltosGrandes
        {
            get { return _saltoGrande; }
        }

        public int ResbalonGrande
        {
            get { return _resbalonGrande; }
        }

        public int SaltoPequeño
        {
            get { return _saltoPequeño; }
        }

        public int ResbalonPequeño
        {
            get { return _resbalonPequeño; }
        }

        public string Liebre1
        {
            get { return _liebre; }

        }


        public void CarreraLiebre()
        {
            int pasos = random.Next(1, 81);

            if (pasos == 16)
            {
                _dormir = 0;
            }
            if (pasos == 16)
            {
                _saltoGrande += 9;
            }
            if (pasos == 8)
            {
                _resbalonGrande -= 12;
            }
            if (pasos == 24)
            {
                _saltoPequeño += 1;
            }
            if(pasos == 16 )
            {
                _resbalonPequeño -= 2;
            }
            if (pasos >= 80)
            {
                _liebre = "Liebre ganadora";
            }
        }

        public override string ToString()
        {
            return _liebre + " " + "Está en " + _saltoGrande.ToString();
            return _liebre + " " + "Está en " + _saltoPequeño.ToString();
            return _liebre + " " + "Está en " + _resbalonGrande.ToString();
            return _liebre + " " + "Está en " + _resbalonPequeño.ToString();

        }
    }
}
