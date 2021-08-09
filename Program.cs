using System;

namespace tp_herencia_feldman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Serie[] listaseries = new Serie[5];
            Videojuego[] listavideo = new Videojuego[5];
            int cantv=0;
            int cants = 0;
            listaseries[0] = new Serie("La casa de papel","Alex Pina","Crimen",3);
            listaseries[1] = new Serie("Juego de tronos", "George R.R. Martin", "Fantasía", 8);
            listaseries[2] = new Serie("Stranger Things", "Hermanos Duffer", "Ciencia ficción", 3);
            listaseries[3] = new Serie("Black Mirror", "Charlie Brooker", "Ciencia ficción", 5);
            listaseries[4] = new Serie("Los Simpsons", "Matt Groening", "Comedia", 31);

            listavideo[0] = new Videojuego("The Witcher",40,"Drama, Fantasía","CD Projekt RED");
            listavideo[1] = new Videojuego("Detroit become human",12,"Ciencia ficción","Quantic Dream");
            listavideo[2] = new Videojuego("Life is Strange",12,"Aventura", "Dontnod Entertainment, Feral Interactive");
            listavideo[3] = new Videojuego("Skyrim",100,"Acción", "Bethesda Game Studios");
            listavideo[4] = new Videojuego("Undertale",33,"Puzle","Toby Fox");

            for (int i = 0; i < listaseries.Length; i++)
            {
                
                if (i % 2 > 0) 
                { 
                    listaseries[i].entregar(); 
                    listavideo[i].entregar();
                }
            }

            Console.WriteLine("\n******Lista de Series entregadas:******");
            for (int i = 0; i < listaseries.Length; i++)
            {
                
                if (listaseries[i].isEntregado() == true)
                {
                    cants++;
                    Console.WriteLine("\n{0}\n",listaseries[i]);
                }
                
            }
            Console.WriteLine("******Fin lista series******\n");

            Console.WriteLine("\n******Lista de Videojuegos entregados:******");
            for (int i = 0; i < listaseries.Length; i++)
            {

                if (listavideo[i].isEntregado() == true)
                {
                    cantv++;
                    Console.WriteLine("\n{0}\n", listavideo[i]);
                }

            }
            Console.WriteLine("******Fin lista videojuegos******\n");

            Console.WriteLine(" Cantidad de Series y Videojuegos entregados: {0}\n " +
                "Cantidad de Series entregadas: {1} \n " +
                "Cantidad de Videojuegos entregados: {2}\n\n", cantv+cants,cants,cantv);
            Serie serieMayor = listaseries[0];
            Videojuego juegoMayor = listavideo[0];
            for (int i = 1; i < listaseries.Length; i++)
            {
                if (listaseries[i].compareTo(serieMayor))
                {
                    serieMayor = listaseries[i];
                }
                if (listavideo[i].compareTo(juegoMayor))
                {
                    juegoMayor = listavideo[i];
                }
            }

            Console.WriteLine("Videojuego más largo\n{0}\n", juegoMayor);
            Console.WriteLine("Serie más larga\n{0}\n", serieMayor);

        }
    }
}
/*
 Crear una clase llamada Serie con las siguientes características: 
 ▪ Sus atributos son título, número de temporadas, entregado, género y creador. 
 ▪ Por defecto, el número de temporadas es de 3 temporadas y entregado false. 
 El resto de atributos serán valores por defecto según el tipo del atributo. 
 ▪ Los constructores que se implementarán serán: 
 ➢ Un constructor por defecto.
 ➢ Un constructor con el título y creador. El resto por defecto. 
 ➢ Un constructor con todos los atributos, excepto de entregado. 
 ▪ Los métodos que se deberán desarrollar serán: 
 ➢ Métodos get de todos los atributos, excepto de entregado. 
 ➢ Métodos set de todos los atributos, excepto de entregado. 
 ➢ Sobrescribe los métodos toString. 

 Crear una clase Videojuego con las siguientes características:
 ▪ Sus atributos son título, horas estimadas, entregado, género y compañia. 
 ▪ Por defecto, las horas estimadas serán de 10 horas y entregado false. 
 El resto de atributos serán valores por defecto según el tipo del atributo. 
 ▪ Los constructores que se implementarán serán:
 ➢ Un constructor por defecto. 
 ➢ Un constructor con el título y horas estimadas. El resto por defecto. 
 ➢ Un constructor con todos los atributos, excepto de entregado. 
 ▪ Los métodos que se implementara serán: 
 ➢ Métodos get de todos los atributos, excepto de entregado. 
 ➢ Métodos set de todos los atributos, excepto de entregado. 
 ➢ Sobrescribe los métodos toString.

 Como vemos, en principio, las clases anteriores no son padre-hija, 
 pero si tienen cosas en común,
 por eso vamos a hacer una interfaz llamada Entregable con los siguientes métodos: 
 ▪ entregar(): cambia el atributo prestado a true.
 ▪ devolver(): cambia el atributo prestado a false. 
 ▪ isEntregado(): devuelve el estado del atributo prestado.
 ▪ Método compareTo (Object a), compara las horas estimadas en los videojuegos 
 y en las 
 series el número de temporadas. Como parámetro que tenga un objeto. 
 
    Implementar los anteriores métodos en las clases Videojuego y Serie.

 Crear un programa que realice lo siguiente: 
 ▪ Crear dos arrays, uno de Series y otro de Videojuegos,
 de 5 posiciones cada uno. 
 ▪ Crear un objeto en cada posición del array, con cualquier valor, 
 se pueden usar distintos constructores.
 ▪ Entregar algunos Videojuegos y Series con el método entregar(). 
 ▪ Contar cuantos Series y Videojuegos hay entregados. Al contarlos, mostrarlos. 
 ▪ Por último, indicar el Videojuego que tiene más horas estimadas y 
 la serie con más temporadas.
 Mostrar en pantalla con toda su información (usar el método toString()).
 */
