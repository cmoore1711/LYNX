

#include <WiFi101.h>
#include <MySQL_Connection.h>
#include <MySQL_Cursor.h>
#include <Wire.h>
#include <Adafruit_MAX31856.h>
//#include "Adafruit_TMP007.h"

//Adafruit_TMP007 tmp007;
// Use software SPI: CS, DI, DO, CLK
Adafruit_MAX31856 TC0 = Adafruit_MAX31856(10, 11, 12, 13);
Adafruit_MAX31856 TC1 = Adafruit_MAX31856(9, 11, 12, 13);
Adafruit_MAX31856 TC2 = Adafruit_MAX31856(6, 11, 12, 13);
//Adafruit_MAX31856 TC4 = Adafruit_MAX31856(10, 11, 12, 13);



byte mac_addr[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };

//IPAddress server_addr(192,168,4,102);  // IP of the MySQL *server* here
IPAddress server_addr(192,168,1,146);  // IP of the MySQL *server* here
char user[] = "admin";              // MySQL user login username
char password[] = "admin";        // MySQL user login password

WiFiClient client;            // Use this for WiFi instead of EthernetClient
MySQL_Connection conn((Client *)&client);

// Sample query
String insert_sql = "INSERT INTO diamond_turning.lynx_704_daq (datetime, tc0, tc0i, tc1,tc1i,tc2,tc2i,tc3,tc3i,isDeployed,faultLog,RSSI) VALUES (";


char ssid[] = "SunTest";     //  your network SSID (name)
char pass[] = "jankcode";  // your network password
int status = WL_IDLE_STATUS;     // the WiFi radio's status








