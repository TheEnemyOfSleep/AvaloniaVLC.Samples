using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;

namespace WebCamera.Windows
{
    public class WebCameraProfiler
    {
        public async Task<string> GetVideoProfileSupportedDeviceIdAsync()
        {
            string deviceId = null;

            // Finds all video capture devices
            DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(DeviceClass.VideoCapture);

            return deviceId;
        }
    }
}
