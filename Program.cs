using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace patcher
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "dll files (*.dll)|*.dll";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(dialog.FileName);
                    byte[] search = new byte[] { 0x81, 0xCF, 0x00, 0x00, 0xCF, 0x00 };
                    byte[] replace = new byte[] { 0xBF, 0x00, 0x00, 0x08, 0x15, 0x90 };
                    int match = 0;
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        if (bytes[i] == search[match])
                        {
                            match++;
                            if (match == 6)
                            {
                                for (int j = 0; j < match; j++)
                                    bytes[i - match + j + 1] = replace[j];
                                break;
                            }
                        }
                        else
                            match = 0;
                    }
                    File.WriteAllBytes(dialog.FileName, bytes);
                    MessageBox.Show("patch successful");
                    return;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
