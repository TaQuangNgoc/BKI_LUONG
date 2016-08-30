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

        public static bool checkPermission() {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            var v_checkKey = v_service.checkKey(mac);
            var v_checkTrial = v_service.checkTrial(mac);
            if (v_checkKey)
            {
                return false;
            }
            else if (v_checkTrial)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkKey() {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            return v_service.checkKey(mac);
        }

        public static bool activeKey(string company, string license)
        {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            return v_service.activeKey(mac, company, license);
        }

        public static bool checkMacTrial()
        {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            return v_service.checkMacTrial(mac);
        }

        public static bool activeTrial(string company, string email, string phone)
        {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            return v_service.activeTrial(mac, company, email, phone);
        }

        public static bool checkTrial()
        {
            LicenseManagerService.LicenseManager v_service = new LicenseManagerService.LicenseManager();
            var mac = ISCommon.getMac();
            return v_service.checkTrial(mac);
        }
    }
}
