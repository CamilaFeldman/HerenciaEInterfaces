using System;
using System.Collections.Generic;
using System.Text;

namespace tp_herencia_feldman
{
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        bool compareTo(Object a);

    }
}
