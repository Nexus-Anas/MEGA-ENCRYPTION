using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    public static class 密码
    {
        public static IDictionary<string, string> 加载()
        {
            var 迪克 = new Dictionary<string, string>();
            var 小路 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dic.bin");
            using (var 读者 = new BinaryReader(File.Open(小路, FileMode.Open)))
            {
                int 数数 = 读者.ReadInt32();
                for (int 我 = 0; 我 < 数数; 我++)
                    迪克.Add(读者.ReadString(), 读者.ReadString());
            }
            return 迪克;
        }

        public static string 编码器(this string 文本)
        {
            var 数数 = 加载();
            var 密文 = new StringBuilder(string.Empty);
            for (int 我 = 0; 我 < 文本.Length; 我++)
                密文.Append(文本[我] + "|");

            foreach (var 物品 in 数数.Keys)
                密文.Replace(物品, 数数[物品]);

            密文.Replace("|", ".").Remove(密文.Length - 1, 1);
            return 密文.ToString();
        }






        /////////////////////////////////////Encryption///////////////////////////////////////////

        private static byte[] _美国广播公司;
        private static byte[,] _桌子;

        public static void 加密(string 小路, string 密码)
        {
            //Init abc and table
            _美国广播公司 = new byte[256];
            for (int 我 = 0; 我 < 256; 我++)
                _美国广播公司[我] = Convert.ToByte(我);

            _桌子 = new byte[256, 256];
            for (int 我 = 0; 我 < 256; 我++)
                for (int 升 = 0; 升 < 256; 升++)
                    _桌子[我, 升] = _美国广播公司[(我 + 升) % 256];

            try
            {
                var 文件内容 = File.ReadAllBytes(小路);
                var 速度 = Encoding.ASCII.GetBytes(密码);
                var 钥匙 = new byte[文件内容.Length];
                var 结果 = new byte[文件内容.Length];
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                    钥匙[我] = 速度[我 % 速度.Length];

                //Encrypt
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                {
                    var 价值 = 文件内容[我];
                    var 我的钥匙 = 钥匙[我];
                    int 价值指数 = -1, 关键字索引 = -1;
                    for (int 升 = 0; 升 < 256; 升++)
                        if (_美国广播公司[升] == 价值)
                        {
                            价值指数 = 升;
                            break;
                        }
                    for (int 升 = 0; 升 < 256; 升++)
                        if (_美国广播公司[升] == 我的钥匙)
                        {
                            关键字索引 = 升;
                            break;
                        }
                    结果[我] = _桌子[关键字索引, 价值指数];
                }

                //save result to new file with the same extention
                var 延伸 = Path.GetExtension(小路);
                var 姓名 = Path.GetFileName(小路);
                var 节省 = new SaveFileDialog();
                节省.Filter = "Files (*" + 延伸 + ") | *" + 延伸;
                节省.FileName = "Enc " + 姓名;
                if (节省.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(节省.FileName, 结果);
                    new MessageEnc().ShowDialog();
                }
            }
            catch (Exception) { new MessageFileInUse().ShowDialog(); }
        }




        public static void 解密(string 小路, string 密码)
        {
            //Init abc and table
            _美国广播公司 = new byte[256];
            for (int 我 = 0; 我 < 256; 我++)
                _美国广播公司[我] = Convert.ToByte(我);

            _桌子 = new byte[256, 256];
            for (int 我 = 0; 我 < 256; 我++)
                for (int 升 = 0; 升 < 256; 升++)
                    _桌子[我, 升] = _美国广播公司[(我 + 升) % 256];

            try
            {
                var 文件内容 = File.ReadAllBytes(小路);
                var 速度 = Encoding.ASCII.GetBytes(密码);
                var 钥匙 = new byte[文件内容.Length];
                var 结果 = new byte[文件内容.Length];
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                    钥匙[我] = 速度[我 % 速度.Length];

                //Decrypt
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                {
                    var 价值 = 文件内容[我];
                    var 我的钥匙 = 钥匙[我];
                    int 价值指数 = -1, 关键字索引 = -1;
                    for (int 升 = 0; 升 < 256; 升++)
                        if (_美国广播公司[升] == 我的钥匙)
                        {
                            关键字索引 = 升;
                            break;
                        }
                    for (int j = 0; j < 256; j++)
                        if (_桌子[关键字索引, j] == 价值)
                        {
                            价值指数 = j;
                            break;
                        }
                    结果[我] = _美国广播公司[价值指数];
                }


                //save result to new file with the same extention
                var 延伸 = Path.GetExtension(小路);
                var 姓名 = Path.GetFileName(小路);
                var 节省 = new SaveFileDialog();
                节省.Filter = "Files (*" + 延伸 + ") | *" + 延伸;
                节省.FileName = "Dec " + 姓名;
                if (节省.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(节省.FileName, 结果);
                    new MessageDec().ShowDialog();
                }
            }
            catch (Exception) { new MessageFileInUse().ShowDialog(); }
        }




        public static string 德康()
        {
            var 小路 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.dll");
            string 密码 = "0009000900090009";
            // Init abc and table
            _美国广播公司 = new byte[256];
            for (int 我 = 0; 我 < 256; 我++)
                _美国广播公司[我] = Convert.ToByte(我);

            _桌子 = new byte[256, 256];
            for (int 我 = 0; 我 < 256; 我++)
                for (int 升 = 0; 升 < 256; 升++)
                    _桌子[我, 升] = _美国广播公司[(我 + 升) % 256];

            try
            {
                var 文件内容 = File.ReadAllBytes(小路);
                var 速度 = Encoding.ASCII.GetBytes(密码);
                var 钥匙 = new byte[文件内容.Length];
                var 结果 = new byte[文件内容.Length];
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                    钥匙[我] = 速度[我 % 速度.Length];

                // Decrypt
                for (int 我 = 0; 我 < 文件内容.Length; 我++)
                {
                    var 价值 = 文件内容[我];
                    var 我的钥匙 = 钥匙[我];
                    int 价值指数 = -1, 关键字索引 = -1;
                    for (int j = 0; j < 256; j++)
                        if (_美国广播公司[j] == 我的钥匙)
                        {
                            关键字索引 = j;
                            break;
                        }
                    for (int j = 0; j < 256; j++)
                        if (_桌子[关键字索引, j] == 价值)
                        {
                            价值指数 = j;
                            break;
                        }
                    结果[我] = _美国广播公司[价值指数];
                }

                // Return decrypted text as string
                return Encoding.ASCII.GetString(结果);
            }
            catch (Exception) { new MessageFileInUse().ShowDialog(); }

            return null;
        }

        //////////////////////////////////////////////////////////////////////////////////////////

    }
}
