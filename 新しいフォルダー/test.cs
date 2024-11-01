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
        /// <summary>
        /// コンストラクタ
        /// クラスを作成したときに呼び出される
        /// </summary>
        public TestButton(int id, int x, int y, int width, int height)
        {
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
            MessageBox.Show(Text);
        }
    }
}