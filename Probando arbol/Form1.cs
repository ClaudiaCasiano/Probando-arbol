using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probando_arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=====================INICIALIZANDO======================");
            Console.WriteLine();
            Arbol2 arbolito = new Arbol2();


            arbolito.Inserta(arbolito.nuevo(64));
            arbolito.Inserta(arbolito.nuevo(12));
            arbolito.Inserta(arbolito.nuevo(15));
            arbolito.Inserta(arbolito.nuevo(70));
            arbolito.Inserta(arbolito.nuevo(90));
            //arbolito.Inserta(arbolito.nuevo(8));
            //arbolito.Inserta(arbolito.nuevo(10));
            //arbolito.Inserta(arbolito.nuevo(13));
            //arbolito.Inserta(arbolito.nuevo(14));
            //arbolito.Inserta(arbolito.nuevo(30));
            //arbolito.Inserta(arbolito.nuevo(60));
            //arbolito.Inserta(arbolito.nuevo(65));
            //arbolito.Inserta(arbolito.nuevo(66));
            //arbolito.Inserta(arbolito.nuevo(75));
            //arbolito.Inserta(arbolito.nuevo(85));
            //arbolito.Inserta(arbolito.nuevo(103));
            //arbolito.Inserta(arbolito.nuevo(112));




            //arbolito.insertar("05", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("20", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("40", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("10", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("30", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("15", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("25", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("07", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("26", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("18", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("22", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("05", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("42", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("13", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("46", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("27", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("8", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("32", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("37", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("24", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("45", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.insertar("25", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("155vdfa", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("yorxvfke", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("Paovzla", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("Ronazldo", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("Giovacnna", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.insertar("jhony", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            arbolito.hijos.Enqueue("raicita");
            arbolito.imprimir(arbolito.p);
            //58,af,ddf,gg,weewe




            //arbolito.insertar("bb4ddda", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
        }
    }
}
