﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RedLine
{
    public partial class RedLine : Form
    {
        private const int MinHeight = 4;
        private const int MinWidth = 50;
        private const int BaseIntervalTime = 50;

        private Color mBackColor;
        private int mHeight;
        private int mWidth;
        private int mYPositionFromCursor;
        private int mXPositionFromCursor;
        private int mOpacity;
        private bool SettingsOpen = false;
        SettingsForm fSettings;
        private int mInterval = BaseIntervalTime;

        private SettingsControl programSettings;

        #region public RedLine()
        /// <summary>
        /// Constructor
        /// </summary>
        public RedLine()
        {
            InitializeComponent();
            LoadSettings();
            ProgramTimer.Enabled = true;
        } 
        #endregion

        #region private void LoadSettings()
        private void LoadSettings()
        {
            //Load Settings
            programSettings = new SettingsControl(Path.Combine(Application.StartupPath, @"RedLineSettings.xml"));
            programSettings.Load();

            ProgramTimer.Interval = mInterval;
            int a;
            try { a = int.Parse(programSettings.Settings.ColorA); } catch { a = 255; }
            int r;
            try { r = int.Parse(programSettings.Settings.ColorR); } catch { r = 255; }
            int g;
            try { g = int.Parse(programSettings.Settings.ColorG); } catch { g = 255; }
            int b;
            try { b = int.Parse(programSettings.Settings.ColorB); } catch { b = 255; }

            try { mHeight = int.Parse(programSettings.Settings.Height); } catch { mHeight = 4; }
            try { mWidth = int.Parse(programSettings.Settings.Width); } catch { mWidth = 1500; }

            try { mYPositionFromCursor = int.Parse(programSettings.Settings.YPos); } catch { mYPositionFromCursor = -15; }
            try { mXPositionFromCursor = int.Parse(programSettings.Settings.XPos); } catch { mXPositionFromCursor = 50; }

            try { mOpacity = int.Parse(programSettings.Settings.Opacity); } catch { mOpacity = 60; }

            mBackColor = Color.FromArgb(a, r, g, b);

        } 
        #endregion

        #region private void SaveSettings()
        private void SaveSettings()
        {
            programSettings.Settings.ColorA = mBackColor.A.ToString();
            programSettings.Settings.ColorR = mBackColor.R.ToString();
            programSettings.Settings.ColorG = mBackColor.G.ToString();
            programSettings.Settings.ColorB = mBackColor.B.ToString();

            programSettings.Settings.Height = mHeight.ToString();
            programSettings.Settings.Width = mWidth.ToString();

            programSettings.Settings.YPos = mYPositionFromCursor.ToString();
            programSettings.Settings.XPos = mXPositionFromCursor.ToString();

            programSettings.Settings.Opacity = mOpacity.ToString();
            programSettings.Save();
        } 
        #endregion

        #region private void ProgramTimer_Tick(object sender, EventArgs e)
        private void ProgramTimer_Tick(object sender, EventArgs e)
        {
            ProgramTimer.Enabled = false;
            if (SettingsOpen)
            {
                fSettings.MapSettingsToVars(ref mHeight, ref mWidth, ref mYPositionFromCursor, ref mXPositionFromCursor, ref mOpacity, ref mInterval, ref mBackColor);
            }
            else
            {
                mInterval = BaseIntervalTime;
            }

            ProgramTimer.Interval = mInterval;
            this.Opacity = mOpacity / 100.0;
            this.BackColor = mBackColor;
            this.Height = mHeight;
            this.Width = mWidth;
            //mXPositionFromCursor = -(mWidth / 2);
            //this.Left = Cursor.Position.X + mXPositionFromCursor;
            this.Left = Cursor.Position.X - (int)((double)mWidth * (double)mXPositionFromCursor / 100.0);
            if (mYPositionFromCursor == 0) { mYPositionFromCursor = 1; }
            if (mYPositionFromCursor < 0)
            {
                this.Top = Cursor.Position.Y - this.Height + mYPositionFromCursor;
            }
            else
            {
                this.Top = Cursor.Position.Y + mYPositionFromCursor;
            }
            if (SettingsOpen)
            {
                fSettings.MapVarsToSettings(mHeight, mWidth, mYPositionFromCursor, mXPositionFromCursor, mOpacity, mInterval, mBackColor);
            }
            ProgramTimer.Enabled = true;
        } 
        #endregion

        #region private void TrayMenuExit_Click(object sender, EventArgs e)
        private void TrayMenuExit_Click(object sender, EventArgs e)
        {
            ProgramTimer.Enabled = false;
            this.Close();
        } 
        #endregion

        #region private void RedLine_KeyDown(object sender, KeyEventArgs e)
        private void RedLine_KeyDown(object sender, KeyEventArgs e)
        {
            int Boost = 0;
            if (e.Shift) { Boost = 10; }

            // if alt key pressed
            if (e.Alt)
            {
                ProgramTimer.Enabled = false;
                switch (e.KeyCode)
                {
                    case Keys.X:
                        ProgramTimer.Enabled = false;
                        CloseProgram();
                        break;
                    case Keys.Up:
                        mHeight += (2 + Boost);
                        break;
                    case Keys.Right:
                        mWidth += (5 + Boost);
                        break;
                    case Keys.Down:
                        mHeight -= (2 + Boost);
                        if (mHeight < MinHeight) { mHeight = MinHeight; }
                        break;
                    case Keys.Left:
                        mWidth -= (5 + Boost);
                        if (mWidth < MinWidth) { mWidth = MinWidth; }
                        break;

                }
                ProgramTimer.Enabled = true;
            }
        } 
        #endregion

        #region private void CloseProgram()
        private void CloseProgram()
        {
            SaveSettings();
            this.Close();
        } 
        #endregion

        #region private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSettings = new SettingsForm(MinHeight, MinWidth, mInterval);
            fSettings.MapVarsToSettings(mHeight, mWidth, mYPositionFromCursor, mXPositionFromCursor, mOpacity, mInterval, mBackColor);
            SettingsOpen = true;
            ProgramTimer.Interval = 800;
            fSettings.ShowDialog();
            SaveSettings();
            ProgramTimer.Interval = BaseIntervalTime;
            SettingsOpen = false;
        } 
        #endregion
    }
}