
namespace Locai
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Button = new System.Windows.Forms.Button();
			this.ServerIp = new System.Windows.Forms.TextBox();
			this.ServerPort = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-9, -33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(381, 258);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Button
			// 
			this.Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button.Location = new System.Drawing.Point(102, 148);
			this.Button.Name = "Button";
			this.Button.Size = new System.Drawing.Size(148, 35);
			this.Button.TabIndex = 2;
			this.Button.Text = "Retrieve Server IP";
			this.Button.UseVisualStyleBackColor = false;
			this.Button.Click += new System.EventHandler(this.Button_Click);
			// 
			// ServerIp
			// 
			this.ServerIp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ServerIp.Location = new System.Drawing.Point(12, 12);
			this.ServerIp.Name = "ServerIp";
			this.ServerIp.Size = new System.Drawing.Size(131, 20);
			this.ServerIp.TabIndex = 3;
			this.ServerIp.Text = "Server IP: Nil";
			this.ServerIp.TextChanged += new System.EventHandler(this.ServerIp_TextChanged);
			// 
			// ServerPort
			// 
			this.ServerPort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ServerPort.Location = new System.Drawing.Point(203, 12);
			this.ServerPort.Name = "ServerPort";
			this.ServerPort.Size = new System.Drawing.Size(131, 20);
			this.ServerPort.TabIndex = 4;
			this.ServerPort.Text = "Server Port: NIL";
			this.ServerPort.TextChanged += new System.EventHandler(this.ServerPort_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(346, 214);
			this.Controls.Add(this.ServerPort);
			this.Controls.Add(this.ServerIp);
			this.Controls.Add(this.Button);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server IP Puller";
			this.TransparencyKey = System.Drawing.Color.Black;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Button;
		private System.Windows.Forms.TextBox ServerIp;
		private System.Windows.Forms.TextBox ServerPort;
	}
}

