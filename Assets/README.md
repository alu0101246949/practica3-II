# Ejercicios Práctica 3: Unity 3D y Físicas

## Ejercicio 1: Asignar velocidad al cubo y mostrar mensajes en consola
Se ha asignado una variable velocidad al cubo, la cual es multiplicada por el valor del eje vertical/horizontal, logrando movimientos proporcionales a la entrada del usuario. Al presionar las flechas del teclado, se muestra en la consola un mensaje que indica la tecla pulsada y el resultado de las multiplicaciones mencionadas.

## Ejercicio 2: Controlar Movimiento del Cubo con Vector3
Se desarrolló un script que permite mover el cubo en base a un vector de dirección y una velocidad, ambos modificables desde el inspector de Unity. A lo largo de distintos escenarios (modificación de coordenadas, velocidad, y altura), se observó cómo estas variables impactaban en el desplazamiento del cubo, detallando peculiaridades como cambios en la trayectoria y la influencia de los sistemas de referencia local y mundial.

## Ejercicio 3: Movimiento con Teclas
Se implementó control de movimiento del cubo y la esfera con diferentes teclas, permitiendo el desplazamiento independiente de ambos objetos por la escena de Unity. Este control se realizó utilizando `Input.GetAxis` para lograr un movimiento suave y progresivo.

## Ejercicio 4: Movimiento Proporcional al Frame Time
El movimiento del cubo fue adaptado para ser proporcional al tiempo transcurrido entre frames (`Time.deltaTime`), asegurando así que el desplazamiento es fluido y consistente independientemente de la tasa de frames por segundo del juego.

## Ejercicio 5: Cubo Siguiendo a la Esfera
El cubo se configuró para moverse en dirección a la esfera, sin influencia de la distancia entre ambos. Se utilizó la normalización del vector de dirección para asegurar que el movimiento del cubo sea constante y no dependa de la magnitud del vector direccion.

## Ejercicio 6: Rotación del Cubo Hacia la Esfera
El método `LookAt()` de la clase `Transform` fue utilizado para lograr que el cubo siempre rote y mire hacia la esfera, incluso cuando la posición de esta última es modificada mediante la entrada del usuario (teclas AWSD).

## Ejercicio 7: Movimiento y Rotación con Eje “Horizontal”
A través del uso de la propiedad `forward` del `Transform`, se implementó una mecánica que permite al cubo avanzar siempre en la dirección hacia adelante, mientras que el eje "Horizontal" controla la rotación.

## Ejercicio 8: Detección de Colisiones con Cilindro Físico
Se configuró el cilindro como objeto físico y se implementó lógica para mostrar un mensaje en la consola indicando la etiqueta del objeto que colisionó con él (cubo o esfera).

## Ejercicio 9: Objetos Cinemáticos y Físicos
El cubo se configuró como objeto cinemático y la esfera como físico, modificando los scripts previos para mantener el comportamiento deseado en las interacciones y colisiones.

## Ejercicio 10: Cilindro como Trigger
El cilindro fue configurado como objeto de tipo Trigger, permitiendo detectar colisiones sin generar una respuesta física. Los scripts previos fueron adaptados para manejar estos eventos.

## Ejercicio 11: Cilindro Móvil y Pruebas de Físicas
Se añadió un nuevo cilindro al entorno y se establecieron controles para moverlo por la escena dirigido hacia la esfera. Se realizaron pruebas con diferentes configuraciones físicas (masa, cinemática, trigger, fricción) en la esfera y el cilindro, observando variados comportamientos, resistencias y resultados en las interacciones y colisiones. Los resultados y observaciones de cada configuración y prueba se detallarán en el informe.
