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

namespace IDE_primeraFase
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaEnlazada<String> listaErroresMostrar = new ListaEnlazada<String>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListadoErrores(ListaEnlazada<String> listadoErrores) {
            listaErroresMostrar = listadoErrores;
        }

        private void areaDesarrollo_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        public void mostrarErrores() {
            Nodo<String> nodoAuxiliar = listaErroresMostrar.obtnerPrimerNodo();

            for (int errorActual =0; errorActual< listaErroresMostrar.darTamanio();errorActual++) {
                txt_areaLog.Text += nodoAuxiliar.contenido+"\n";

                nodoAuxiliar = nodoAuxiliar.nodoSiguiente;
            }            
        }
    }
}
