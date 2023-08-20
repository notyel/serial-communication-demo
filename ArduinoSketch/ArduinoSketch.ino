#include "src/LEDControl/LEDControl.h"

const int ledPin2 = 2;   // Pin del LED
LEDControl led(ledPin2); // Crear una instancia de la clase LEDControl
bool blink = false;      // Variable para controlar el parpadeo

void setup()
{
    Serial.begin(9600);
    led.setup(); // Configurar el LED
}

void loop()
{
    if (Serial.available() > 0)
    {
        String command = Serial.readString(); // Lee el comando enviado desde C#

        if (command == "on")
        {
            led.turnOn();  // Enciende el LED
            blink = false; // Detiene el parpadeo si estaba en progreso
        }
        else if (command == "off")
        {
            led.turnOff(); // Apaga el LED
            blink = false; // Detiene el parpadeo si estaba en progreso
        }
        else if (command == "blink")
        {
            blink = true; // Inicia el parpadeo
        }
    }

    if (blink)
    {
        // Hacer que el LED parpadee
        led.turnOn();
        delay(500);
        led.turnOff();
        delay(500);
    }
}
