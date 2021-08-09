# HerenciaEInterfaces

Trabajo Práctico - Lenguajes Electrónicos

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