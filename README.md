# Título
# CiberCafe el Vicio

*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí
*Mi nombre es Esteban Mato tengo 27 años y soy recursante de este matería.
Ya en el cuatrimestre pasado se me complico con los tiempos y me volvío a pasar.
Al menos para mí fue bastante difícil el parcial, al no tener una consigna consisa, el hecho de tener que resolver lo solicitado cuesta más que después ponerlo en código, pero creo que es una muy buena práctica ya que laboralmente siempre va a ser así y además fue bastante entretenido, si tuviera más tiempo hubiera jugado un poco más con el diseño y talves algo de sonido para el programa.*

## Resumen
Basicamente la aplicación permite la gestión y control de un Ciber, en donde se podrán asignar y facturar tanto cabinas telefónicas como equipos de computación.

Cuenta con 5 menues distintos, por los cuales se podran navegar para realizar las dinstintas operaciones. 

###Menu Principal
En dicho podremos observar el estado de los equipos, cuales estan en uso, cuales no y por quien estan siendo utilizados. Abajo observamos una lista de clientes en espera de ser atendidos.
Desde aquí se podra llamar al *Próximo Cliente*, podremos *Cobrar* el uso de un equipo, *Ver información* de componentes y *Estadisticas* historicas de atención, y también generar una solicitud de un *Nuevo Alquiler*.

-Próximo Cliente
En este menú figurara el próximo cliente, de la lista de espera, y en caso de haber un equipo disponible que cumple lo solicitado por el cliente, podrá ser asignado.

-Cobrar
Seleccionaremos una Computadora o Teléfono y clickear dicho botón, se facturara el uso del equipo, indicado el tiempo y el costo del alquiler

-Info Equipos
Podremos visualizar la información del equipo seleccionado, tanto de los Teléfonos, como de las Computadoras

-Estadísticas
Desde este menú podremos ingresar a ver distintos tipo de estadisticas del Ciber, como por ejemplo cantidad de usos de un equipo o el total recaudado

-Nuevo Alquiler
Para generar el alta de un nuevo alquiler, se ingresara los datos del cliente, el tipo de alquiler requerido y los requisitos para el mismo. Pasando a ser el último cliente en la fila

Cada menú cuenta con un boton de ayuda **?** con información sobre el uso de la aplicación

