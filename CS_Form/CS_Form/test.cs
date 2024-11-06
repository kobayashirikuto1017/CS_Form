﻿using System;
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

        /// <summary>
        /// コンストラクタ
        /// クラスを作成したときに呼び出される
        /// </summary>
        public TestButton(Form1 form1,int id, int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します
            Click += OnClick;

            //テキスト内にボタンを表示させる
            Text = id.ToString();

            Location = new Point(x, y);

            Size = new Size(width, height);

        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text); 
        }
    }
}