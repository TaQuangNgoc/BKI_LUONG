using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;


namespace ISCommon
{
    public class ISCommon
    {
        public static string getMac()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            var adapter = nics[0];
            IPInterfaceProperties properties = adapter.GetIPProperties();
            PhysicalAddress address = adapter.GetPhysicalAddress();
            byte[] bytes = address.GetAddressBytes();
            string v_mac = String.Empty;
            for (int i = 0; i < bytes.Length; i++)
            {
                v_mac += bytes[i].ToString("X2");
                if (i != bytes.Length - 1)
                {
                    v_mac += "-";
                }
            }

            return v_mac;
        }
    }
}
