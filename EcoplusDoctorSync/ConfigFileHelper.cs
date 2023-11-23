using System.Runtime.InteropServices;
using System.Text;

namespace EcoplusDoctorSync
{
    class ConfigFileHelper
    {
        private string m_sCfgFilePath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileInt(string section, string key, int def, string filePath);

        public ConfigFileHelper(string sCfgFilePath)
        {
            m_sCfgFilePath = sCfgFilePath;
        }

        public void WriteValue(string sSection, string sKey, string sValue)
        {
            WritePrivateProfileString(sSection, sKey, sValue, m_sCfgFilePath);
        }

        public bool ReadValue(string sSection, string sKey, bool bDef)
        {
            bool bReturn = (GetPrivateProfileInt(sSection, sKey, bDef == false ? 0 : 1, m_sCfgFilePath) == 0 ? false : true);

            if (bReturn == bDef)
                WriteValue(sSection, sKey, (bDef == false ? 0 : 1).ToString());

            return bReturn;
        }

        public int ReadValue(string sSection, string sKey, int iDef)
        {
            int iReturn = GetPrivateProfileInt(sSection, sKey, iDef, m_sCfgFilePath);

            if (iReturn == iDef)
                WriteValue(sSection, sKey, iDef.ToString());

            return iReturn;
        }

        public string ReadValue(string sSection, string sKey, string sDef)
        {
            StringBuilder sbTemp = new StringBuilder(255);
            GetPrivateProfileString(sSection, sKey, sDef, sbTemp, 255, m_sCfgFilePath);

            string sReturn = sbTemp.ToString();
            if (sReturn == sDef)
                WriteValue(sSection, sKey, sDef);

            return sReturn;
        }

    }
}
