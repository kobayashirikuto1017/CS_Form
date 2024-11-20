using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        TestTextBox _textBox;
        /// <summary>
        /// コンストラクタ
        /// クラスを作成したときに呼び出される
        /// </summary>
        public TestButton(Form1 form1, int i, int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します
           
            Click += AnClick;
            
            //テキスト内にボタンを表示させる

            string[] nihongo = new string[10] { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ" };



            Text = nihongo[i];

            Location = new Point(x, y);

            Size = new Size(width, height);



        }


       
        
        public void AnClick(object sender , EventArgs s)
        {
            string currenButtonTest = Text;

            Text = _form1._textBox.Text;

            _form1._textBox.Text = currenButtonTest;

            _form1.LabelTextUpdate(currenButtonTest);

        }




       



    }
}