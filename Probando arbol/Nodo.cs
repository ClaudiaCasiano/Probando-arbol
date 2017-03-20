using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Probando_arbol
{
    public class Nodo
    {
        //public int nump;

        public Nodo(string val)
        {
            this.id = val;
        }

        public Nodo()
        {
        }
        string id = "-1";
        string activo;
        string usuario;
        string empresa;
        string depto;
        string fecha;
        string hora;
        public int pos = 0;


        public Nodo(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora)
        {
            this.id = id;
            this.activo = activo;
            this.usuario = usuario;
            this.empresa = empresa;
            this.depto = depto;
            this.fecha = fecha;
            this.hora = hora;
            this.pos = 0;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }



        public bool Esletra()
        {
            try
            {
                int c = Id[pos];
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("es letra");
                return true;
            }

        }






        public int nump()
        {
            String n;
            try
            {
                n = Id[pos].ToString();
            }
            catch (Exception)
            {

                n = Id[pos - 1].ToString();
                pos--;
            }

            try
            {
                int ac;
                int.TryParse(n, out ac);
                return ac;


            }
            catch (Exception)
            {

                int ac = Encoding.ASCII.GetBytes(n)[0];
                return ac;
            }


        }



        public void nextletra(int n)
        {
            pos=n;
        }

        public void reiniciar()
        {
            pos = 0;
        }



    }
}