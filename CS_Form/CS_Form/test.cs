using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
   class TestButton:Button
    {
        //<summary>
        //コンストラクタ
        //クラスを生成した時に呼び出される
        public TestButton(int  x, int y,int Width,int Height)
        {
            //clickイベントにOnClick関数を登録
            //ボタンをクリックしたときに登録した関数を実行します
            Click += OnClick;

               Text = "ボタン";

            Location = new Point(x,y);

            Size = new Size(Width, Height);
        }
        //<summary>
        //ボタンをクリックした才の処理を記述する
        //＜/summary>
        
          

        public void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("明日");
        }
       
    }
}
