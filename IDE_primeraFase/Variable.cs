using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace IDE_primeraFase
{
    class Variable
    {//esta clase contendrá todo lo que se requiere saber de una variable...
     //es decir:
     //> tipo, > valor, >espacioMemo
     //recuerda que para este caso es necesario no obviar mayus y minus...

        String identificacion;
        String tipo;
        String valor;//creo...
        String espacioMemoria;

        public Variable(String nombre, String tipo, String valor, String espacionEnMemoria) {
            identificacion = nombre;
            this.tipo = tipo;
            this.valor = valor;
            espacioMemoria = espacionEnMemoria;
        }

        public String darIdentificacion() {
            return identificacion;
        }

        public String darTipo() {
            return tipo;
        }

        public String darValorAlmacendo() {
            return valor;
        }

        public String darUbicacionMemoria() {
            return espacioMemoria;
        }

    }
}
