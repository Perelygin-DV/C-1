
namespace HW7_1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbRes = new System.Windows.Forms.Label();
			this.btnRef = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbRes
			// 
			this.lbRes.AutoSize = true;
			this.lbRes.Location = new System.Drawing.Point(451, 143);
			this.lbRes.Name = "lbRes";
			this.lbRes.Size = new System.Drawing.Size(35, 13);
			this.lbRes.TabIndex = 0;
			this.lbRes.Text = "label1";
			// 
			// btnRef
			// 
			this.btnRef.Location = new System.Drawing.Point(146, 129);
			this.btnRef.Name = "btnRef";
			this.btnRef.Size = new System.Drawing.Size(75, 23);
			this.btnRef.TabIndex = 1;
			this.btnRef.Text = "Refres";
			this.btnRef.UseVisualStyleBackColor = true;
			this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(146, 179);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnRef);
			this.Controls.Add(this.lbRes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbRes;
		private System.Windows.Forms.Button btnRef;
		private System.Windows.Forms.ListBox listBox1;
	}
}

