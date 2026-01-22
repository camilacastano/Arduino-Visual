// librerias
#include <Servo.h>   // permite controlar el servo motor PWM

// variables globales
int pinAnalogo =0;  //definiendo el pin A0
Servo miMotor;


void setup() {
  // put your setup code here, to run once:
  // configura pines, comunicaciones...
  // una vez se configura empieza la ejecucion del loop (ciclo infinito)
  pinMode(13, OUTPUT);
  miMotor.attach(9);
  Serial.begin(9600);
  InicializarSerial();
}

void loop() {
  // put your main code here, to run repeatedly:
  // codificacion de las acciones... lectura de puertos, escritura de puertos, condiciones, ciclos, llamado a funciones

  DefinirAccion();

}

void DefinirAccion()
{
  if (Serial.available())
  {
    switch(Serial.read())
    {
      case 'p':
        PrenderLed();
      break;
      case 'a':
        ApagarLed();
      break;
      case 'l':
        LeerEntrada();
      break;
      case 'm':
        MoverMotor();
      break;
      case 's':
        Salir();
      break;
    }
  }
}


void PrenderLed()
{
  digitalWrite(13, HIGH);  // 5V en el pin 13
  Serial.write('p');
}

void ApagarLed()
{
  digitalWrite(13, LOW);
  Serial.write('a');
}

void LeerEntrada()
{
  int dato=-1;
  dato = 10*analogRead(pinAnalogo);     //5V  1024    0V  0  conversion 10 bits
  dato = (5.0*dato)/1024.0;

  //dato listo para ser enviado
  Serial.write(dato);
}

void MoverMotor()
{
  int datoVisual;
  Serial.write('m');
  //el visual envia el valor
  datoVisual=Serial.parseInt();
  if (datoVisual!=0)
  {
    miMotor.write(datoVisual);
  }
}

void Salir()
{
  InicializarSerial();
}


void InicializarSerial()
{
  int frase[6];
  frase[0]='p';
  frase[1]='r';
  frase[2]='o';
  frase[3]='b';
  frase[4]='a';
  frase[5]='r';

  int i=0;

  while(1)
  {
    if (Serial.available())
    {
      if(Serial.read()==frase[i])
      {
        if (i==5)
        {
          Serial.write('c');
          break;
        }
        i++;
      }
    }
  }
}




// funciones creadas por nosotros
