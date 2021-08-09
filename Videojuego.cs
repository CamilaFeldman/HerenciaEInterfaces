using System;
using System.Collections.Generic;
using System.Text;

namespace tp_herencia_feldman
{
    class Videojuego : Entregable
    {
        private string titulo;
        private int horasestimadas = 10;
        private bool entregado = false;
        private string genero;
        private string compania;
        public Videojuego() { }
        public Videojuego(string titulo, int horas)
        {
            this.titulo = titulo;
            horasestimadas = horas;
        }
        public Videojuego(string titulo, int horas, string genero, string compania)
        {
            this.titulo = titulo;
            horasestimadas = horas;
            this.genero = genero;
            this.compania = compania;
        }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Compania { get { return compania; } set { compania = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public int HorasEstimadas { get { return horasestimadas; } set { horasestimadas = value; } }
        public override string ToString()
        {
            return string.Format("Titulo: {0} " +
                "\nCompania: {1} " +
                "\nGenero: {2} " +
                "\nHoras Estimadas: {3}", 
                Titulo, Compania, Genero, HorasEstimadas);
        }
        public void entregar() { entregado = true; }
        public void devolver() { entregado = false; }
        public bool isEntregado() { return entregado; }
        public bool compareTo(Object a)
        {
            Videojuego b = (Videojuego)a; //convertir "a" a un objeto del tipo serie
            bool retorno = false;
            if (this.horasestimadas > b.horasestimadas) { retorno = true; }
            return retorno;
            /*Método compareTo (Object a), compara las horas estimadas en los videojuegos y en las 
            series el número de temporadas. Como parámetro que tenga un objeto.
            10 5 20 30 4*/
        }
    }
    
}
