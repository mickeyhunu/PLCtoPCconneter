using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace PLCtoPCexample
{
    public partial class FormPLC : Form
    {
        int DataRead1 = 0;
        int DataRead2 = 0;
        int DataRead3 = 0;
        int DataRead4 = 0;
        int DataRead5 = 0;
        int DataRead6 = 0;

        bool readcontinuous = false;

        ActUtlType ActUtilType;

        public FormPLC()
        {
            InitializeComponent();
        }

        private void FormPLC_Load(object sender, EventArgs e)
        {
            Connect.Enabled = true;
            Disconnect.Enabled = false;
            Exe.Enabled = false;
            ReadData.Enabled = false;
            DataReset.Enabled = false;

            radioButton1.Checked = true;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ActUtilType = new ActUtlType();
            // ActUtilType.ActLogicalStationNumber값은 MX Component에서 설정한 Station 번호입니다
            ActUtilType.ActLogicalStationNumber = 0;
            // 리턴값이 "0"이면 PLC 연결 성공
            int nRtn = ActUtilType.Open();

            if (nRtn == 0)
            {
                EventMemo.Text = "PLC 접속 성공";
                Timer.Enabled = true;
                Timer.Interval = 100;

                Connect.Enabled = false;
                Disconnect.Enabled = true;
                Exe.Enabled = true;
                ReadData.Enabled = true;
                DataReset.Enabled = true;
            }
            else
            {
                EventMemo.Text = "PLC 접속 실패";

                Connect.Enabled = true;
                Disconnect.Enabled = false;
                Exe.Enabled = false;
                ReadData.Enabled = false;
                DataReset.Enabled = false;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            int nRtn = ActUtilType.Close();

            if (nRtn == 0)
                EventMemo.Text = "PLC 접속 해제";

            Connect.Enabled = true;
            Disconnect.Enabled = false;
            Exe.Enabled = false;
            ReadData.Enabled = false;
            DataReset.Enabled = false;
        }

        private void Exe_Click(object sender, EventArgs e)
        {
            int plcData = 0;
            // 스위치 "M1"의 값 Read

            ActUtilType.GetDevice("M1", out plcData);

            if (plcData == 0)
            {
                Exe.BackColor = Color.Lime;
                ActUtilType.SetDevice("M1", 1);
                EventMemo.Text = "스위치 켜짐";
            }
            else
            {
                Exe.BackColor = Color.Transparent;
                ActUtilType.SetDevice("M1", 0);
                EventMemo.Text = "스위치 꺼짐";
            }
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            readPLC();
        }

        private void DataReset_Click(object sender, EventArgs e)
        {
            ActUtilType.SetDevice("D0", DataRead1 = 0);
            ActUtilType.SetDevice("D1", DataRead2 = 0);
            ActUtilType.SetDevice("D2", DataRead3 = 0);
            ActUtilType.SetDevice("D3", DataRead4 = 0);
            ActUtilType.SetDevice("D4", DataRead5 = 0);
            ActUtilType.SetDevice("D5", DataRead6 = 0);

            D0.Text = DataRead1.ToString();
            D1.Text = DataRead2.ToString();
            D2.Text = DataRead3.ToString();
            D3.Text = DataRead4.ToString();
            D4.Text = DataRead5.ToString();
            D5.Text = DataRead6.ToString();
        }

        private void readPLC()
        {
            ActUtilType.GetDevice("D0", out DataRead1);
            ActUtilType.GetDevice("D1", out DataRead2);
            ActUtilType.GetDevice("D2", out DataRead3);
            ActUtilType.GetDevice("D3", out DataRead4);
            ActUtilType.GetDevice("D4", out DataRead5);
            ActUtilType.GetDevice("D5", out DataRead6);

            D0.Text = DataRead1.ToString();
            D1.Text = DataRead2.ToString();
            D2.Text = DataRead3.ToString();
            D3.Text = DataRead4.ToString();
            D4.Text = DataRead5.ToString();
            D5.Text = DataRead6.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!readcontinuous)
                return;

            readPLC();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                readcontinuous = true;
                EventMemo.Text = "연속 읽기모드";
            }
            else if (radioButton2.Checked)
            {
                readcontinuous = false;
                EventMemo.Text = "클릭 읽기모드";
            }
        }
    }
}
