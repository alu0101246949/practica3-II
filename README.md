# Informe: Ejercicios Práctica 3

## 1. Control del Cubo con Velocidad Variable:
- **Configuración**: Se agregó un campo "velocidad" al cubo con posibilidad de modificación en el inspector.
- **Resultados**: Al pulsar las flechas del teclado, se mostró en la consola la multiplicación de la velocidad por el valor del eje correspondiente.

![image](https://github.com/alu0101246949/practica3-II/assets/114754476/59e32e69-7cf6-4198-84ce-f808449f4d72)

## 2. Mapeo de Tecla para Disparo:
- Se mapeó la tecla "H" a una función de disparo utilizando el Input Manager.

![image](https://github.com/alu0101246949/practica3-II/assets/114754476/36ff7780-234f-4741-9dbc-5371520debfc)
![image](https://github.com/alu0101246949/practica3-II/assets/114754476/c89238aa-5c02-4f49-8019-9cbd5ce18664)


## 3. Dirección de Movimiento del Cubo:
- Se creó un script que traslada al cubo según un vector de dirección `moveDirection`.
- **Resultados de Variaciones**:
  - **Duplicación de Coordenadas**: No se observan cambios significativos en el movimiento. Esto se debe a que hemos normalizado el vector, por lo tanto, sólo se utiliza la    dirección y no la magnitud.
  - **Duplicación de Velocidad**: Al duplicar la velocidad, el cubo se mueve con una rapidez notablemente mayor.
  - **Velocidad < 1**: El cubo parece moverse en dirección opuesta, como si retrocediera.
  - **Posición con y>0**: Al iniciar el cubo con una posición y mayor que cero, éste se desplaza hacia arriba.
  - **Cambio de Sistema de Referencia**: Al aplicar `Space.World` en `Translate`, no se nota diferencia.



## 4. Movimiento con Teclas:
- Se controló el cubo con las flechas del teclado y la esfera con W, A, S, D.

## 5. Movimiento Proporcional al Tiempo:
- Se adaptó el movimiento para que sea proporcional al tiempo entre frames usando `Time.DeltaTime`.

## 6. Dirección hacia la Esfera:
- El cubo fue programado para moverse hacia la esfera sin importar su distancia.

## 7. Rotación hacia la Esfera:
- El cubo gira para mirar hacia la esfera utilizando el método `LookAt`.

## 8. Uso del Eje Horizontal:
- El cubo gira usando el eje "Horizontal" y avanza en su dirección hacia adelante.

## 9. Colisiones con Cilindro:
- Se configuró el cilindro para detectar colisiones físicas y mostrar mensajes en la consola con la etiqueta del objeto colisionante.

## 10. Configuraciones de Cubo y Esfera:
- El cubo fue configurado como cinemático y la esfera como objeto físico, adaptando el comportamiento de colisión correspondiente.

## 11. Cilindro Trigger:
- El cilindro fue configurado como objeto tipo "Trigger", adaptando los scripts para detectar las interacciones de trigger.

## 12. Nuevo Cilindro y Configuraciones:
- Se introdujo un nuevo cilindro con color distinto y comportamiento físico.
- Se controló su movimiento hacia la esfera con teclas definidas.
- **Resultados de Variaciones**:
  - **Esfera con masa mayor**: El impacto en el cilindro fue menor debido al mayor peso de la esfera.
  - **Esfera con masa menor**: El cilindro pudo mover más fácilmente a la esfera.
  - **Esfera Cinemática**: No hubo interacciones físicas reales; la esfera no fue afectada por colisiones.
  - **Esfera Trigger**: Las colisiones físicas no afectaron a ninguno de los objetos, pero se detectaron.
  - **Duplicación de Fricción del Cilindro**: El cilindro se detuvo más rápidamente y mostró más resistencia al movimiento.

## Conclusiones:
- El comportamiento de los objetos en Unity puede ser ampliamente configurado y adaptado mediante scripts y configuraciones en el inspector.
- La interacción entre objetos con diferentes configuraciones (físico, cinemático, trigger) varía y es crucial para lograr la mecánica deseada en un juego o simulación.
