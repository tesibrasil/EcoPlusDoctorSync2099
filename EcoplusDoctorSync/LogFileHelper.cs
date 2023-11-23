using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoplusDoctorSync
{
    class LogFileHelper
    {
        private static LogFileHelper m_ctrl = new LogFileHelper();
        public static LogFileHelper Get() { return m_ctrl; }

        public void Write(string strLog, TextBox txtLog)
        {
            Console.WriteLine(strLog);
            // Debug.WriteLine(strLog);

            //

            System.DateTime dateTimeNow = System.DateTime.Now;

            string strFilename = String.Format("{0:d4}{1:d2}{2:d2}.log",
                                            dateTimeNow.Year,
                                            dateTimeNow.Month,
                                            dateTimeNow.Day);

            /* string strDate = String.Format("{0:d4}-{1:d2}-{2:d2} {3:d2}.{4:d2}.{5:d2} - ",
                                            dateTimeNow.Year,
                                            dateTimeNow.Month,
                                            dateTimeNow.Day,
                                            dateTimeNow.Hour,
                                            dateTimeNow.Minute,
                                            dateTimeNow.Second); */

            string strDate = String.Format("{0:d2}.{1:d2}.{2:d2} - ",
                                            dateTimeNow.Hour,
                                            dateTimeNow.Minute,
                                            dateTimeNow.Second);

            try
            {
                StreamWriter stream = File.AppendText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\" + strFilename);
                stream.WriteLine(strDate + strLog);
                stream.Close();
            }
            catch (Exception)
            {
            }

            // Sandro 31/01/2017 //

            if (strLog.Length > 0)
            {
                txtLog.Text += strLog + "\r\n";
                txtLog.SelectionStart = txtLog.TextLength;
                txtLog.ScrollToCaret();
            }
        }
    }
}
