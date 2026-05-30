#Ejercicio 4


*¿String es una tipo por valor o un tipo por referencia? *

El tipo string en C# es un tipo de referencia, es decir que no guarda el texto directamente en la variable, sino en un puntero que esta en el Heap donde almacena los caracateres.


*¿Qué secuencias de escape tiene el tipo string?*

Las secuencias de escape son combinaciones de caracteres que arrancan con una barra invertida y representan caracteres especiales que no pueden escribir directamente en el texto.

*¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?*

El ' @ ' ignora las secuencias de escape , respetando los saltos de linea y barras invertidas.

El '$'  fusiona variables o expresiones directamente dentro del texto sin tener que usar el signo "+" para concatenar

#Ejercicio 5

_Bibliografia: https://learn.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference_


**Expresiones regulares:** es un modelo compuesto por caracteres,operadores y estructuras que sirve para buscar coincidencias exactas dentro de un texto de entrada. Su funcionamiento se basa en un motor de expresiones regulares.

**¿Funcionan unicamente en C#?**

NO, son un estandar universal en el mundo de la informatica.

**¿En que caso le parece utiles? Enuncie al menos 3**

Son utiles cuando se trabaja con procesamiento y manipulacion de texto a gran escala.

    **i.Validacion de formatos de entrada**
    **ii. Extraccion de informacion especifica**
    **iii. Reemplazo y limpieza de datos** 

**¿Como se hace uso de estas en C#?**

En C#, las expresiones regulares se usan con la libreria _System.Text.RegularExpressions_ y su componente principal es la clase _Regex_