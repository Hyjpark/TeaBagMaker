using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic; 

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        String[] teaList = { "홍차", "녹차", "루이보스차", "국화차" };
        String tStr = "";

        int Count = 0; //초기 카운턴

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teaList.Length; i++) {
                this.cbTea.Items.Add(teaList[i]); //콤보 박스에 메뉴 추가
            }
            cbTea.SelectedItem = teaList[0];          
        }

        private void CbTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTea.SelectedIndex)
            {
                case 0: //홍차
                    this.tStr = "2분";
                    break;
                case 1: //녹차
                    this.tStr = "3분";
                    break;
                case 2: //루이보스차
                    this.tStr = "5분";
                    break;
                case 3: //국화차
                    this.tStr = "2분";
                    break;
            }
            this.lblTime.Text = "시간 : " + this.tStr;
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
