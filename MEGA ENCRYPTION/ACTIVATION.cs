using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    [Table("Activation")]
    public class ACTIVATION
    {
        public ACTIVATION() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("VALUE")]
        public string VALUE { get; set; }

        [Column("ADDRESS")]
        public string ADDRESS { get; set; }




        public static bool 活性化(string 価値)
        {
            var ディック = 密码.加载();

            using (var デシベル = new データベース())
            {
                try
                {
                    var 鍵 = デシベル.Activation.FirstOrDefault(x => x.VALUE == 価値.编码器());
                    if (鍵 == null)
                    {
                        new MessageInvalidKey().ShowDialog();
                        return false;
                    }

                    if (!string.IsNullOrEmpty(鍵.ADDRESS))
                    {
                        new MessageExpired().ShowDialog();
                        return false;
                    }

                    PROCESS.인쇄();
                    鍵.ADDRESS = PROCESS.주소();
                    デシベル.SaveChanges();

                    キーの作成();
                    new MessageActivated().ShowDialog();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }




        public static bool アクティベーションのチェック()
        {
            using (var デシベル = new データベース())
            {
                try
                {
                    var 住所 = PROCESS.주소();
                    var 鍵 = デシベル.Activation.FirstOrDefault(x => x.ADDRESS == 住所);

                    if (鍵 == null)
                        return false;

                    PROCESS.인쇄();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }




        private static void キーの作成()
        {
            const string 文字 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var ランダム = new Random();
            var 結果 = new string(Enumerable.Range(1, 12)
                                               .Select(_ => 文字[ランダム.Next(文字.Length)])
                                               .ToArray());

            var ディック = 密码.加载();
            using (var デシベル = new データベース())
            {
                try
                {
                    var アクティベーション = new ACTIVATION();
                    アクティベーション.VALUE = 結果.编码器();
                    デシベル.Activation.Add(アクティベーション);
                    デシベル.SaveChanges();
                }
                catch (Exception) { }
            }
        }
    }
}
