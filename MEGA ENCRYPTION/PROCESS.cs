using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    public sealed class PROCESS
    {
        public static string 프로세서()
        {
            var 수색자 = new ManagementObjectSearcher("select ProcessorId from Win32_Processor");
            var 수집 = 수색자.Get();
            foreach (var 안건 in 수집)
                return 안건["ProcessorId"].ToString();
            return "";
        }


        public static string 마더보드()
        {
            var 수색자 = new ManagementObjectSearcher("select SerialNumber from Win32_BaseBoard");
            var 수집 = 수색자.Get();
            foreach (var 안건 in 수집)
                return 안건["SerialNumber"].ToString();
            return "";
        }


        public static string 주소()
        {
            var 프로세스 = 프로세서();
            var 모보 = 마더보드();
            var 연속물 = 프로세스 + 모보;
            var 안녕하세요 = new StringBuilder();
            for (int 나 = 0; 나 < 3; 나++)
                안녕하세요.Append(연속물);
            return 안녕하세요.ToString();
        }




        public static void 인쇄()
        {
            try
            {
                var 길 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "address.mp3");

                var 안녕하세요 = 주소();

                using (var 작가 = new StreamWriter(길))
                    작가.WriteLine(안녕하세요);
            }
            catch (Exception) { }
        }




        public static bool 리더()
        {
            try
            {
                var 길 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "address.mp3");

                if (!File.Exists(길))
                    return false;

                var 파일 = File.ReadAllText(길).TrimEnd('\r', '\n');
                var 안녕하세요 = 주소();

                if (파일 != 안녕하세요)
                    return false;

                return true;
            }
            catch (Exception) { return false; }
        }


    }
}
