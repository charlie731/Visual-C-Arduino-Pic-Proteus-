/********************************* Principal INICIO *****************************************/
// constants won't change. They're used here to
// set pin numbers:
const int button_inicio = 22;         // the number of the pushbutton pin
const int button_paro = 23;           // the number of the pushbutton pin
const int button_nb = 24;             // the number of the pushbutton pin
const int button_na = 25;             // the number of the pushbutton pin
const int button_termico = 26;        // the number of the pushbutton pin
// LEDs
const int led_ciclo =  37;            // the number of the LED pin
const int led_fallo =  36;            // the number of the LED pin
const int led_pump =  35;             // the number of the LED pin

// variables will change:
int buttonState_inicio = 0;           // inicio for reading the pushbutton status
int buttonState_paro = 0;             // paro for reading the pushbutton status
int buttonState_nb = 0;               // Nivel Bajo for reading the pushbutton status
int buttonState_na = 0;               // Nivel Alto for reading the pushbutton status
int buttonState_termico = 0;          // Rele Termico for reading the pushbutton status

int State_led_ciclo = 0;              // ciclo for reading the status
int State_led_fallo = 0;              // fallo for reading the status
int State_led_pump = 0;               // pump for reading the status

// Variables a utilizar
 boolean falla;                       
 boolean flasheo;
 int state=0;//crear toggle
 int ktiempo;
 int x;
 int y;
 int puertoA;
 int puertoC;
 
// Prototipos
void busca_falla(void);
void secuencia(void);
void mostrar_falla(void);
void genera_flasheo(void);
void envia_datos(void);
void toggle(void);

// Desarrollo de Funciones... /**************************************************************/
void toggle(void) // Funcion Para Flasheo de Led
{
 digitalWrite(led_fallo, (state) ? HIGH : LOW);
 state = !state; 
}
/********************************************************************************************/
void busca_falla(void) // Funcion para Buscar Falla
{
  if (!buttonState_nb && buttonState_na)falla=1;
  if (buttonState_termico)falla=1;
}
/********************************************************************************************/
void secuencia(void) // SEcuencia de programa 
{
  if (!buttonState_nb && !buttonState_na)digitalWrite(led_pump, HIGH);
  if (buttonState_nb && buttonState_na)digitalWrite(led_pump, LOW);
}
/********************************************************************************************/
void mostrar_falla(void) // Visualiza Falla
{
  digitalWrite(led_pump, LOW);
  digitalWrite(led_ciclo, LOW);
  if (flasheo)toggle();// Led Fallo; // Fallo Flash...
  if (buttonState_paro)falla=0;
}
/********************************************************************************************/
void genera_flasheo(void) // Generador de flasheo
{
  ktiempo=ktiempo+1;
  if (ktiempo==5)
  {
    flasheo=!flasheo;
    ktiempo=0;
  }
}
/********************************************************************************************/
  void envia_datos(void) // ENviar datos por RS232
  {
    Serial.print("$");
    if (PINA<=9)Serial.print("0");// Para que la trama sea "$00%00@" Porque imprime sino "$0%0@"
    Serial.print(PINA);
    Serial.print("%");
    if (PINC<=9)Serial.print("0");// Para que la trama sea "$00%00@" Porque imprime sino "$0%0@"
    Serial.print(PINC);
    Serial.print("@"); // Trama $00%00@ completa , Lista para Desentramar...
  }
/********************************************************************************************/
void setup()// INICIALIZANDO
{
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  // Declaracion de entradas y salidas

  // initialize the LED pin as an output:
  pinMode(led_ciclo, OUTPUT);
  pinMode(led_fallo, OUTPUT);
  pinMode(led_pump, OUTPUT);
  
  // initialize the pushbutton pin as an input:
  pinMode(button_inicio, INPUT);
  pinMode(button_paro, INPUT);
  pinMode(button_nb, INPUT);
  pinMode(button_na, INPUT);
  pinMode(button_termico, INPUT);
}

// the loop routine runs over and over again forever:
void loop()
{
 buttonState_inicio = digitalRead(button_inicio);   // inicio reading the pushbutton status
 buttonState_paro = digitalRead(button_paro);       // paro reading the pushbutton status
 buttonState_nb = digitalRead(button_nb);           // Nb reading the pushbutton status
 buttonState_na = digitalRead(button_na);           // Na reading the pushbutton status
 buttonState_termico = digitalRead(button_termico); // Termico reading the pushbutton status
 
 State_led_ciclo = digitalRead(led_ciclo);          // Ciclo for reading the State_leds status
 State_led_fallo = digitalRead(led_fallo);          // Fallo reading the pushbutton status
 State_led_pump = digitalRead(led_pump);            // Pump reading the pushbutton status
 
 busca_falla();
    if (buttonState_inicio && falla==0 && !buttonState_paro ) digitalWrite(led_ciclo,HIGH );                
      
      if (buttonState_paro)   
      {
        digitalWrite(led_ciclo,LOW );               
        digitalWrite(led_pump,LOW );                  
      }
      
      if ( State_led_ciclo==HIGH && falla==0 )secuencia();   
      
      if (falla==1)
      {
        mostrar_falla();
      }
      else
      {
        digitalWrite(led_fallo,LOW );                  
      }
      delay(100);
 
    genera_flasheo();                               // Funcion envia flash 
    envia_datos();                                  // Funcion Envia Datos por puerto Serie 
}

 

