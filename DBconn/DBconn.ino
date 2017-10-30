

#include <WiFi101.h>
#include <MySQL_Connection.h>
#include <MySQL_Cursor.h>
#include <Wire.h>
//#include "Adafruit_TMP007.h"

//Adafruit_TMP007 tmp007;


byte mac_addr[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };

//IPAddress server_addr(192,168,4,102);  // IP of the MySQL *server* here
IPAddress server_addr(192,168,1,146);  // IP of the MySQL *server* here
char user[] = "admin";              // MySQL user login username
char password[] = "admin";        // MySQL user login password

WiFiClient client;            // Use this for WiFi instead of EthernetClient
MySQL_Connection conn((Client *)&client);

// Sample query
String insert_sql = "INSERT INTO siox.temperature_data (datetime, temperatureC, temperaturef, signalstrength) VALUES (";


char ssid[] = "SunTest";     //  your network SSID (name)
char pass[] = "jankcode";  // your network password
int status = WL_IDLE_STATUS;     // the WiFi radio's status



void setup() {
//////////////////// Important line below
     WiFi.setPins(8,7,4,2);

  Serial.begin(9600);
  while(!Serial);

  
Serial.println("Initializing contactless thermopile...");
 // if (! tmp007.begin()) {
 //   Serial.println("No sensor found. Searching...");
 //   while (1);
 // }else{
 //   Serial.println("Sensor found.");
//  }


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
void loop() {
Serial.println("loop");

/*
   double tempInC = tmp007.readObjTempC();
   double tempInF = tempInC *1.8 +32;
   if (isnan(tempInC)) {
     Serial.println("Something wrong with thermocouple!");
   } else {
     Serial.print("F = "); 
     Serial.println(tempInF);
     String insert_sql_final = insert_sql;
     insert_sql_final+="NOW()";
     insert_sql_final+=",";
       insert_sql_final+=String(tempInC);
         insert_sql_final+=",";
           insert_sql_final+=String(tempInF);
         insert_sql_final+=",";
     insert_sql_final+=String(WiFi.RSSI());
     insert_sql_final+=",)";
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


   }
  // check the network connection once every 10 seconds:
  delay(4000);
  
  printCurrentNet();
}

*/

}

