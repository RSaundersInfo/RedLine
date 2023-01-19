using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedLine
{
    public partial class SettingsForm : Form
    {
        private readonly int mBaseInterval;
        private int mCurrInterval;
        private Color mCurrColor;

        #region public SettingsForm(int minHeight, int minWidth, int baseInterval)
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="minHeight">Minumum height</param>
        /// <param name="minWidth">Minimum width</param>
        /// <param name="baseInterval">Base refresh interval when form is closed</param>
        public SettingsForm(int minHeight, int minWidth, int baseInterval)
        {
            InitializeComponent();

            mBaseInterval = baseInterval;

            this.NOpacity.Minimum = 5;
            this.NOpacity.Maximum = 100;

            this.NHeight.Minimum = minHeight;
            this.NHeight.Maximum = 5000;

            this.NWidth.Minimum = minWidth;
            this.NWidth.Maximum = 5000;

            this.NYPosFromCursor.Minimum = -200;
            this.NYPosFromCursor.Maximum = 200;

            this.NXPosFromCursor.Minimum = -10;
            this.NXPosFromCursor.Maximum = 110;

        }
        #endregion

        #region private void CloseButton_Click(object sender, EventArgs e)
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region public void MapVarsToSettings(int height, int width, int yDistanceFromCursor, int xCenterDistanceFromCursor, int opacity, int interval, Color color)
        /// <summary>
        /// Map passed variables to form controls
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="yDistanceFromCursor"></param>
        /// <param name="xCenterDistanceFromCursor"></param>
        /// <param name="opacity"></param>
        /// <param name="interval"></param>
        /// <param name="color"></param>
        public void MapVarsToSettings(int height, int width, int yDistanceFromCursor, int xCenterDistanceFromCursor, int opacity, int interval, Color color)
        {
            mCurrInterval = interval;
            mCurrColor = color;
            this.NHeight.Value = height;
            this.NWidth.Value = width;
            this.NYPosFromCursor.Value = yDistanceFromCursor;
            this.NXPosFromCursor.Value = xCenterDistanceFromCursor;
            this.NOpacity.Value = opacity;
            this.ColorLabel.BackColor = color;
        }
        #endregion

        #region public void MapSettingsToVars(ref int height, ref int width, ref int yDistanceFromCursor, ref int xCenterDistanceFromCursor, ref int opacity, ref int interval, ref Color color)
        /// <summary>
        /// Map control values to passed variables
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="yDistanceFromCursor"></param>
        /// <param name="xCenterDistanceFromCursor"></param>
        /// <param name="opacity"></param>
        /// <param name="interval"></param>
        /// <param name="color"></param>
        public void MapSettingsToVars(ref int height, ref int width, ref int yDistanceFromCursor, ref int xCenterDistanceFromCursor, ref int opacity, ref int interval, ref Color color)
        {
            interval = mCurrInterval;
            height = (int)this.NHeight.Value;
            width = (int)this.NWidth.Value;
            yDistanceFromCursor = (int)this.NYPosFromCursor.Value;
            xCenterDistanceFromCursor = (int)this.NXPosFromCursor.Value;
            opacity = (int)this.NOpacity.Value;
            color = this.ColorLabel.BackColor;
        }
        #endregion


        #region private void ControlHasFocus(object sender, EventArgs e)
        private void ControlHasFocus(object sender, EventArgs e)
        {
            mCurrInterval = 700;
        }
        #endregion

        #region private void ControlLostFocus(object sender, EventArgs e)
        private void ControlLostFocus(object sender, EventArgs e)
        {
            mCurrInterval = mBaseInterval;
        }
        #endregion

        #region private void SelectColorButton_Click(object sender, EventArgs e)
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorPicker.Color = mCurrColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                mCurrColor = ColorPicker.Color;
                this.ColorLabel.BackColor = mCurrColor;
            }
        } 
        #endregion
    }
}
