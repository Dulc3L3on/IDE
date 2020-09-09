using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IDE_primeraFase.Herramientas;

namespace IDE_primeraFase
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Herramienta herramienta = new Herramienta();
        ListaEnlazada<String> listaErroresMostrar = new ListaEnlazada<String>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void establecerListadoErrores(ListaEnlazada<String> listadoErrores) {
            listaErroresMostrar = listadoErrores;
        }

        private void areaDesarrollo_TextChanged(object sender, TextChangedEventArgs e)
        {
            int numeroLinea = areaDesarrollo.Lines


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mostrarErrores() {
            Nodo<String> nodoAuxiliar = listaErroresMostrar.obtnerPrimerNodo();

            for (int errorActual =0; errorActual< listaErroresMostrar.darTamanio();errorActual++) {
                txt_areaLog.Text += nodoAuxiliar.contenido+"\n";

                nodoAuxiliar = nodoAuxiliar.nodoSiguiente;
            }            
        }

        private void mostrarLineaColumna() {
            //se obtiene la linea
            int indice = Convert.ToInt32(areaDesarrollo.Selection.Start);
            int linea = areaDesarrollo.L;//basado en el índice en el que se encuentra, puede determinarse la linea

            //Obtiene la columna
            int primerCaracter = areaDesarrollo.GetFirstCharIndexFromLine(indice);
            int columna = indice - primerCaracter;
            String ubicacion = "Linea: "+ Convert.ToString(linea)+ " Caracter: "+Convert.ToString(columna);

            informativo;
        }
              
        private void areaDesarrollo_keyTyped(object sender, TextCompositionEventArgs e)
        {
            char cierre = herramienta.cerrarAperturado();
            String cierreComentario = herramienta.cerrarComentario();

        

           

            if (cierre != null)
            {

            }
            if (cierreComentario != null)
            {

            }
        }
    }
}
