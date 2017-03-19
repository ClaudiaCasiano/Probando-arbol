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
        int num = 1;


        public Pagina principal = new Pagina();
        Pagina Xder = new Pagina();
        Pagina Xizq = new Pagina();
        Nodo X;
        Pagina Xr;
        String salida = "", imps = "";
        bool EmpA = false, Esta = false;

        //crea un nuevo nodo con los objetos que mande
        public Nodo nuevo(int id/*, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo*/)
        {
            Nodo nuev = new Nodo();
            nuev.nump = id;
            return nuev;
        }

        // insertar para un nuevo nodo creado
        public void Inserta(Nodo nuevo)
        {
            Console.WriteLine("");
            Console.WriteLine("se incertara un nuevo nodo");
            Insertaa(nuevo, principal);
        }
        //auxiliar de inserta nodo

        public void Insertaa(Nodo clave, Pagina raiz)//insertara el nuevo nodo en la raiz que manden como parametro
        {
            Empujar(clave, raiz);
            if (EmpA)
            {
                principal = new Pagina();
                principal.Cuentas = 1;
                principal.Claves[0] = X;
                principal.Ramas[0] = raiz;
                principal.Ramas[1] = Xr;
            }
            Console.WriteLine("Insercion Completa");
        }
        //Empuja los elementos del arbol



        public bool Vacio(Pagina raiz)
        {
            return (raiz == null || raiz.Cuentas == 0);
        }


        public int BuscarNodo(Nodo clave, Pagina raiz)
        {
            int j = 0;
            if (clave.nump < raiz.Claves[0].nump)//es porque no hay que correrlo, es un |2| y la raiz es por ejemplo  |8|25|33
            {
                Esta = false;
                j = 0;
            }
            else
            {
                j = raiz.Cuentas;
                while (clave.nump < raiz.Claves[j - 1].nump && j > 1)
                {
                    --j;
                }
                Esta = (clave.nump == raiz.Claves[j - 1].nump);
            }
            return j;
        }


        public void Empujar(Nodo clave, Pagina raiz)
        {
            
            int k = 0;
            Esta = false;
            if (Vacio(raiz))
            {

                EmpA = true;
                X = clave;
                Xr = null;
            }
            else
            {
                k = BuscarNodo(clave, raiz);
                if (Esta)
                {
                    Console.WriteLine("No hay claves repetidas");
                    EmpA = false;
                }
                else
                {
                    Empujar(clave, raiz.Ramas[k]);
                    if (EmpA)
                    {
                        if (raiz.Cuentas < 4)
                        {
                            EmpA = false;
                            MeterHoja(X, raiz, k);
                        }
                        else
                        {
                            EmpA = true;
                            DividirN(X, raiz, k);
                        }
                    }
                }
            }
        }
        //Meter hoja

        public void MeterHoja(Nodo clave, Pagina raiz, int k)
        {
            int i = raiz.Cuentas;
            while (i != k)
            {
                raiz.Claves[i] = raiz.Claves[i - 1];
                raiz.Ramas[i + 1] = raiz.Ramas[i];
                --i;
            }
            raiz.Claves[k] = clave;
            raiz.Ramas[k + 1] = Xr;
            raiz.Cuentas = ++raiz.Cuentas;
        }
        //Dividir nodo

        public void DividirN(Nodo Clave, Pagina Raiz, int k)
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
                MeterHoja(Clave, Raiz, k);
            }
            else
            {
                MeterHoja(Clave, Mder, (k - pMedia));
            }
            X = Raiz.Claves[Raiz.Cuentas - 1];
            Mder.Ramas[0] = Raiz.Ramas[Raiz.Cuentas];
            Raiz.Cuentas = --Raiz.Cuentas;
            Xr = Mder;
        }








        public void imprimir(Pagina raiz)
        {
            Console.WriteLine(hijos.Dequeue());
            int a = 0;
            Nodo impresion;

            for (int i = 0; i < 5; i++)
            {
                impresion = raiz.Claves[i];
                if (impresion == null)
                {
                    break;
                }
                Console.WriteLine(num + ". " + raiz.Claves[i].nump);
                num++;
            }



            if (raiz.Ramas[0] != null)
            {
                Pagina ram;
                for (int i = 0; i < 5; i++)
                {
                    ram = raiz.Ramas[i];
                    if (ram == null)
                    {
                        break;
                    }
                    hijos.Enqueue("rama no." + i + "de la pagina que inicia con " + raiz.Claves[0].nump);
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





           public void Eliminar(Nodo clave) {
                if (Vacio(principal))
                {
                    Console.WriteLine( "No hay elementos");
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
                Console.WriteLine("Eliminacion completa");
            }
        }
        //Elimina el registro

        public void EliminarRegistro(Pagina raiz, Nodo c)
        {
            int pos = 0;
            Nodo sucesor;
            if (Vacio(raiz))
            {
                Esta = false;
            }
            else
            {
                pos = BuscarNodo(c, raiz);
                if (Esta)
                {
                    if (Vacio(raiz.Ramas[pos - 1]))
                    {
                        Quitar(raiz, pos);
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
        //Busca el sucesor

        public void Sucesor(Pagina raiz, int k)
        {
            Pagina q = raiz.Ramas[k];
            while (!Vacio(q.Ramas[0]))
            {
                q = q.Ramas[0];
            }
            raiz.Claves[k - 1] = q.Claves[0];
        }
        //Combina para formar un nodo

        public void Combina(Pagina raiz, int pos)
        {
            int j;
            Xder = raiz.Ramas[pos];
            Xizq = raiz.Ramas[pos - 1];
            Xizq.Cuentas++;
            Xizq.Claves[Xizq.Cuentas - 1] = raiz.Claves[pos - 1];
            Xizq.Ramas[Xizq.Cuentas] = Xder.Ramas[0];
            j = 1;
            while (j != Xder.Cuentas + 1)
            {
                Xizq.Cuentas++;
                Xizq.Claves[Xizq.Cuentas - 1] = Xder.Claves[j - 1];
                Xizq.Ramas[Xizq.Cuentas] = Xder.Ramas[j];
                j++;
            }
            Quitar(raiz, pos);
        }
        //Mueve a la derecha

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
        //Mover a la izquierda

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
        //Quita el elemento

        public void Quitar(Pagina raiz, int pos)
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
        //Restablece el nodo

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


    }
    }











