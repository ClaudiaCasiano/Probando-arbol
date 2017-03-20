using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando_arbol
{
    class Arbol2
    {
        Queue<Pagina> lista = new Queue<Pagina>();
        public Queue<String> hijos = new Queue<String>();
        public int num = 1;
        int com = 1;


        public Pagina principal = new Pagina();
        Pagina MovDer = new Pagina();
        Pagina MovIz = new Pagina();
        Nodo Mov;
        Pagina NRaiz;
        bool EmpujarArriba = false, Esta = false;


        //============================BUSQUEDA Y VERIFICAIONES======================================

        public int BuscarNodo(Nodo clave, Pagina raiz)
        {
            com = 0;
            int j = 0;
            if (clave.Id.CompareTo(raiz.Claves[0].Id)<0/*clave.nump() < raiz.Claves[0].nump()*/)//es porque no hay que correrlo, es un |2| y la raiz es por ejemplo  |8|25|33
            {
                Esta = false;
                j = 0;
            }
            else
            {
                j = raiz.Cuentas;//el numero actual de nodos llenos
                while (clave.Id.CompareTo(raiz.Claves[j - 1].Id) <0  && j > 1)//mientras el nuevo nodo sea menor que el de la clave de la raiz -2 y j sea mayor a 1
                {
                    --j;
                }

                if (clave.Id == raiz.Claves[j - 1].Id)
                {
                    Esta = true;

                }
                else
                {
                    Esta = false;
                }

            }
            return j;
        }

        public bool pagVacia(Pagina raiz)
        {
            return (raiz == null || raiz.Cuentas == 0);//metodo guay :33
        }


        public void Empujar(Nodo clave, Pagina raiz)
        {

            int k = 0;
            Esta = false;
            if (pagVacia(raiz))
            {

                EmpujarArriba = true;
                Mov = clave;
                NRaiz = null;
            }
            else
            {
                k = BuscarNodo(clave, raiz);
                if (Esta)
                {
                    Console.WriteLine("No hay claves repetidas");
                    EmpujarArriba = false;
                }
                else
                {
                    Empujar(clave, raiz.Ramas[k]);
                    if (EmpujarArriba)
                    {
                        if (raiz.Cuentas < 4)
                        {
                            EmpujarArriba = false;
                            InsertarClave(Mov, raiz, k);
                        }
                        else
                        {
                            EmpujarArriba = true;
                            MoverNodos(Mov, raiz, k);
                        }
                    }
                }
            }
        }

        public void print()
        {
            num = 1;
            Console.WriteLine();
            hijos.Enqueue("Raiz");
            imprimir(principal);
        }



        //==============================INSERTAR NODO===============================================



        //crea un nuevo nodo con los objetos que mande
        public Nodo nuevo(string id/*, string activo, string usuario, string empresa, string depto, string fecha, string hora*/)
        {
            Nodo nuev = new Nodo(id);
            //nuev.nump() = id;
            return nuev;
        }

        // insertar para un nuevo nodo creado
        public void InsertarNuevo(Nodo nuevo)
        {
            Console.WriteLine("");
            Console.WriteLine("se incertara un nuevo nodo");
            InsertarYa(nuevo, principal);
        }


        public void InsertarYa(Nodo clave, Pagina raiz)//insertara el nuevo nodo en la raiz que manden como parametro
        {
            Empujar(clave, raiz);
            if (EmpujarArriba)
            {
                principal = new Pagina();
                principal.Cuentas = 1;
                principal.Claves[0] = Mov;
                principal.Ramas[0] = raiz;
                principal.Ramas[1] = NRaiz;
            }
            Console.WriteLine("Se inserto " + clave.Id);
        }


        public void InsertarClave(Nodo clave, Pagina raiz, int k)
        {
            int i = raiz.Cuentas;
            while (i != k)
            {
                raiz.Claves[i] = raiz.Claves[i - 1];
                raiz.Ramas[i + 1] = raiz.Ramas[i];
                --i;
            }
            raiz.Claves[k] = clave;
            raiz.Ramas[k + 1] = NRaiz;
            raiz.Cuentas = ++raiz.Cuentas;
        }

        public void MoverNodos(Nodo Clave, Pagina Raiz, int k)
        {
            int pos = 0;
            int pMedia = 0;
            if (k <= 2)
            {
                pMedia = 2;//
            }
            else
            {
                pMedia = 3;
            }
            Pagina Mder = new Pagina();
            pos = pMedia + 1;
            while (pos != 5)
            {
                Mder.Claves[(pos - pMedia) - 1] = Raiz.Claves[pos - 1];
                Mder.Ramas[pos - pMedia] = Raiz.Ramas[pos];
                ++pos;
            }
            Mder.Cuentas = 4 - pMedia;
            Raiz.Cuentas = pMedia;
            if (k <= 2)
            {
                InsertarClave(Clave, Raiz, k);
            }
            else
            {
                InsertarClave(Clave, Mder, (k - pMedia));
            }
            Mov = Raiz.Claves[Raiz.Cuentas - 1];
            Mder.Ramas[0] = Raiz.Ramas[Raiz.Cuentas];
            Raiz.Cuentas = --Raiz.Cuentas;
            NRaiz = Mder;
        }

        



        //=========================ELIMINACION  D:<   =================

        public void Eliminar(Nodo clave)
        {
            if (pagVacia(principal))
            {
                Console.WriteLine("El arbol esta vacio ");
            }
            else
            {
                Eliminara(principal, clave);
            }
        }

        public void Eliminara(Pagina Raiz, Nodo clave)
        {
            try
            {
                EliminarRegistro(Raiz, clave);
            }
            catch (Exception e)
            {
                Esta = false;
            }
            if (!Esta)
            {
                Console.WriteLine("No se encontro el elemento");
            }
            else
            {
                if (Raiz.Cuentas == 0)
                {
                    Raiz = Raiz.Ramas[0];
                }
                principal = Raiz;
                Console.WriteLine("Se elimino" + clave.Id);
            }
        }

        public void EliminarRegistro(Pagina raiz, Nodo c)
        {
            int pos = 0;
            if (pagVacia(raiz))
            {
                Esta = false;
            }
            else
            {
                pos = BuscarNodo(c, raiz);
                if (Esta)
                {
                    if (pagVacia(raiz.Ramas[pos - 1]))
                    {
                        ALV(raiz, pos);
                    }
                    else
                    {
                        Sucesor(raiz, pos);
                        EliminarRegistro(raiz.Ramas[pos], raiz.Claves[pos - 1]);
                    }
                }
                else
                {
                    EliminarRegistro(raiz.Ramas[pos], c);
                    if ((raiz.Ramas[pos] != null) && (raiz.Ramas[pos].Cuentas < 2))
                    {
                        Restablecer(raiz, pos);
                    }
                }
            }
        }

        public void Sucesor(Pagina raiz, int k)
        {
            Pagina q = raiz.Ramas[k];
            while (!pagVacia(q.Ramas[0]))
            {
                q = q.Ramas[0];
            }
            raiz.Claves[k - 1] = q.Claves[0];
        }

        public void Combina(Pagina raiz, int pos)
        {
            int j;
            MovDer = raiz.Ramas[pos];
            MovIz = raiz.Ramas[pos - 1];
            MovIz.Cuentas++;
            MovIz.Claves[MovIz.Cuentas - 1] = raiz.Claves[pos - 1];
            MovIz.Ramas[MovIz.Cuentas] = MovDer.Ramas[0];
            j = 1;
            while (j != MovDer.Cuentas + 1)
            {
                MovIz.Cuentas++;
                MovIz.Claves[MovIz.Cuentas - 1] = MovDer.Claves[j - 1];
                MovIz.Ramas[MovIz.Cuentas] = MovDer.Ramas[j];
                j++;
            }
            ALV(raiz, pos);
        }

        public void MoverDer(Pagina raiz, int pos)
        {
            int i = raiz.Ramas[pos].Cuentas;
            while (i != 0)
            {
                raiz.Ramas[pos].Claves[i] = raiz.Ramas[pos].Claves[i - 1];
                raiz.Ramas[pos].Ramas[i + 1] = raiz.Ramas[pos].Ramas[i];
                --i;
            }
            raiz.Ramas[pos].Cuentas++;
            raiz.Ramas[pos].Ramas[1] = raiz.Ramas[pos].Ramas[0];
            raiz.Ramas[pos].Claves[0] = raiz.Claves[pos - 1];
            raiz.Claves[pos - 1] = raiz.Ramas[pos - 1].Claves[raiz.Ramas[pos - 1].Cuentas - 1];
            raiz.Ramas[pos].Ramas[0] = raiz.Ramas[pos - 1].Ramas[raiz.Ramas[pos - 1].Cuentas];
            raiz.Ramas[pos - 1].Cuentas--;
        }

        public void MoverIzq(Pagina raiz, int pos)
        {
            int i;
            raiz.Ramas[pos - 1].Cuentas++;
            raiz.Ramas[pos - 1].Claves[raiz.Ramas[pos - 1].Cuentas - 1] = raiz.Claves[pos - 1];
            raiz.Ramas[pos - 1].Ramas[raiz.Ramas[pos - 1].Cuentas] = raiz.Ramas[pos].Ramas[0];
            raiz.Claves[pos - 1] = raiz.Ramas[pos].Claves[0];
            raiz.Ramas[pos].Ramas[0] = raiz.Ramas[pos].Ramas[1];
            raiz.Ramas[pos].Cuentas--;
            i = 1;
            while (i != raiz.Ramas[pos].Cuentas + 1)
            {
                raiz.Ramas[pos].Claves[i - 1] = raiz.Ramas[pos].Claves[i];
                raiz.Ramas[pos].Ramas[i] = raiz.Ramas[pos].Ramas[i + 1];
                i++;
            }
        }

        public void ALV(Pagina raiz, int pos)// O sea quitar XD
        {
            int j = pos + 1;
            while (j != raiz.Cuentas + 1)
            {
                raiz.Claves[j - 2] = raiz.Claves[j - 1];
                raiz.Ramas[j - 1] = raiz.Ramas[j];
                j++;
            }
            raiz.Cuentas--;
        }

        public void Restablecer(Pagina raiz, int pos)
        {
            if (pos > 0)
            {
                if (raiz.Ramas[pos - 1].Cuentas > 2)
                {
                    MoverDer(raiz, pos);
                }
                else
                {
                    Combina(raiz, pos);
                }
            }
            else if (raiz.Ramas[1].Cuentas > 2)
            {
                MoverIzq(raiz, 1);
            }
            else
            {
                Combina(raiz, 1);
            }
        }



        //========================varios===============================
        public void imprimir(Pagina raiz)
        {
            Console.WriteLine(hijos.Dequeue());
            int a = 0;
            Nodo impresion;

            for (int i = 0; i < raiz.Cuentas; i++)
            {
                impresion = raiz.Claves[i];
                if (impresion == null)
                {
                    i = 5;
                    break;
                }
                else
                {
                    Console.WriteLine(num + ". " + raiz.Claves[i].Id);
                    num++;
                }

            }



            if (raiz.Ramas[0] != null)
            {
                Pagina ram;
                for (int i = 0; i < raiz.Cuentas + 1; i++)
                {
                    ram = raiz.Ramas[i];
                    if (ram == null)
                    {
                        break;
                    }
                    hijos.Enqueue("rama no. " + i + " de la pagina que inicia con " + raiz.Claves[0].Id);
                    lista.Enqueue(raiz.Ramas[i]);
                }


            }



            try
            {
                imprimir(lista.Dequeue());
            }
            catch (Exception)
            {
                Console.WriteLine("Se imprimieron todos los nodos");

            }
        }


    }
}