void setup() {
//////////////////// Important line below
     WiFi.setPins(8,7,4,2);

 Serial.begin(115200);
Serial.println("Initializing...");
 
 TC0.begin();

  TC0.setThermocoupleType(MAX31856_TCTYPE_K);
 TC1.setThermocoupleType(MAX31856_TCTYPE_K);
  TC2.setThermocoupleType(MAX31856_TCTYPE_K);
  //TC3.setThermocoupleType(MAX31856_TCTYPE_K);
// Begin WiFi section
bool isconwifi = false;
while (isconwifi ==false){
  int status = WiFi.begin(ssid, pass);
  if ( status != WL_CONNECTED) {
    Serial.println("Couldn't get a wifi connection");
  }
  // print out info about the connection:
  else {
    isconwifi =true;
    Serial.println("Connected to network");
    IPAddress ip = WiFi.localIP();
    Serial.print("My IP address is: ");
    Serial.println(ip);
  }
}
  // End WiFi section

  // you're connected now, so print out the data:
  Serial.print("Connection information: ");
  printCurrentNet();
  printWiFiData();


  bool iscondb = false;
  while(iscondb == false){
Serial.println("Connecting...");

  if (conn.connect(server_addr, 3306, user, password)) {
    delay(1000);
    Serial.println("Connected to server!");
 iscondb = true;
  }
  else
    Serial.println("Connection failed. Are you on the same WiFi network as the server?");
     Serial.println("Retrying connection.");
     delay(1000);
  

}
}
void loop() {

double tc0= TC0.readThermocoupleTemperature()*(9/5)+32;
double tc0i= TC0.readCJTemperature()*(9/5)+32;

double tc1= TC1.readThermocoupleTemperature()*(9/5)+32;
double tc1i= TC1.readCJTemperature()*(9/5)+32;

double tc2= TC2.readThermocoupleTemperature()*(9/5)+32;
double tc2i= TC2.readCJTemperature()*(9/5)+32;


//keep below as TC2 until CC3 is deployed
double tc3= TC2.readThermocoupleTemperature()*(9/5)+32;
double tc3i= TC2.readCJTemperature()*(9/5)+32;
  Serial.print("Cold Junction Temp: "); Serial.println(TC0.readCJTemperature()*(9/5)+32);

  Serial.print("Thermocouple Temp: "); Serial.println(TC0.readThermocoupleTemperature()*(9/5)+32);
  // Check and print any faults

  String faultS ="";
  uint8_t fault = TC0.readFault();

  //add more if this is helpful, otherwise, keep just TC0
  if (fault) {
    if (fault & MAX31856_FAULT_CJRANGE) faultS += "\"Cold Junction Range Fault \"";
    if (fault & MAX31856_FAULT_TCRANGE) faultS += "\"Thermocouple Range Fault \"" ;
    if (fault & MAX31856_FAULT_CJHIGH)  faultS += "\"Cold Junction High Fault \"";
    if (fault & MAX31856_FAULT_CJLOW)  faultS += "\"Cold Junction Low Fault \"";
    if (fault & MAX31856_FAULT_TCHIGH) faultS += "\"Thermocouple High Fault \"";
    if (fault & MAX31856_FAULT_TCLOW)  faultS += "\"Thermocouple Low Fault \"";
    if (fault & MAX31856_FAULT_OVUV)   faultS += "\"Over/Under Voltage Fault \"";
    if (fault & MAX31856_FAULT_OPEN)    faultS += "\"Thermocouple Open Fault \"";
  }





  
     String insert_sql_final = insert_sql;
     insert_sql_final+="NOW()";
     insert_sql_final+=",";
       insert_sql_final+=String(tc0);
         insert_sql_final+=",";
           insert_sql_final+=String(tc0i);
         insert_sql_final+=",";

        insert_sql_final+=String(tc1);
         insert_sql_final+=",";
           insert_sql_final+=String(tc1i);
         insert_sql_final+=",";

         insert_sql_final+=String(tc2);
         insert_sql_final+=",";
           insert_sql_final+=String(tc2i);
         insert_sql_final+=",";

         insert_sql_final+=String(tc3);
         insert_sql_final+=",";
           insert_sql_final+=String(tc3i);
         insert_sql_final+=",";


     insert_sql_final+="1";
         insert_sql_final+=",";

              insert_sql_final+=faultS;
         insert_sql_final+=",";


         
     insert_sql_final+=String(2*(WiFi.RSSI()+100));
     insert_sql_final+=")";

     Serial.println(insert_sql_final);
     int str_len = insert_sql_final.length() + 1;
     char char_array[str_len];
     insert_sql_final.toCharArray(char_array, str_len);
// Initiate the query class instance
  MySQL_Cursor *cur_mem = new MySQL_Cursor(&conn);
  // Execute the query
  cur_mem->execute(char_array);
  // Note: since there are no results, we do not need to read any data
  // Deleting the cursor also frees up memory used
  delete cur_mem;


   
  // check the network connection once every 10 seconds:
  delay(2000);
  
 // printCurrentNet();
}
void printWiFiData() {
  // print your WiFi shield's IP address:
  IPAddress ip = WiFi.localIP();
  Serial.print("IP Address: ");
  Serial.println(ip);
  Serial.println(ip);

  // print your MAC address:
  byte mac[6];
  WiFi.macAddress(mac);
  Serial.print("MAC address: ");
  Serial.print(mac[5], HEX);
  Serial.print(":");
  Serial.print(mac[4], HEX);
  Serial.print(":");
  Serial.print(mac[3], HEX);
  Serial.print(":");
  Serial.print(mac[2], HEX);
  Serial.print(":");
  Serial.print(mac[1], HEX);
  Serial.print(":");
  Serial.println(mac[0], HEX);

}

void printCurrentNet() {
  // print the SSID of the network you're attached to:
  Serial.print("SSID: ");
  Serial.println(WiFi.SSID());

  // print the MAC address of the router you're attached to:
  byte bssid[6];
  WiFi.BSSID(bssid);
  Serial.print("BSSID: ");
  Serial.print(bssid[5], HEX);
  Serial.print(":");
  Serial.print(bssid[4], HEX);
  Serial.print(":");
  Serial.print(bssid[3], HEX);
  Serial.print(":");
  Serial.print(bssid[2], HEX);
  Serial.print(":");
  Serial.print(bssid[1], HEX);
  Serial.print(":");
  Serial.println(bssid[0], HEX);

  // print the received signal strength:
  long rssi = WiFi.RSSI();
  Serial.print("signal strength (RSSI):");
  Serial.println(rssi);

  // print the encryption type:
  byte encryption = WiFi.encryptionType();
  Serial.print("Encryption Type:");
  Serial.println(encryption, HEX);
  Serial.println();
}


