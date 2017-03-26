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



            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora" ));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora" ));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora" ));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora" ));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));
            arbolito.InsertarNuevo(arbolito.nuevo("holi", "usuario1", "empresa1", "depto1", "fechahoy", "hora"));


            arbolito.print();
           // arbolito.Relaciones();
            //arbolito.archivso("digraph structs {node[shape = record]struct1[label = \"<f0> left|<f1> mid\\ dle|<f2> right\"];struct2[label = \"{<f0> one|<f1> two}\" shape = Mrecord]; struct3[label = \\hello\nworld |{ b |{c|<here> d|e}| f}| g | h\"];struct1: f1->struct2:f0; struct1: f0->struct3:f1; }");

        }
    }
}
