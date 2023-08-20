#include "LEDControl.h"

LEDControl::LEDControl(int pin) : _pin(pin) {}

void LEDControl::setup()
{
    pinMode(_pin, OUTPUT); // Configurar el pin como salida
}

void LEDControl::turnOn()
{
    digitalWrite(_pin, HIGH); // Encender el LED
}

void LEDControl::turnOff()
{
    digitalWrite(_pin, LOW); // Apagar el LED
}
