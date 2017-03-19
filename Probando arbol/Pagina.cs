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



        //Pagina padre;
        //int nodos; //cantidad de nodos disponibles
        //int m= 5; //editar para cambiar el orden del arbols
        //int maxRamas;

        //int maxClaves;
        //int minClaves;

        //Pagina[] ramas;
        //Nodo[] claves;



        //public Pagina()
        //{
        //    this.m = 5;

        //    this.maxRamas = m;

        //    this.maxClaves = m - 1;
        //    this.minClaves = (m - 1) / 2;

        //    this.padre = null;
        //    this.nodos = 0;

        //    claves = new Nodo[m];
        //    ramas = new Pagina[m + 1];
        //}


        //public Nodo[] Claves
        //{
        //    get { return claves; }
        //    set { claves = value; }
        //}


        //public void insert(Nodo clave,int pos)
        //{
        //    Nodo nuevo = clave;

        //        Claves[pos] = nuevo;

        //        Claves[pos].reiniciar();
        //        nodos++;


        //}

        //public Pagina Padre
        //{
        //    get { return padre; }
        //    set { padre = value; }
        //}


        //public bool estaVacia()
        //{
        //    if (this.nodos == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool Estalleno()
        //{
        //    if (Claves[4]!= null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}



    }
}