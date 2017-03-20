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


            //if ("xguete".CompareTo("banana")<0)
            //{
            //    Console.Write("es menor");
            //}
            //else if("auete".CompareTo("banana") > 0)
            //{
            //    Console.Write("es mayor");
            //}else if("banana".CompareTo("banana") == 0)
            //{
            //    Console.Write("es igual");
            //}

            arbolito.InsertarNuevo(arbolito.nuevo("02"));//
            arbolito.InsertarNuevo(arbolito.nuevo("10"));//
            arbolito.InsertarNuevo(arbolito.nuevo("04"));//
            arbolito.InsertarNuevo(arbolito.nuevo("28"));//
            arbolito.InsertarNuevo(arbolito.nuevo("32"));//

            arbolito.InsertarNuevo(arbolito.nuevo("24"));//
            arbolito.InsertarNuevo(arbolito.nuevo("31"));//
            arbolito.InsertarNuevo(arbolito.nuevo("17"));//
            arbolito.InsertarNuevo(arbolito.nuevo("75"));//
            arbolito.InsertarNuevo(arbolito.nuevo("16"));//

            arbolito.InsertarNuevo(arbolito.nuevo("90"));//
            arbolito.InsertarNuevo(arbolito.nuevo("22"));//
            arbolito.InsertarNuevo(arbolito.nuevo("67"));//
            arbolito.InsertarNuevo(arbolito.nuevo("70"));//
            
            arbolito.InsertarNuevo(arbolito.nuevo("11"));
            arbolito.InsertarNuevo(arbolito.nuevo("19"));
            arbolito.InsertarNuevo(arbolito.nuevo("69"));
            arbolito.InsertarNuevo(arbolito.nuevo("14"));
            //arbolito.InsertarNuevo(arbolito.nuevo("9"));


            //arbolito.InsertarNuevo(arbolito.nuevo("60"));
            //arbolito.InsertarNuevo(arbolito.nuevo("65"));
            //arbolito.InsertarNuevo(arbolito.nuevo("66"));
            //arbolito.InsertarNuevo(arbolito.nuevo("75"));
            //arbolito.InsertarNuevo(arbolito.nuevo("85"));
            //arbolito.InsertarNuevo(arbolito.nuevo("103"));
            //arbolito.InsertarNuevo(arbolito.nuevo("112"));
            //arbolito.InsertarNuevo(arbolito.nuevo("80"));
            arbolito.print();
            //arbolito.Eliminar(arbolito.nuevo("15"));
            //arbolito.Eliminar(arbolito.nuevo("70"));


            //arbolito.InsertarNuevor("05", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("20", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("40", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("10", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("30", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("15", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("25", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("07", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("26", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("18", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("22", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("05", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("42", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("13", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("46", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("27", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("8", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("32", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("37", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("24", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("45", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            //arbolito.InsertarNuevor("25", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("155vdfa", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("yorxvfke", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("Paovzla", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("Ronazldo", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("Giovacnna", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
            ////arbolito.InsertarNuevor("jhony", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
           
            arbolito.Eliminar(arbolito.nuevo("24"));
            arbolito.Eliminar(arbolito.nuevo("28"));
            //arbolito.Eliminar(arbolito.nuevo("4"));


            arbolito.print();
            //58,af,ddf,gg,weewe




            //arbolito.InsertarNuevor("bb4ddda", "holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora", "nada");
        }
    }
}
