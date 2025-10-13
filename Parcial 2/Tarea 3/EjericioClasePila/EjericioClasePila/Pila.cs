using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioClasePila
{
    // CLASE PILA 
    public class Pila<Tipo>
    {

        private Elemento<Tipo> ElementoArriba;
        private int _intTamaño;

        public Pila()
        {
            ElementoArriba = null;
            _intTamaño = 0;
        }
        public void Agregar(Tipo ObjAgregar)
        {
            Elemento<Tipo> NuevoElemento = new Elemento<Tipo>(ObjAgregar);
            NuevoElemento.Siguiente = ElementoArriba;
            ElementoArriba = NuevoElemento;
            _intTamaño++;
        }
        public Tipo Eliminar()
        {
            if (_intTamaño == 0)
            {
                throw new Exception("La pila está vacía.");
            }
            Tipo ObjQuitar = ElementoArriba.Valor;
            ElementoArriba = ElementoArriba.Siguiente;
            _intTamaño--;
            return ObjQuitar;
        }
        public int Tamaño
        {
            get { return _intTamaño; }
        }

        //CLASE ELEMENTO = NODO

        public class Elemento<Tipo>
        {

            private Tipo _valor;
            private Elemento<Tipo> _siguiente;

            public Elemento(Tipo valor)
            {
                Valor = valor;
                _siguiente = null;
            }

            public Tipo Valor
            {
                get { return _valor; }
                set { _valor = value; }
            }
            public Elemento<Tipo> Siguiente
            {
                get { return _siguiente; }
                set { _siguiente = value; }
            }
        }

    }
}
