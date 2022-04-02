using RobotControl.Serial;
using System;
using System.IO;
using System.Windows.Forms;

namespace RobotControl.Macros
{
    public class MacroControls
    {
        private Macro loadedMacro;
        private readonly SerialInterface _interface;


        public MacroControls(SerialInterface iface)
        {
            _interface = iface;
            loadedMacro = null;
        }

        public void OpenFile()
        {
            var fileContent = string.Empty;
            using OpenFileDialog openFileDialog = new();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                loadedMacro = new Macro(fileContent);
            }
        }

        public void PlayMacro()
        {
            if (loadedMacro is null) return;

            foreach(var command in loadedMacro.instructions)
            {
                _interface.SendCommand(command);
            }
        }
    }
}
