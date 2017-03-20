using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Probando_arbol
{
    public class Pagina
    {

        //=========

        public Pagina[] Ramas = new Pagina[5];
        public Nodo[] Claves = new Nodo[5];
        public int Cuentas = 0;

        public Pagina(Nodo clave)
        {
            Claves[0] = clave;
        }

        public Pagina()
        {
        }

        //================




    }
}