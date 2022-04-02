#include <Servo.h>

#define RANGE_MAX 180
#define DEBUG 0

Servo baseServo, joint1, joint2; 
byte baseServoPin = 11;
byte joint1Pin = 10;
byte joint2Pin = 9;

void setup() {
  Serial.begin(38400);
  baseServo.attach(baseServoPin);
  joint1.attach(joint1Pin);
  joint2.attach(joint2Pin);
}

void loop() {
  byte servoNumber = 0, angle = 0;

  if (Serial.available() > 3) {
    byte header = 0;
    while(header != 0xFF){
      header = Serial.read();
    }
    
    servoNumber = Serial.read();
    angle = Serial.read();

    byte checksum = servoNumber + angle;
    byte givenChecksum = Serial.read();

    if(checksum != givenChecksum){
      char message[40];
      sprintf(message, "Mismatched checksum - calculated: %d, given %d", checksum, givenChecksum);
      Serial.print(message);
      return;
    }
    
    if(DEBUG){
      char debug[40];
      sprintf(debug, "I got %d and %d", servoN, angleChecksum);
      Serial.print(debug);
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
