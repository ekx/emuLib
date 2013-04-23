using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emuLib.Libraries
{
    class RomManagementTools
    {
        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Please select a XML-File that contains a ROM Library";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gl.parseFromXmlFile(dialog.FileName);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] dirs = Directory.GetDirectories(dialog.SelectedPath);

                for (int i = 0; i < dirs.Length; i++)
                {
                    File.Move(Directory.GetFiles(dirs[i])[0], dirs[i] + "\\rom.sfc");
                }
            }*/

            /*string coverdir = "D:\\temp\\cover\\";
            string romdir = "D:\\temp\\roms\\";

            string[] covers = Directory.GetFiles(coverdir);

            for (int i = 0; i < covers.Length; i++)
            {
                File.Move(covers[i], romdir + covers[i].Substring(14, covers[i].Length - 18) + "\\cover.jpg");
            }*/

            /*string[] dirs = Directory.GetDirectories("D:\\temp\\roms\\");

            for (int i = 0; i < dirs.Length; i++)
            {
                File.Delete(dirs[i] + "\\cartridge.jpg");
            }*/

            /*string[] dirs = Directory.GetDirectories("D:\\temp\\roms\\");

            for (int i = 0; i < dirs.Length; i++)
            {
                File.Copy("D:\\temp\\desktop.ini", dirs[i] + "\\desktop.ini");
                File.SetAttributes(dirs[i] + "\\desktop.ini", FileAttributes.Hidden);
            }*/

            /*string coverdir = "D:\\temp\\manuals\\";
            string romdir = "D:\\temp\\roms\\";

            string[] covers = Directory.GetFiles(coverdir);

            for (int i = 0; i < covers.Length; i++)
            {              
                File.Move(covers[i], romdir + covers[i].Substring(16, covers[i].Length - 20) + "\\manual.pdf");
            }*/
        }
    }
}
