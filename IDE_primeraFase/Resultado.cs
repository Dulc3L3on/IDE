using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_primeraFase { 
//en esta clase se encuentra el valor del conjunto de
//caracteres estudiado, junto con su respectivo tipo,
//de tal manera que la obtneción de la información para
//su posterior estudio sea más sencilla

    class Resultado //ESTA CLASE ES ÚTIL SIN IMPORTAR EL TIPO DE DATO y el tipo de analizador que requiera almacenar sus hallazgos, puesto que aunque sea un método su tipo sería método, tendría fila y col... solo que en este caso tendría que alamacenar algo más como es el caso de los paráms y el tipo de retorno
    {
        String elementoEstudiado;
        String clasificacion;
        int fila, columnaInicio, columnaFin;

        public Resultado() { 
        }

        public Resultado(String elemento, String tipo, int numeroFila, int numeroColumnaInicio, int numeroColumnaFin) {
            elementoEstudiado = elemento;
            clasificacion = tipo;
            fila = numeroFila;
            columnaInicio = numeroColumnaInicio;
            columnaFin = numeroColumnaFin;
        }

        public String darElemento() {
            return elementoEstudiado;    
        }

        public String darClasificacion() {
            return clasificacion;
        }

        public int darFilaUbicacion() {
            return fila;
        }

        public int darColumnaInicio() {
            return columnaInicio;
        }

        public int darColumnaFin() {
            return columnaFin;
        }
    }

    //la razón por la cual puede autocompletar un IDE
    //es por la tabla de datos, en donde almacena las
    //referencias, de un obj primitivo o no primitivo xD
}
