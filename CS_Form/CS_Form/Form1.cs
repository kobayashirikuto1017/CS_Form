using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        public   TestTextBox _textBox;

        TestButton _testButton;

        public Form1()
        {
           

            

            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                

                TestButton testButton = new TestButton(this, i, (i % 5) * 100, (i / 5) * 100, 100, 100);
               
                //ボタンの追加
                Controls.Add(testButton);

            }
            //ラベルの作成
            _testLabel   = new TestLabel("ラベルです", 10, 300, 100, 500);

            //ラベルの追加
            Controls.Add((_testLabel));

            _textBox = new TestTextBox("テキストボックスです",10,250,100,700);


            if(_testButton != null)
            {
                _testButton.Click += AnClick;
            }
            




            Controls.Add(_textBox);
           // Label label = new Label();
            //label.Location = new Point(30, 400);
           // label.Text = "ラベルです";
           // Control.Add(label);
        }
        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        /// 
        //①ボタンの内容をラベルに入れる
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdete(str);
        }
        
        public void BoxTextUpdate (string str)
        {
             _textBox.TextUpdete(str);  
        }
        private void AnClick(object sendar , EventArgs e)
        {
            _testButton.Text = _textBox.Text;
        }
       

        

       


       


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
