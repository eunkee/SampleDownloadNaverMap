using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDownloadNaverMap
{
    internal class RegistryDownloadNaverMap
    {
        public static RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\DownloadNaverMap", true);
        public static string ClientKey
        {
            get
            {
                string rslt = string.Empty;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToString(RegKey.GetValue("ClientKey", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("ClientKey", value);
                    }
                    catch { }
                }
            }
        }
        public static string ClientSecret
        {
            get
            {
                string rslt = string.Empty;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToString(RegKey.GetValue("ClientSecret", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("ClientSecret", value);
                    }
                    catch { }
                }
            }
        }
        public static string Latitude
        {
            get
            {
                string rslt = string.Empty;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToString(RegKey.GetValue("Latitude", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("Latitude", value);
                    }
                    catch { }
                }
            }
        }
        public static string Longitude
        {
            get
            {
                string rslt = string.Empty;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToString(RegKey.GetValue("Longitude", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("Longitude", value);
                    }
                    catch { }
                }
            }
        }
        public static int ImageWidth
        {
            get
            {
                int rslt = 600;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToInt32(RegKey.GetValue("ImageWidth", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("ImageWidth", value.ToString());
                    }
                    catch { }
                }
            }
        }
        public static int ImageHeight
        {
            get
            {
                int rslt = 600;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToInt32(RegKey.GetValue("ImageHeight", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("ImageHeight", value.ToString());
                    }
                    catch { }
                }
            }
        }
        public static int ZoomLevel
        {
            get
            {
                int rslt = 16;
                if (RegKey != null)
                {
                    try
                    {
                        rslt = Convert.ToInt32(RegKey.GetValue("ZoomLevel", rslt));
                    }
                    catch { }
                }
                return rslt;
            }
            set
            {
                if (RegKey != null)
                {
                    try
                    {
                        RegKey.SetValue("ZoomLevel", value.ToString());
                    }
                    catch { }
                }
            }
        }
    }
}
