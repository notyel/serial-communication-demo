# Proyecto C# SerialTest

Este directorio contiene un proyecto de ejemplo en C# que demuestra la comunicación serial con un dispositivo desde una aplicación de consola. El proyecto está desarrollado en .NET 6 y utiliza la librería System.IO.Ports para la comunicación serial.

## Requisitos

Asegúrate de tener lo siguiente antes de continuar:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) instalado en tu computadora.

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) instalado en tu computadora.

## Configuración

1. Abre este proyecto en Visual Studio o Visual Studio Code.

2. Asegúrate de que tengas la librería System.IO.Ports incluida en tu proyecto. Puedes agregarla utilizando NuGet Package Manager.

3. Abre el archivo `Program.cs` en la carpeta `SerialTest` para ver el código fuente de la aplicación.

## Uso

1. Ejecuta la aplicación desde Visual Studio o Visual Studio Code.

2. La aplicación te pedirá que ingreses comandos para controlar el dispositivo conectado a través de la comunicación serial.

3. Para encender el dispositivo, escribe "encender" o "on" y presiona Enter. Para apagarlo, escribe "apagar" o "off" y presiona Enter.

4. Puedes ingresar más comandos según sea necesario.

## Notas Adicionales

- Puedes personalizar y modificar el código en `Program.cs` según tus necesidades. La aplicación actualmente está diseñada para controlar dispositivos a través de la comunicación serial, pero puedes adaptarla para otros usos.

- Asegúrate de seleccionar el puerto serial correcto y la velocidad de baudios en `Program.cs` antes de ejecutar la aplicación.

Esperamos que este proyecto te ayude a comprender la comunicación serial en C# utilizando .NET 6 y System.IO.Ports. ¡Diviértete programando!
