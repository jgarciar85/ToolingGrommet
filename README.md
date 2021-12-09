# ToolingGrommet
Software Tooling System![image](https://user-images.githubusercontent.com/60390681/145311541-2040a0dd-c905-4329-af28-e9b69245e33f.png)
Background 
PM’s de Grommets se realizan con frecuencia en dias +/- tolerancia del PMC
Este preventivo tiene mas de 10 años de realizarse

Oportunidad
No va en cuenta del material producido, ni los picos de producto producido
Hay posibilidad de correr producto con grommets fuera de dimensiones
Bandas Angostas

Objetivo
Optimizar el uso de grommets por piezas producidas
Reduccion costos (Scrap / Usage Grommets)
Reducir la oportunidad de generar defectos de calidad (Bandas Angostas).




![image](https://user-images.githubusercontent.com/60390681/145311560-6c5f9bb4-8420-4f85-afbe-d5f41685194f.png)
Software
1.- Grommets
PM de Grommets por ciclos en lugar de por mediciones, llevar trackeo de tiempo de vida en tiempo real.

2.- Mejora del sistema actual de Control de Tooling (Cambios de Pin Packs en línea)
Base de datos histórico, graficas por Línea/Prensa/ID Tooling
Incluir cambio de Tooling por necesidad producción (Técnico captura Tooling a utilizar línea XX min antes de terminar grupo)
Usar de base modificación de software en Dipper
Mantener información disponible siempre
Graficas de tendencia por Tooling (Power BI)
![image](https://user-images.githubusercontent.com/60390681/145311617-1b24a3a8-6b4c-4a47-9eb8-fca1ac2bc411.png)
Fases
1. Instalacion de Software en Dippers
2. Control de Cambios y Reparacion de Pin Packs 
3. Predictivo Grommets (Produccion y Dimensiones)
![image](https://user-images.githubusercontent.com/60390681/145311625-03e220f5-1f81-4286-9fc9-7fb628051db5.png)


Fase 1 - Instalacion de Software en Dippers 

Alcance inicial
Linea 3 y 4 Dipper A
Captura Adicional Codigo Barras Set Grommets a Utilizar en el Batch.

Requerimientos
Generar formatos “Informacion de SET” para captura de grommet al inicio Batch
Colocar formatos en carros Matriz

Produccion
Capturar Codigo de grommets a usar al Inicio del Batch
Colocar formato en carro matriz correcto al cambio de grommets


![image](https://user-images.githubusercontent.com/60390681/145311643-eba3ebb0-c8ac-486f-9bad-7b538b3e2fa6.png)
Fase 2 - Control de Cambios y Reparacion de Pin Packs
Alcance inicial
Lineas 1 – 10 Dipper A y B

Requerimientos
Instalacion Software Dipper
Instalacion Estacion Trabajo Captura en mesas de Reparacion

Mantenimiento
Capturar Pin Pack / Grate Plate 
Capturar Pines Quebrados y Doblados

Expulsion
Desarrollo Sistema Hand Held para Captura de Pin Packs Expulsion



![image](https://user-images.githubusercontent.com/60390681/145311685-80736b7d-aded-451f-b4bd-813db622ef48.png)
Fase 3 - Predictivo Grommets (Produccion y Dimensiones)
Alcance
Todos los grommets Coppering / Reemplazo por uso en Produccion + Dimensiones

Requerimientos
Generar formatos “Informacion de SET” cada set ingresado
Identificacion de formatos en carros Matriz

Produccion
Capturar Codigo de grommets a usar al Inicio del Batch
Colocar formato en carro matriz correcto al cambio de grommets

Procesos/SQI/Tooling
- Se genera regresion para determinar tiempo de vida Grommets


![image](https://user-images.githubusercontent.com/60390681/145311739-ed9601ce-7ed7-4a5b-b8e4-800f50e29233.png)



