/******************************************************************************
*                                                                             *
*   PROJECT : Eos Digital camera Software Development Kit EDSDK               *
*                                                                             *
*   Description: This is the Sample code to show the usage of EDSDK.          *
*                                                                             *
*                                                                             *
*******************************************************************************
*                                                                             *
*   Written and developed by Canon Inc.                                       *
*   Copyright Canon Inc. 2018 All Rights Reserved                             *
*                                                                             *
*******************************************************************************/


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Windows.Forms;


namespace CameraControl
{

    public partial class FocusBractingSetting : Form
    {
        CameraController _controller = null;
        IntPtr _camera = (IntPtr)0;

        const uint _Version = 1;
        uint _FocusShiftFunction;
        uint _FocusShiftFunctiongPrev;
        uint _ShootingNumber;
        uint _ShootingNumberPrev;
        uint _StepWidth;
        uint _StepWidthPrev;
        uint _ExposureSmoothing;
        uint _ExposureSmoothingPrev;

        // FocusShiftFunction
        protected Dictionary<uint, string> map1 = new Dictionary<uint, string>();
        protected Dictionary<uint, string> map2 = new Dictionary<uint, string>();

        // StepWidth
        protected int[] ary = Enumerable.Range(1, 10).ToArray();

        protected EDSDKLib.EDSDK.FocusShiftSetting _fssData;

        public FocusBractingSetting(ref CameraController controller)
        {
            _controller = controller;
            _camera = _controller.GetModel().Camera;

            InitializeComponent();

            // FocusShiftFunction
            this.focusBracketingComboBox.Items.Clear();

            focusBracketingComboBox.Items.Add("Disable");
            focusBracketingComboBox.Items.Add("Enable");

            // ExposureSmoothing
            exposureSmoothingComboBox.Items.Add("Disable");
            exposureSmoothingComboBox.Items.Add("Enable");

            // FocusIncrement
            this.focusIncrementComboBox.Items.Clear();
            for (int i = 0; i < ary.Length; i++)
                focusIncrementComboBox.Items.Add(ary[i]);

            uint err = EDSDKLib.EDSDK.EdsGetPropertyData(_camera, EDSDKLib.EDSDK.PropID_FocusShiftSetting, 0, out _fssData);

            if (err == EDSDKLib.EDSDK.EDS_ERR_OK)
            {
                _FocusShiftFunctiongPrev = _fssData.FocusShiftFunction;
                _ShootingNumberPrev = _fssData.ShootingNumber;
                _StepWidthPrev = _fssData.StepWidth;
                _ExposureSmoothingPrev = _fssData.ExposureSmoothing;
            }

            // Select item of combo box
            focusBracketingComboBox.SelectedIndex = (int)_FocusShiftFunctiongPrev;
            exposureSmoothingComboBox.SelectedIndex = (int)_ExposureSmoothingPrev;
            focusIncrementComboBox.SelectedIndex = (int)_StepWidthPrev - 1;
            textBoxShtNum.Text = _ShootingNumberPrev.ToString();
        }


        private void FocusBractingSetting_Load(object sender, EventArgs e)

        {
            _fssData.Version = _Version;
            _fssData.FocusShiftFunction = 0x00;
            _fssData.ShootingNumber = 0x00;
            _fssData.StepWidth = 0x00;
            _fssData.ExposureSmoothing = 0x00;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string strShotNum = "";
            strShotNum = textBoxShtNum.Text;
            try
            {
                int _shootingNumber = Int32.Parse(strShotNum);

                if (isFrom2to999(_shootingNumber))
                {

                    _FocusShiftFunction = (uint)focusBracketingComboBox.SelectedIndex;
                    _ShootingNumber = (uint)_shootingNumber;
                    _StepWidth = (uint)focusIncrementComboBox.SelectedIndex + 1;
                    _ExposureSmoothing = (uint)exposureSmoothingComboBox.SelectedIndex;

                    _fssData.FocusShiftFunction = _FocusShiftFunction;
                    _fssData.ShootingNumber = _ShootingNumber;
                    _fssData.StepWidth = _StepWidth;
                    _fssData.ExposureSmoothing = _ExposureSmoothing;

                    int dataSize = Marshal.SizeOf(typeof(EDSDKLib.EDSDK.FocusShiftSetting));
                    uint err = EDSDKLib.EDSDK.EdsSetPropertyData(_camera, EDSDKLib.EDSDK.PropID_FocusShiftSetting, 0, dataSize, _fssData);

                }
                else
                {
                    MessageBox.Show("Please enter a number from 2 to 999 in the Number of shots field.");
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Please enter a number from 2 to 999 in the Number of shots field.");
                this.DialogResult = DialogResult.None;
            }

        }

        public bool isFrom2to999(int num)
        {
            if (num >= 2 && num <= 999)
            {
                return true;
            }
            return false;
        }
    }
}
