using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

// Class for XML file serialization for program settings
// Class structures are particular to the project
//
// (c) INFOMAN, INC. 2021
//
namespace RedLine
{

    // The class structure/relationships determine structure of the XML file.  
    // Child objects = child branches

    #region public class Settings
    /// <summary>
    /// Top level branch of the XML file
    /// </summary>
    public class Settings
    {

        [XmlAttribute("ColorA")]
        public string ColorA { get; set; }
        [XmlAttribute("ColorR")]
        public string ColorR { get; set; }
        [XmlAttribute("ColorG")]
        public string ColorG { get; set; }
        [XmlAttribute("ColorB")]
        public string ColorB { get; set; }

        [XmlAttribute("Height")]
        public string Height { get; set; }
        [XmlAttribute("Width")]
        public string Width { get; set; }

        [XmlAttribute("YPos")]
        public string YPos { get; set; }
        [XmlAttribute("XPos")]
        public string XPos { get; set; }

        [XmlAttribute("Opacity")]
        public string Opacity { get; set; }

    }
    #endregion



    /// <summary>
    /// Interface between the program and file system.  Handles read and write of data between disk and RAM
    /// </summary>
    public class SettingsControl
    {
        Settings mSettings;
        string FileName;
        XmlSerializer xmls = new XmlSerializer(typeof(Settings));

        #region private void Initialize()
        private void Initialize()
        {
            mSettings.ColorA = "255";
            mSettings.ColorR = "255";
            mSettings.ColorG = "0";
            mSettings.ColorB = "0";

            mSettings.Height = "4";
            mSettings.Width = "1500";

            mSettings.YPos = "-15";
            mSettings.XPos = "50";

            mSettings.Opacity = "60";
        }
        #endregion

        #region public Settings Settings
        /// <summary>
        /// Constructor
        /// </summary>
        public Settings Settings
        {
            get { return mSettings; }
            set { mSettings = value; }
        }
        #endregion

        #region public SettingsControl(string File_Name)
        /// <summary>
        /// Set up Settings object
        /// </summary>
        /// <param name="File_Name">XML file name to store settings</param>
        public SettingsControl(string File_Name)
        {
            FileName = File_Name;
            mSettings = new Settings();
            Initialize();
        }
        #endregion

        #region public void Load()
        /// <summary>
        /// Load Settings from XML file
        /// </summary>
        public void Load()
        {
            try
            {
                TextReader reader = new StreamReader(FileName);
                object obj = xmls.Deserialize(reader);
                reader.Close();
                mSettings = (Settings)obj;
            }
            catch (System.IO.FileNotFoundException)
            {
                Save();
            }
        }
        #endregion

        #region public void Save()
        /// <summary>
        /// Save settings to XML file
        /// </summary>
        public void Save()
        {
            using (TextWriter writer = new StreamWriter(FileName))
            {
                xmls.Serialize(writer, mSettings);
                writer.Close();
            }
        }
        #endregion



    }
}



