//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Probando_arbol
//{
//    /*
//     Que se hace ya?
//    1. se incerta el primero
//    2. se incerta a la derecha normalmente con arbol no lleno
//    3. 
//      */




//    public class Arbol
//    {
//        Queue<Pagina> lista = new Queue<Pagina>();
//        Queue<String> hijos = new Queue<String>();
//        Pagina raiz = new Pagina();
//        //Pagina actual = new Pagina();
//        //int pos = 0;
//        int cont = 1;

//        public void insertar(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
//        {
//            int pos = 0;
//            Nodo nuevo = new Nodo(id, activo, usuario, empresa, depto, fecha, hora, tipo);
//            Pagina actual = raiz;

//            Console.WriteLine();
//            //Console.WriteLine("se va a incertar el nodo con id " + nuevo.Id);
//            if (raiz.estaVacia())
//            {
//                raiz.insert(nuevo, 0);
//                Console.WriteLine("se creo el primer nodo con " + raiz.Claves[0].Id);

//            }
//            else
//            {
//                actual.Claves[pos].reiniciar();//toma 0 como primer elemento del id
//                Console.WriteLine("La raiz No esta vacia");

//                if (!actual.Estalleno()) //si no esta lleno :33
//                {
//                    bool exito = false; //bool que indica si seguri con el ciclo
//                    while (!exito)//mientras no haya exito
//                    {
//                        if (actual.Claves[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
//                        {
//                            if (actual.Claves[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
//                            {
//                                InsertarEnHijo(actual.Claves[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
//                                break;
//                            }
//                            else
//                            {
//                                insertarDerechaNormal(actual, nuevo, pos);//inserta la raiz actual, el nodo nuevo y la posicion
//                                break;
//                            }
//                        }
//                        else if (nuevo.num() < actual.Claves[pos].num())//si es menor
//                        {
//                            Console.WriteLine("el primero es menor " + nuevo.num() + " y " + actual.Claves[pos].num());
//                            if (actual.Claves[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
//                            {
//                                InsertarEnHijo(actual.Claves[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
//                                exito = true;
//                                break;
//                            }
//                            else
//                            {
//                                insertarIzquierdoNormal(actual, nuevo, pos);// se inserta normal y verifica si se llena la pagina
//                                exito = true;
//                                break;
//                            }
//                        }
//                        else if (nuevo.num() > actual.Claves[pos].num()) //si es mayor solo se mueve una posicion
//                        {
//                            Console.WriteLine("el primero es mayor " + nuevo.num() + " y " + actual.Claves[pos].num());

//                            if (actual.Claves[pos] != null)
//                            {
//                                actual.Claves[pos].reiniciar();
//                            }
//                            pos++;
//                        }
//                        else if (nuevo.num() == actual.Claves[pos].num())
//                        {
//                            if (nuevo.Id == actual.Claves[pos].Id)
//                            {
//                                Console.WriteLine("Esta transaccion ya existe");
//                                break;

//                            }
//                            else
//                            {
//                                nuevo.nextletra();
//                                actual.Claves[pos].nextletra();
//                            }
//                        }
//                    }

//                }

//            }


//        }

//        private void insertarIzquierdoNormal(Pagina actual, Nodo nuevo, int posi)
//        {
//            Nodo aux1 = actual.Claves[posi];
//            Nodo aux = actual.Claves[posi];
//            actual.insert(nuevo, posi);

//            for (int i = posi + 1; i < 5; i++)
//            {
//                if (aux1 != null)
//                {
//                    aux1 = actual.Claves[i];
//                    actual.insert(aux, i);
//                    aux = aux1;

//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.WriteLine("SE INSERTO " + actual.Claves[posi].Id + " A LA IZQUIERDA DE " + actual.Claves[posi + 1].Id);

//            if (actual.Estalleno())//significa que esta lleno
//            {
//                Console.WriteLine("===el ultimo nodo de la pagina es " + actual.Claves[4].Id);
//                moverNodos(actual);
//            }



//        }

