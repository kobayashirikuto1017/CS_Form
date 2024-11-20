using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace CS_Form 
{
    class TestLabel : Label
    {
        /// <summary>
        /// コンストラクタ
        /// クラスを作成したときに呼び出される
        /// </summary>
        public TestLabel(string str, int x, int y, int width, int height)
        {
           

            //ラベル内にボタンを表示させる
            Text = str;

            //ボタンの生成場所を確認
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, height);

        }
       /// <summary>
       /// ラベルの文字更新関数
       /// </summary>
       /// <param name="str"></param>
       public void TextUpdete(string str)
        {
            Text = str;
        }

        
    }
}
