#define fwd 3
#define left 4
#define right 5
#define dive 6
#define _stop 7
#define high_velo 1
#define low_velo 2

#include <Servo.h>

Servo fw_left;
Servo fw_right;
Servo dive_left;
Servo dive_right;
int velo=68;
int input=0;
void setup()
{
Serial.begin(9600);
fw_left.attach(11);
fw_right.attach(10);
dive_left.attach(9);
dive_right.attach(6);
pinMode(3,OUTPUT);
}

void loop()
{
  digitalWrite(3,HIGH);
  
  if(Serial.available())
  {
    Serial.println("data enterd");
    input =Serial.parseInt();
    if(input==high_velo)
    {
      velo=179;
      Serial.print("velo=");
      Serial.println(velo);
    }
    else if(input==low_velo)
    {
      velo=100;
      Serial.println(velo);
    } 
    else if(input==fwd)
    {
      Serial.print(velo);
      Serial.println("is velo in fwd");
      fw_left.write(velo);
      fw_right.write(velo);
      dive_left.write(68);
      dive_right.write(68);
      delay(6000);
    }
    else if(input==left)
    {
      Serial.println("turning left");
      fw_left.write(68);
      fw_right.write(velo);
      dive_left.write(68);
      dive_right.write(68); 
      delay(6000);
  }
     else if(input==right)
    {
      Serial.println("turning right");
      fw_left.write(velo);
      fw_right.write(68);
      dive_left.write(68);
      dive_right.write(68); 
      delay(6000);
    }
    else if(input==dive)
    {
      Serial.println("going for a dive!!");
      fw_left.write(68);
      fw_right.write(68);
      dive_left.write(velo);
      dive_right.write(velo); 
      delay(6000);
    }
    else if(input==_stop)
    {
      Serial.println("Halt!!");
      fw_left.write(68);
      fw_right.write(68);
      dive_left.write(68);
      dive_right.write(68); 
    }
    Serial.flush();
  }
else 
    {
      fw_left.write(68);
      fw_right.write(68);
      dive_left.write(68);
      dive_right.write(68); 
    } 
}
  
