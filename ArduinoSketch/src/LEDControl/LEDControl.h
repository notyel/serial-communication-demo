#define LEDControl_h

#include <Arduino.h>

class LEDControl
{
public:
    LEDControl(int pin); // Constructor que recibe el pin del LED
    void setup();        // Configuración inicial
    void turnOn();       // Encender el LED
    void turnOff();      // Apagar el LED

private:
    int _pin; // Pin del LED
};
