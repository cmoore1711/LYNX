#Colin Moore
#10/12/17
# 4X MAX 31856 TC modules
# 1 RasPi 3B+ board


# Global Imports
import logging
import time
import Adafruit_GPIO

import os

import datetime
import glob
import MySQLdb
from time import strftime

# Local Imports
from Adafruit_MAX31856 import MAX31856 as MAX31856

#logging.basicConfig(filename='simpletest.log', level=logging.DEBUG, format='%(asctime)s - %(name)s - %(levelname)s - %(message)s')
#_logger = logging.getLogger(__name__)

# Uncomment one of the blocks of code below to configure your Pi to use software or hardware SPI.

## Raspberry Pi software SPI configuration.
tc0Pins = {"clk": 14, "cs": 23, "do": 18, "di": 15}
tc0 = MAX31856(software_spi=tc0Pins)
tc1Pins = {"clk": 14, "cs": 23, "do": 18, "di": 15}
tc1 = MAX31856(software_spi=tc1Pins)
tc2Pins = {"clk": 14, "cs": 23, "do": 18, "di": 15}
tc2 = MAX31856(software_spi=tc2Pins)
tc3Pins = {"clk": 14, "cs": 23, "do": 18, "di": 15}
tc3 = MAX31856(software_spi=tc3Pins)


# Loop printing measurements every second.
print('Press Ctrl-C to quit.')
while True:
datetimeWrite = (time.strftime("%Y-%m-%d ") + time.strftime("%H:%M:%S"))
    
    
    
    
    
    temp0E = tc0.read_temp_c()
    temp1E = tc1.read_temp_c()
    temp2E = tc2.read_temp_c()
    temp3E = tc3.read_temp_c()
    
    temp0I = tc0.read_internal_temp_c()
    temp1I = tc1.read_internal_temp_c()
    temp2I = tc2.read_internal_temp_c()
    temp3I = tc3.read_internal_temp_c()
    
    #internal = sensor.read_internal_temp_c()
    print('Thermocouple 0 Temperature: {0:0.3F}*C'.format(temp0E))
    print('Thermocouple 0 Internal Temperature: {0:0.3F}*C'.format(temp0I))
    print('Thermocouple 0 Temperature: {0:0.3F}*C'.format(temp01E))
    print('Thermocouple 0 Internal Temperature: {0:0.3F}*C'.format(temp1I))
    print('Thermocouple 0 Temperature: {0:0.3F}*C'.format(temp2E))
    print('Thermocouple 0 Internal Temperature: {0:0.3F}*C'.format(temp2I))
    print('Thermocouple 0 Temperature: {0:0.3F}*C'.format(temp3E))
    print('Thermocouple 0 Internal Temperature: {0:0.3F}*C'.format(temp3I))
                     
                     
                     try:
        db = MySQLdb.connect(host="SAXIREINTERN1", user="admin",passwd="admin", db="diamond_turning")
        cur = db.cursor()
        sql = ("""INSERT INTO temperature_data (machine,datetime,t0,t1,t2,t3,deployed,User) VALUES (%s,%s,%f,%f,%f,%f,%t,%t)""",("N704",datetimeWrite,temp0E,temp1E,temp2E,temp3E,"N","Colin"))
                 
                 
    
        #  print "Writing to database..."
        # Execute the SQL command
        cur.execute(*sql)
        # Commit your changes in the database
        db.commit()
        # print "Write Complete"
    except:
        #  print "Unable to commit"
        
cur.close()
db.close()
    time.sleep(1.0)