## Diagrama de clases
[Diagrama de Clases](https://imgur.com/a/iYHD5Xk)

## Justificación técnica
###**Clase 1**
Con respescto a la clase 1, basicamente todo el programa fue realizado en c# y .NET, aprovechando lo que es la programación orientada a objetos.

###**Clase 2**
Se utilizaron métodos estaticos en todas aquellos métodos que no requerian acceso a la información de una instancia de un objeto, como por ejemplo en todas las estadísticas que se pueden visualizar desde el formulario **FrmMenuEstadistica**
También para esta aplicación en particular aprovechamos las clases estáticas para realizar el hardcodeo tanto de los equipos como de los clientes en espera, ya que para el tipo de utilización que íbamos a darle, no era necesario la instanciación de la misma.

###**Clase 3**
De esta clase aprovechamos los pilares de la programación orientada a objetos para poder realizar la estructura del código.
Por ejemplo tenemos la clase *Cliente* la cual es una clase abstracta y de ella van a heredar *Jugador* y *Llamador*. Utilizamos la abstracción para definir los comportamientos en donde un *Cliente*, sea *Llamador* o *Jugador*, se comportan de la misma manera, y así no repetir código, pero luego en las clases que derivan, definir los comportamientos concretos de cada tipo de *Cliente*, y así también tener mejor organizado el código.
En estas tres clases vemos que se utiliza el Encapsulamiento por ejemplo en lo comentado anteriormente ya que un Cliente Jugador, no tendra entre sus datos un número telefónico al que llamar.
Por herencia y polimorfismo lo vemos tanto en estas clases como en otras partes del código donde por ejemplo el método **Mostrar** es sobreescritor de la clase padre para imprimir otro tipo de información distina a la clase padre, pero en la clase *Equipo* vemos que *Telefono* y *Computadora* heredan el comportamiento del método **CambiarEstado**

###**Clase 4**
La sobrecarga se utilizo en distintas partes del código por ejemplo en la clase *Alquiler*, en el método **CalcularCosto** puede recibir como parámetro un *Jugador* o un *Llamador* y realizar, en este caso, la misma funcionalidad, la cual es calcular el costo de uso de un equipo, pero dependiendo del tipo de Alquiler realizado.
También en la clase *Alquiler* realizamos una sobrecarga de operadores para determinar sin un *Cliente* es igual al *Cliente* perteneciente a un *Alquiler* a través del operador ==

###**Clase 5**
Se utilizaron 5 formularios para darle apariencia más amigable a la apligacion y poder interactuar con la misma por parte del usuario.
Tenemos los siguientes formularios:
-Menu principal: FrmMenu
-Menu alta de alquiler: FrmMenuAltaAlquiler 
-Menu computadora: FrmMenuComputadora
-Menu telefono: FrmMenuTelefono
-Menu estadisticas: FrmMenuEstadisticas


###**Clase 6**
Encontramos 2 tipo de colecciones genéricas en el código, una es una clase Queue utilizada para el listado de clientes en espera y así aprovechar la colección que funciona con el metodo FIFO primer cliente en llegar, es el primero en salir y así podremos respetar el orden de llegada requerido para los clientes en espera.
Y también se encuentras distintas colecciones del tipo List, en donde guardamos, por ejemplo, el listado de aplicaciones requeridas por un cliente, los softwares solicitados o los juegos requeridos, y a través de un foreach poder recorrer dicha colección cuando es requerida.


###**Clase 7**
Se utilizo el encapsulamiento para determinar a donde se podrá acceder desde distintas partes del código y a donde no, en las clases *Alquiler* y *Cliente* todos sus atributos son privados y solo son accesibles a través de los getters y setters de la clase. También todos métodos utilizados para el formulario **FrmMenuEstadistica** son privados, ya que no hace falta que sean accedidos desde otra clase o formulario, entonces así reestrigimos el acceso.


###**Clase 8**
Como ya comentamos, la herencia se utilizo en más de una ocasión, en donde por ejemplo un *Llamador* y un *Jugador* son un *Cliente*, en donde heredan de la clase padre los comportamientos en común que tendrían ambas clases por se un cliente del ciber, pero después cada uno implementara sus métodos particulares.
Ambos al ser un cliente tendran dni, nombre, apellido, edad, accion y se podrá obtener un tiempo de uso, pero luego cada clase hija se comportara de manera distinto dependiendo de su funcionalidad.

###**Clase 9**
El polimorfismo se puede ver utilizado en los métodos **ToString** en los cuales sobreescribimos el comportamiento del **ToString**, el cual llamara al método **Mostrar** y así mostrar la información de cada clasa, se utilizo de esta forma para ser un uso más facil del método ToString, siempre al querer ver la información de cada clase.
La clase *Alquiler* se la marco como clase sellada, ya no es requerido que se puede heredar la misma. Siempre va a ser un mismo alquiler, independientemente del tipo de equipo utilizado, ya que la misma solo guardara el *cliente*, *equipo*, *costo* y el *tiempo de uso* del alquiler.


## Propuesta de valor agregado
Se agrego una opción extra para darle una mejor utilidad a la aplicación. Se podran agregar nuevas solicitudes de alquieler a la lista de espera, en donde se deberán indicar todos los datos del cliente y el tipo de accion que desea realizar (Jugar o Llamar). En caso de llamar, simplemente validara los datos y se agregara a lista de espera, en el caso de requerir viciar, deberá de indicar lor componentes requeridos para el uso del equipo, aunque también puede optar por ningún tipo de Software, Juego o periferico.
Esto aportara la continuación del uso de la aplicación y no simplemente basarse en lo clientes Hardcodeados ya en espera.
