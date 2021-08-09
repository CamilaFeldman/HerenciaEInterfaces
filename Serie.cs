using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace tp_herencia_feldman
{
    class Serie : Entregable
    {
        private string titulo;
        private int numerodetemp = 3;
        private bool entregado = false;
        private string genero;
        private string creador;
        public Serie() { }
        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }
        public Serie(string titulo, string creador, string genero, int numerodetemp)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            this.numerodetemp = numerodetemp;
        }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Creador { get { return creador; } set { creador = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public int NumeroDeTemp { get { return numerodetemp; } set { numerodetemp = value; } }
        public override string ToString()
        {
            return string.Format("Titulo: {0} " +
                "\nCreador: {1}" +
                "\nGenero: {2}" +
                "\nNumero de temporadas: {3}",
                Titulo, Creador, Genero, NumeroDeTemp);
        }
        public void entregar() { entregado = true; }
        public void devolver() { entregado = false; }
        public bool isEntregado() { return entregado; }
        public bool compareTo(Object a) 
        {
            Serie b = (Serie)a; //convertir "a" a un objeto del tipo serie
            bool retorno = false;
            if (this.numerodetemp > b.numerodetemp) { retorno = true; }
            return retorno;
        /*Método compareTo (Object a), compara las horas estimadas en los videojuegos y en las 
        series el número de temporadas. Como parámetro que tenga un objeto.
        10 5 20 30 4*/
        }
    }
}
//Serie a;
/*
 * Serie b;
 * c;
 * c=b.compareTo(a);
 * 
 */
