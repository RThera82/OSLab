using System;
using System.Management;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create a new ManagementEventWatcher that listens for Win32_DeviceChangeEvent
        ManagementEventWatcher watcher = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2"));

        // Loop to continuously check for device connection events
        while (true)
        {
            ManagementBaseObject eventObj = watcher.WaitForNextEvent();
            string eventType = eventObj.GetPropertyValue("EventType").ToString();

            // If the event type is "2" (device arrival), launch Paint
            if (eventType != "2")
            {
                // Start the Paint process
                Process.Start("mspaint.exe");

                // Wait for a short time before checking for more events (adjust based on system response time)
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
