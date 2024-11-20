using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
     public class TestTextBox : TextBox
    {

        TestButton testButton;

        Form1 _form1;
        /// <summary>
        /// コンストラクタ
        /// クラスを作成したときに呼び出される
        /// </summary>
        public TestTextBox(string str, int x, int y, int width, int height)
        {
            


            //ラベル内にボタンを表示させる
            Text = str;

            //ボタンの生成場所を確認
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, height);

            
        }





       
        
        //③ボタンの内容をテキストボックスの中に入れる
        public void TextUpdete(string str)
        {
            Text = str;
        }
       

    }
}
