# 4x4EvoLauncher
Simple 4x4Evolution launcher to circumvent the "Mystery Crash" from unhandled devices.

How to use:

1) Copy the executable file into your application folder where your game is installed (this can be used on any 4x4 Evolution games, including 1, 2, Revolution, or any other versions) (Program must be *RUN AS ADMINISTRATOR*

2) Find the device which is causing the game crash by opening your 'Device Manager' and disabling one 'HID-compliant vendor-defined device' at a time, until you find the culprit 
device. 

3) Once you find it, open the properties, go to 'Details' and copy the 'Class GUID', and the 'Device instance path'. 

4) Next, simply choose the executable file for your 4x4 Evolution game, and click 'Accept'. 


If everything is successful, then the main form will not appear again.

If for some reason there is an issue, and you need to *change* your disabled device (only one at a time, currently), open your game directory, and delete the "Settings.cfg" file 
associated with 4x4EvoLauncher.


For any other inquiries, or technical issues, please reach out to me, and I will try to help, or update the application as needed.





DISCLAIMER:
This program contains code which is open-source, and is not entirely my own. This is a very basic program made to disable and enable a single device. There is no warranty, nor guarantees associated with this software - use at your own risk.
