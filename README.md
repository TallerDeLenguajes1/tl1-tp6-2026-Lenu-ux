#Ejercicio 4


*¿String es una tipo por valor o un tipo por referencia? *

El tipo string en C# es un tipo de referencia, es decir que no guarda el texto directamente en la variable, sino en un puntero que esta en el Heap donde almacena los caracateres.


*¿Qué secuencias de escape tiene el tipo string?*

Las secuencias de escape son combinaciones de caracteres que arrancan con una barra invertida y representan caracteres especiales que no pueden escribir directamente en el texto.

*¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?*

El ' @ ' ignora las secuencias de escape , respetando los saltos de linea y barras invertidas.

El '$'  fusiona variables o expresiones directamente dentro del texto sin tener que usar el signo "+" para concatenar