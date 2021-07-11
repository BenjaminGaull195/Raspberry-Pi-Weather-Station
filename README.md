# Raspberry-Pi-Weather-Station

## Description

Raspberry Pi Weather Station is a Modular framework that allows users to add weather station functionality to their projects.  it is written using Microsofts .Net5 and will later be transitioned to .Net6.  

A simple interface is provided for users to add their own sensors to the project.  Customs sensors must implement the Sensor class or one of it's derived classes as well as at least one of the provided interfaces.  These custom sensors can be implemented in their own class libraries.  The WeatherStation class registers these custom sensors through the use of Regression, by scanning for all classes that implement the Sensor class in all of the Assemblies located in the Sensors directory.  

During initialization of the WeatherStation class, a JSON config file is read.  This file contains all of the relevant information about what sensors are connected, what data those sensors read, calibration information for those sensors, and some optional runtime specific configuration reguarding the sample rate and threading behavior of the WeatherStation class.  When this config file is read, it will search for the specified sensors, if it finds the sensors, then those sensors are registered to the Weather Station, otherwise an exception will be thrown.

### Sensor Types
Here are the sensor types that are currently supported:
- Temperature
- Pressure
- Humidity
- Wind Vane
- Anemometer
- UV sensor
- Air Quality

Each sensor uses a bitmask to track what 

### Versions:




## Raspberry Pi Hats:

This project also provides some sample PCB designs and schematics that others can use when making their weather station enclosure.

