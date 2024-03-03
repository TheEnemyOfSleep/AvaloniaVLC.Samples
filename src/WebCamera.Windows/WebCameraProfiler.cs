using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Capture;

namespace WebCamera.Windows
{
    public static class WebCameraProfiler
    {
        public static async Task<string> GetVideoProfileSupportedDeviceIdAsync(Panel? panel = null)
        {
            string deviceId = string.Empty;
            // Finds all video capture devices
            DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(DeviceClass.VideoCapture);

            if (panel is not null)
            {
                foreach (var device in devices)
                {
                    // Check if the device on the requested panel supports Video Profile
                    if (MediaCapture.IsVideoProfileSupported(device.Id) && device.EnclosureLocation.Panel == panel)
                    {
                        // We've located a device that supports Video Profiles on expected panel
                        deviceId = device.Id;
                        break;
                    }
                }
            }

            return deviceId;
        }
    }
}
