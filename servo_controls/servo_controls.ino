#include <Servo.h>

Servo baseServo, joint1, joint2; 
#define RANGE_MAX 180
#define DEBUG 0

int baseServoPin = 11;
int joint1Pin = 10;
int joint2Pin = 9;

void setup() {
  Serial.begin(38400);
  baseServo.attach(baseServoPin);
  joint1.attach(joint1Pin);
  joint2.attach(joint2Pin);
}

void loop() {
  int servoNumber = 0, angle = 0;

  if (Serial.available() > 1) {
    servoNumber = Serial.read();
    angle = Serial.read();

    if(DEBUG){
      Serial.print("I got ");
      Serial.print(servoNumber, DEC);
      Serial.print(" and ");
      Serial.println(angle, DEC);
    }

    if(angle > RANGE_MAX) { angle = RANGE_MAX; }
    if(angle < 0) { angle = 0; }

    switch(servoNumber){
      case 1:
        baseServo.write(angle);
        break;
      case 2:
        joint1.write(angle);
        break;
      case 3:
        joint2.write(angle);
        break;
    }
  }
}