//        private void insertarDerechaNormal(Pagina actu, Nodo nuevo, int posi) // solo inserta a la derecha, por lo tanto actual.Claves[pos] siempre sera un valor nulo
//        {
//            actu.insert(nuevo, posi);
//            Console.WriteLine("SE INCERTO " + actu.Claves[posi].Id + " A LA DERECHA DE " + actu.Claves[posi - 1].Id);
//            if (actu.Estalleno())
//            {  //si se llena la pagina
//                Console.WriteLine("el ultimo nodo de la pagina es " + actu.Claves[4].Id);
//                moverNodos(actu);
//            }

//        }



//        private void InsertarEnHijo(Pagina pagina, Nodo nuevo)
//        {
//            int pos = 0;
//            Pagina actu = pagina;
//            bool exito = false; //bool que indica si seguri con el ciclo
//            while (!exito)//mientras no haya exito
//            {
//                if (actu.Claves[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
//                {
//                    if (actu.Claves[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
//                    {
//                        //pos = 0;                //la posicion es cero
//                        InsertarEnHijo(actu.Claves[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
//                        exito = true;
//                    }
//                    else
//                    {
//                        insertarDerechaNormal(actu, nuevo, pos);//este va a insertar el nodo normal y verifica si la pagina esta llena
//                        exito = true;
//                    }
//                }

//                else if (nuevo.num() < actu.Claves[pos].num())//si es menor
//                {
//                    actu.Claves[pos].reiniciar();
//                    if (actu.Claves[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
//                    {
//                        InsertarEnHijo(actu.Claves[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
//                        exito = true;
//                    }
//                    else
//                    {
//                        insertarIzquierdoNormal(actu, nuevo, pos);// se inserta normal y verifica si se llena la pagina
//                        exito = true;
//                    }
//                }
//                else if (nuevo.num() > actu.Claves[pos].num()) //si es mayor solo se mueve una posicion
//                {

//                    if (actu.Claves[pos] != null)
//                    {
//                        actu.Claves[pos].reiniciar();
//                    }
//                    pos++;
//                }
//                else if (nuevo.num() == actu.Claves[pos].num())
//                {
//                    if (nuevo.Id == actu.Claves[pos].Id)
//                    {
//                        Console.WriteLine("Esta transaccion ya existe");
//                        break;

//                    }
//                    else
//                    {
//                        nuevo.nextletra();
//                        actu.Claves[pos].nextletra();
//                    }
//                }
//            }

//        }


//        private void moverNodos(Pagina pagina)//metodo solo se llama si el actual ya esta lleno [10|30|50|82|44]
//        {
//            Pagina actu = pagina;
//            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!el primer nodo de esta pagina es" + actu.Claves[0].Id);
//            Nodo aux = actu.Claves[2];
//            Pagina nuevoIzq = new Pagina();
//            Pagina nuevoDer = new Pagina();
//            nuevoIzq.Claves[0] = actu.Claves[0];
//            if (actu.Padre == null)
//            {
//                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxno NO TIENE UN PINSHI PADRE D:<");
//            }
//            nuevoIzq.Claves[1] = actu.Claves[1];
//            nuevoDer.Claves[0] = actu.Claves[3];
//            nuevoDer.Claves[1] = actu.Claves[4];

//            if (nuevoDer.Claves[0].tieneHijoIzquierdo())
//            {
//                nuevoDer.Claves[0].HijoIzquierdo.Padre = nuevoDer;
//                nuevoDer.Claves[1].HijoIzquierdo.Padre = nuevoDer;
//                nuevoDer.Claves[1].HijoDerecho.Padre = nuevoDer;

//                nuevoIzq.Claves[0].HijoIzquierdo.Padre = nuevoIzq;
//                nuevoIzq.Claves[1].HijoIzquierdo.Padre = nuevoIzq;
//                //nuevoIzq.Claves[1].HijoDerecho.Padre = nuevoIzq;
//            }
//            //aux.HijoDerecho = nuevoDer;

//            //aux.HijoIzquierdo = nuevoIzq;

//            if (actu.Padre == null)
//            {

//                if (aux.tieneHijoIzquierdo())
//                {
//                    aux.HijoIzquierdo.Padre = nuevoIzq;
//                    nuevoIzq.Claves[1].HijoDerecho = aux.HijoIzquierdo;
//                    //nuevoDer.Claves[0].HijoIzquierdo = pagina.Claves[3].HijoIzquierdo;



