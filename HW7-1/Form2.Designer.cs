
namespace HW7_1
{
	partial class Form2
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
			this.txtBoxCh = new System.Windows.Forms.TextBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBoxCh
			// 
			this.txtBoxCh.Location = new System.Drawing.Point(201, 150);
			this.txtBoxCh.Name = "txtBoxCh";
			this.txtBoxCh.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCh.TabIndex = 0;
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.Blue;
			this.btnChange.Location = new System.Drawing.Point(213, 213);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 1;
			this.btnChange.Text = "Изменить!";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.txtBoxCh);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxCh;
		private System.Windows.Forms.Button btnChange;
	}
}