int pin0=A0;
int pin1=A1;
int pin2=A2;
int pin3=A3;
int pin4=A4;
int pin5=A5;
int pin6=A6;
int pin7=A7;

int val0=0;
int val1=0;
int val2=0;
int val3=0;
int val4=0;
int val5=0;
int val6=0;
int val7=0;
int serialPeriod=200; //ms
long serialTime;

void setup() {
  pinMode(pin0, INPUT);
  pinMode(pin1, INPUT);
  pinMode(pin2, INPUT);
  pinMode(pin3, INPUT);
  pinMode(pin4, INPUT);
  pinMode(pin5, INPUT);
  pinMode(pin6, INPUT);
  pinMode(pin7, INPUT);
  Serial.begin(9600);
}
void loop() {
  val0 = analogRead(pin0); //max 1024
  val1 = analogRead(pin1); //max 1024
  val2 = analogRead(pin2); //max 1024
  val3 = analogRead(pin3); //max 1024
  val4 = analogRead(pin4); //max 1024
  val5 = analogRead(pin5); //max 1024
  val6 = analogRead(pin6); //max 1024
  val7 = analogRead(pin7); //max 1024

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
    serialPeriod = getValue(input,' ',0).toInt();
  }
}

void serialSend(){
  Serial.print(val0);
  Serial.print(" ");
  Serial.print(val1);
  Serial.print(" ");
  Serial.print(val2);
  Serial.print(" ");
  Serial.print(val3);
  Serial.print(" ");
  Serial.print(val4);
  Serial.print(" ");
  Serial.print(val5);
  Serial.print(" ");
  Serial.print(val6);
  Serial.print(" ");
  Serial.print(val7);
  Serial.print(" ");
  Serial.println(serialPeriod);
}
