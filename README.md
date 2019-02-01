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
- LDR_calc.xlsx -> File to test different resistor values for the LDR
  
## Schematics
![Fritzing schematic](https://raw.githubusercontent.com/jimmycaille/ArduinoPIDCtrl/master/Schematics/readme.png "Fritzing schematic")

### Wiring
* A0 - R1 - GND
* A0 - LDR - Vcc
* D3 - LED - R2 - GND

### Resistor values
* R1 sets the range of the input and depends of the LDR used.
Measure the LDR value when in the dark and illuminated by a bright light.
For example for R1=100kΩ, R<sub>high</sub>=800kΩ and R<sub>low</sub>=5kΩ the voltages would be :
  * $\frac{R<sub>high</sub>}{R<sub>high</sub>+R1}*Vcc = \frac{800}{800+100} *5.0 = 4.44V$
  * $\frac{R<sub>low</sub>}{R<sub>low</sub>+R1}*Vcc = \frac{5}{5+100} *5.0 = 0.24V$
  * Keep in mind that the function is not linear (see LDR_calc.xlsx file)
* R2 limits the LED current : 220Ω is a good value
$1+1=2$

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
