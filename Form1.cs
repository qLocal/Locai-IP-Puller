using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Locai
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Button_Click(object sender, EventArgs e)
		{
            int counter = 0;
            string line;
            string appDataFolder = Environment.GetEnvironmentVariable("LocalAppData");
            string filePath = Path.Combine(appDataFolder, "Roblox\\logs");
            DirectoryInfo info = new DirectoryInfo(filePath);
            FileInfo[] files = info.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
            foreach (FileInfo fil in files)
            {
                if (Convert.ToString(fil).Contains("GameStartScript"))
                {
                    filePath = Path.Combine(filePath, Convert.ToString(fil));
                    break;
                }
            }

            foreach (string file in Directory.EnumerateFiles(filePath, "*.log"))
            {


                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string singleLine in lines)
                {
                    if (singleLine.Contains("Connecting to"))
                    {
                        int full = singleLine.IndexOf("to") + 2;
                        string ipandPort = singleLine.Substring(full);
                        string shortenedIp = ipandPort.Substring(0, ipandPort.Length - 6);
                        int portindex = singleLine.IndexOf("to") + 18;
                        string portpiece = singleLine.Substring(portindex);
                        ServerPort.Text = portpiece;
                        ServerIp.Text = shortenedIp;
                        return;
                    }
                }


            }
        }

		private void ServerPort_TextChanged(object sender, EventArgs e)
		{

		}

		private void ServerIp_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
