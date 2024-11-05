using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace Zaber
{
    public class GetComPort
    {

        public static string device;
        public static string portString;

        public string DeviceFinder() {

            portString = null;

        ManagementClass processClass = new ManagementClass("Win32_PnPEntity");

        ManagementObjectCollection Ports = processClass.GetInstances();
        device = "Not recognized";

        portString = "";

            foreach (ManagementObject property in Ports)
            {
                if (property.GetPropertyValue("Name") != null)
                    if (property.GetPropertyValue("Name").ToString().Contains("USB Serial Port") && property.GetPropertyValue("Name").ToString().Contains("COM"))
                    {
                        device = property.GetPropertyValue("Name").ToString();

                        break;
                    }
            }
            
            portString = "COM" + device.Substring(device.Length - 2, 1);

            //Test connection to port and stage status.
            Boolean stageOK = false;

            System.IO.Ports.SerialPort com = null;

            //Test whether there is a com port available.
            try
            {
                com = new System.IO.Ports.SerialPort(portString, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                com.Open();

                System.Threading.Thread.Sleep(50);

                com.Close();

                //wait for port to close from above
                System.Threading.Thread.Sleep(50);

                stageOK = true;

            }
            catch
            {
	    	 
                stageOK = false;
            }

            if (stageOK = true)
            {
                try
                {
			 
                    if (GetStatus(portString) == "OK" ){
					 
				    //add variable output for whether status is ok
                    }
                }
                catch
                {
			 
                }
            }











            return portString;
        } 

        



        private string GetStatus(string portString)
        {
            System.IO.Ports.SerialPort com = null;
            //com = new System.IO.Ports.SerialPort(ComPort, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            com = new System.IO.Ports.SerialPort(portString, 115200, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

            //Set some timeouts so it doesn't wait forever if something goes wrong
            com.WriteTimeout = 1000;
            com.ReadTimeout = 1000;

            int data = 0; // Just some dummy Data
            int command = 54;
            string StatusString;

            //The com port exists.  Now we need to see if we can communicate with stage on this port.  We will ask for the Status
            try
            {
                com.Open();
                com.WriteTimeout = 1000;
                com.ReadTimeout = 1000;

                // Break the data into bytes and send the command
                byte[] bytes = System.BitConverter.GetBytes((uint)data);
                com.Write(new byte[] { 1, (byte)command, bytes[0], bytes[1], bytes[2], bytes[3] }, 0, 6);

                // Wait a while if 6 bytes (a full command) is not available to read yet, this can be a while
                // as responces for moves are not sent untill the final position is reached.
                const int WAIT = 3; // Wait time in seconds
                for (int i = 0; i < WAIT * 100 && com.BytesToRead < 6; i++)
                    System.Threading.Thread.Sleep(12);
              
                com.Close(); // Make sure to remember to close!
                return "OK";
            }


            catch
            {
                com.Close(); // NEEED TO CLOSE THIS IF A ERROR READING/WRITING HAPPENS !!! VERY IMPORTANT.  Otherwise it could crash.
                return "Error Reading/Writing To Slide";
            }
        }


        public void MoveTo(double position, double speed)
        {
            const double MMPS_TO_SPEED = 825.6504;
            const double MM_TO_POS = 503.9370;

            // Calcualte the speed value and set the speed
            int stage_speed = (int)System.Math.Round(speed * MMPS_TO_SPEED);
            SendCMD(42, stage_speed);

            // Calculate the stage position and move the stage
            int stage_pos = (int)System.Math.Round(position * MM_TO_POS);
            SendCMD(20, stage_pos);



        }





        public int SendCMD(int command, int data)
        {


            /*
	Sends a command to the Zaber linear stage, waits for the response, and returns the data value
	given in the response. See http://www.zaber.com/wiki/Manuals/Binary_Protocol_Manual for
	commands and error codes.
*/

            // Setup communications port
            System.IO.Ports.SerialPort com = null;
            try
            {
                com = new System.IO.Ports.SerialPort(portString, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                com.Open();
            }
            catch (Exception e)
            {
    
                return -1;
            }

            // Break the data into bytes and send the command
            byte[] bytes = System.BitConverter.GetBytes((uint)data);
            com.Write(new byte[] { 1, (byte)command, bytes[0], bytes[1], bytes[2], bytes[3] }, 0, 6);

            // Wait a while if 6 bytes (a full command) is not available to read yet, this can be a while
            // as responces for moves are not sent untill the final position is reached.
            const int WAIT = 30; // Wait time in seconds
            for (int i = 0; i < WAIT * 100 && com.BytesToRead < 6; i++)
                System.Threading.Thread.Sleep(10);


            // Read the response and close the port
            byte[] buffer = new Byte[6];
            int bytesRead = com.Read(buffer, 0, 6);
            com.Close();

            if (bytesRead < 6)
            {
            }// If not enough byes were read, report error

            else if (buffer[1] == 255)
            {
            }// If linear stage is indicating an error, report it


            else if (buffer[1] == (byte)command)
            { // If the command received is the expected response, return the data value
                return (int)System.BitConverter.ToUInt32(buffer, 2);
            }



            return -1; // Return failure value

        }




    }
}
