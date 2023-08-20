using System;
using System.IO.Ports;

// Establece el nombre del puerto serial, la velocidad de transmisión y otros parámetros según tu configuración
string puertoSerial = "COM4"; // Ajusta el puerto serial en el que está conectado tu Arduino
int velocidadBaudios = 9600; // Ajusta la velocidad de baudios según tu código Arduino

SerialPort puerto = new SerialPort(puertoSerial, velocidadBaudios);

try              
{
    puerto.Open();

    Console.WriteLine("Serial Port test 1.0");
    Console.WriteLine("Conexión con el microcontrolador establecida. Ingresa 'encender' o 'apagar' para controlar el pulso.");

    while (true)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; 
        Console.Write("SerialPortTest>>> "); 
        Console.ResetColor(); 
        string comando = Console.ReadLine();

        if (comando.ToLower() == "encender" || comando.ToLower()  == "on")
        {
            puerto.Write("on"); 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Señal de encendido (on) enviada al puerto serial {puertoSerial}");
            Console.ResetColor();
        }
        else if (comando.ToLower() == "apagar" || comando.ToLower() == "off")
        {
            puerto.Write("off"); 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Señal de apagado (off) enviada al puerto serial {puertoSerial}");
            Console.ResetColor();
        }
        else if (comando.ToLower() == "salir" || comando.ToLower() == "exit")
        {
            break; // Sale del programa si el usuario escribe "salir"
        }
        else if (comando.ToLower() == "parpadear" || comando.ToLower() == "blink")
        {
            puerto.Write("blink"); // Envía el comando "parpadear" al microcontrolador
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Señal de parpadeo (blink) enviada al puerto serial {puertoSerial}");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Comando no válido. Escribe 'encender', 'apagar' o 'salir'.");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    puerto.Close();
}