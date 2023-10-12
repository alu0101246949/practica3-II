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

![image](https://github.com/alu0101246949/practica3-II/assets/114754476/195882db-d222-4c55-862b-dad5d46b450d)


## 5. Movimiento Proporcional al Tiempo:
- Se adaptó el movimiento para que sea proporcional al tiempo entre frames usando `Time.DeltaTime`.

![image](https://github.com/alu0101246949/practica3-II/assets/114754476/9eaa1521-7efb-471e-bfbb-7d8334bf1a09)



## 6. Dirección hacia la Esfera:
- El cubo fue programado para moverse hacia la esfera sin importar su distancia.

![Vídeo sin título ‐ Hecho con Clipchamp](https://github.com/alu0101246949/practica3-II/assets/114754476/028f705b-89e5-472e-a921-c7058d2bcc58)


## 7. Rotación hacia la Esfera:
- El cubo gira para mirar hacia la esfera utilizando el método `LookAt`.

![Vídeo sin título ‐ Hecho con Clipchamp (1)](https://github.com/alu0101246949/practica3-II/assets/114754476/2dfccc9b-ad4a-4793-979a-65f6f84d2ccc)

## 8. Uso del Eje Horizontal:
- El cubo gira usando el eje "Horizontal" y avanza en su dirección hacia adelante.

```c#
// Girar el objeto en base al input horizontal.
transform.Rotate(0f, girar * rotationSpeed * Time.deltaTime, 0f, Space.World);
        
// Mover el objeto siempre hacia adelante en su dirección local.
transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

// Dibujar un rayo para depuración y visualizar la dirección hacia adelante del objeto.
Debug.DrawRay(transform.position, transform.forward * 5f, Color.blue);
```

## 9. Colisiones con Cilindro:
- Se configuró el cilindro para detectar colisiones físicas y mostrar mensajes en la consola con la etiqueta del objeto colisionante.

![image](https://github.com/alu0101246949/practica3-II/assets/114754476/17dc50c7-ec98-4f02-babf-ce57f56bea88)

## 10. Configuraciones de Cubo y Esfera:
- El cubo fue configurado como cinemático y la esfera como objeto físico, adaptando el comportamiento de colisión correspondiente.
  
![image](https://github.com/alu0101246949/practica3-II/assets/114754476/734f9129-0c52-4651-88b9-32a31e1f24b2)

## 11. Cilindro Trigger:
- El cilindro fue configurado como objeto tipo "Trigger", adaptando los scripts para detectar las interacciones de trigger.
  
![image](https://github.com/alu0101246949/practica3-II/assets/114754476/2a790bba-aae6-4ce1-9023-4d7a790b7086)

## 12. Nuevo Cilindro y Configuraciones:
- Se introdujo un nuevo cilindro con color distinto y comportamiento físico.
- Se controló su movimiento hacia la esfera con teclas definidas.
- **Resultados de Variaciones**:
  - **Esfera con masa mayor**: El cilindro no pudo mover la esfera.
  - **Esfera con masa menor**: El cilindro pudo mover más fácilmente a la esfera.
  - **Esfera Cinemática**: La esfera, al ser cinemática, no reaccionó a choques como esperaba; simplemente no se movió cuando chocó con el cilindro.
  - **Esfera Trigger**: Las colisiones físicas no afectaron a ninguno de los objetos, pero se detectan.
 
  ![image](https://github.com/alu0101246949/practica3-II/assets/114754476/1018274f-693b-4238-bdc7-bfb9c20b56a7)

  - **Duplicación de Fricción del Cilindro**: El cilindro se detuvo más rápidamente y mostró más resistencia al movimiento.

## Conclusiones:
- El comportamiento de los objetos en Unity puede ser ampliamente configurado y adaptado mediante scripts y configuraciones en el inspector.
- La interacción entre objetos con diferentes configuraciones (físico, cinemático, trigger) varía y es crucial para lograr la mecánica deseada en un juego o simulación.
