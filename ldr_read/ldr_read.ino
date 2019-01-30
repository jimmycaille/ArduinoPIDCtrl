#include <PID_v1.h>

int pinLDR=A0;
int pinLED=3; //d3
int val=0;
int serialPeriod=200; //ms
long serialTime;
int sampleTime = 10;//100 def

//Define Variables we'll be connecting to
double Setpoint=100, Input, Output;
//Specify the links and initial tuning parameters
double Kp=2.0, Ki=0.1, Kd=0;
PID myPID(&Input, &Output, &Setpoint, Kp, Ki, Kd, DIRECT);

void setup() {
  pinMode(pinLDR, INPUT);
  pinMode(pinLED, OUTPUT);
  Serial.begin(9600);
  
  //turn the PID on
  myPID.SetMode(AUTOMATIC);
  myPID.SetControllerDirection(DIRECT);
  myPID.SetSampleTime(sampleTime);
}
void loop() {
  val = analogRead(pinLDR); //max 1024
  Input = val/4;
  myPID.Compute();
  analogWrite(pinLED, Output);//max 255

  if(millis()>serialTime){
    serialReceive();
    serialSend();
    serialTime+=serialPeriod;
  }
}
//https://arduino.stackexchange.com/questions/1013/how-do-i-split-an-incoming-string
String getValue(String data, char separator, int index){
    int found = 0;
    int strIndex[] = { 0, -1 };
    int maxIndex = data.length() - 1;

    for (int i = 0; i <= maxIndex && found <= index; i++) {
        if (data.charAt(i) == separator || i == maxIndex) {
            found++;
            strIndex[0] = strIndex[1] + 1;
            strIndex[1] = (i == maxIndex) ? i+1 : i;
        }
    }
    return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void serialReceive(){
  if(Serial.available()){
    String input = Serial.readStringUntil("\n");

    Setpoint = getValue(input,' ',0).toDouble();
    myPID.SetTunings(
      getValue(input,' ',1).toDouble(),
      getValue(input,' ',2).toDouble(),
      getValue(input,' ',3).toDouble());
    sampleTime = getValue(input,' ',4).toInt();
    myPID.SetSampleTime(sampleTime);
  }
}

void serialSend(){
  Serial.print(Setpoint, 0); //cut at comma (int)
  Serial.print(" ");
  Serial.print(Input);//255
  Serial.print(" ");
  Serial.print(Output);
  Serial.print(" ");
  Serial.print(myPID.GetKp());
  Serial.print(" ");
  Serial.print(myPID.GetKi());
  Serial.print(" ");
  Serial.print(myPID.GetKd());
  Serial.print(" ");
  Serial.println(sampleTime);
}
