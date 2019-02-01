# ArduinoPIDCtrl : Simple Arduino PID Controller developped in C#

## Screenshots
![Screenshot 1](https://raw.githubusercontent.com/jimmycaille/ArduinoPIDCtrl/master/Screenshots/readme.png "Screenshot 1")

## Features
This is greatly inspired by the "Dark room experiment" used to demonstrate the use of a PID controller :
https://www.instructables.com/id/Arduino-PID-Library-Luminosity-Control/

* Setpoint (0-255), Sample time (ms) as well as P, I and D coefficients can be adjusted on the fly
* Setpoint, input (LDR) and output (LED) values are displayed on the graph

## Project structure
- README.md    -> that the file you are reading now
- Screenshots  -> behavior of the app
- Schematics   -> Fritzing schematics and captures
- ldr_read     -> Arduino project
- PidCtrl      -> Visual Studio project
  - PidCtrl\PidCtrl\bin\Debug\PidCtrl.exe -> latest version of the Windows app
  
## Schematics
![Fritzing schematic](https://raw.githubusercontent.com/jimmycaille/ArduinoPIDCtrl/master/Schematics/readme.png "Fritzing schematic")

### Wiring
* A0 - R1 - GND
* A0 - LDR - VCC
* D3 - LED - R2 - GND

## Log
### TODO

## Known issues
* Reduce external light if oscillating occur (especially artificial like fluorescent tube)

## Prerequisites (to upload Arduino code, open Visual Studio project and read Fritzing schematics)
### Arduino IDE (free) can be found here :
https://www.arduino.cc/en/main/software
### Visual Studio Community (free) can be found here :
https://visualstudio.microsoft.com
### Fritzing (free) can be found here :
http://fritzing.org/download/

## Developper infos
- Author : Jimmy Caille
- Email  : jimmy.caille.dev@gmail.com