//                }


//                Pagina nuevaraiz = new Pagina();
//                nuevaraiz.insert(aux, 0);
//                nuevoIzq.Padre = nuevaraiz;
//                aux.HijoIzquierdo = nuevoIzq;
//                nuevoDer.Padre = nuevaraiz;
//                aux.HijoDerecho = nuevoDer;


//                raiz = nuevaraiz;
//                Console.WriteLine("actualmente esta pagina no tiene padre");
//                Console.WriteLine("se creo una nueva raiz con " + raiz.Claves[0].Id);
//            }

//            else
//            {
//                Pagina padre = actu.Padre;
//                bool exito = false;
//                int posb = 0;
//                while (!exito)//mientras no haya exito

//                {
//                    if (padre.Claves[posb] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
//                    {
//                        padre.Claves[posb - 1].HijoDerecho = null;
//                        nuevoIzq.Padre = padre;
//                        aux.HijoIzquierdo = nuevoIzq;
//                        nuevoDer.Padre = padre;
//                        aux.HijoDerecho = nuevoDer;
//                        insertarDerechaNormal(padre, aux, posb);//este va a insertar el nodo normal y verifica si la pagina esta llena

//                        //
//                        break;

//                    }

//                    else if (aux.num() < padre.Claves[posb].num())//si es menor
//                    {
//                        nuevoDer.Padre = padre;
//                        padre.Claves[posb].HijoIzquierdo = nuevoDer;
//                        nuevoIzq.Padre = padre;
//                        aux.HijoIzquierdo = nuevoIzq;
//                        insertarIzquierdoNormal(padre, aux, posb);
//                        break;

//                    }
//                    else if (aux.num() > padre.Claves[posb].num()) //si es mayor solo se mueve una posicion
//                    {
//                        posb++;
//                    }
//                    else if (aux.num() == padre.Claves[posb].num())
//                    {
//                        if (aux.Id == padre.Claves[posb].Id)
//                        {
//                            Console.WriteLine("Esta transaccion ya existe");
//                            break;

//                        }
//                        else
//                        {
//                            aux.nextletra();
//                            padre.Claves[posb].nextletra();
//                        }
//                    }
//                }

//            }


//        }


//        public void imprimir(Pagina raiz)
//        {

//            Nodo impresion;


//            try
//            {
//                Console.WriteLine();
//                Console.WriteLine(hijos.Dequeue());
//            }
//            catch (Exception)
//            { }

//            if (raiz.Padre == null)
//            {
//                Console.Write(" esta raiz no tiene padre ");
//            }
//            else
//            {
//                Console.WriteLine(" tiene un padre xD desde " + raiz.Padre.Claves[0].Id);
//            }


//            for (int i = 0; i < 5; i++)
//            {
//                impresion = raiz.Claves[i];
//                if (impresion == null)
//                {
//                    break;
//                }
//                Console.WriteLine(cont + ". " + impresion.Id);
//                cont++;
//                if (impresion.HijoIzquierdo != null)
//                {
//                    hijos.Enqueue("hijo izquierdo de " + impresion.Id);
//                    lista.Enqueue(impresion.HijoIzquierdo);
//                }
//                if (impresion.HijoDerecho != null)
//                {
//                    hijos.Enqueue("hijo derecho de " + impresion.Id);
//                    lista.Enqueue(impresion.HijoDerecho);
//                }
//            }

//            try
//            {
//                imprimir(lista.Dequeue());
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Se imprimieron todos los nodos");

//            }

//            //foreach (Pagina item in lista)
//            //{
//            //    Console.WriteLine("IMPRIME UN HIJO");

//            //    //for (int i = 0; i < 5; i++)
//            //    //{



//            //    //    //impresion = item.Claves[i];
//            //    //    //if (impresion == null)
//            //    //    //{
//            //    //    //    break;
//            //    //    //}
//            //    //    //Console.Write(impresion.Id + " - ");

//            //    //}

//            //}


//        }

//        public Pagina Raiz
//        {
//            get { return raiz; }
//            set { raiz = value; }

//        }

//    }
//}