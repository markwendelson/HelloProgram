namespace HelloCSharp
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
            this.components = new System.ComponentModel.Container();
            this.cmdHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHello
            // 
            this.cmdHello.Location = new System.Drawing.Point(261, 166);
            this.cmdHello.Name = "cmdHello";
            this.cmdHello.Size = new System.Drawing.Size(129, 47);
            this.cmdHello.TabIndex = 5;
            this.cmdHello.Text = "Say hello";
            this.cmdHello.UseVisualStyleBackColor = true;
            this.cmdHello.Click += new System.EventHandler(this.cmdHello_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtName.Location = new System.Drawing.Point(50, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 30);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Green;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Label1.Size = new System.Drawing.Size(448, 61);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Enter your name:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 244);
            this.Controls.Add(this.cmdHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdHello;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ErrorProvider ErrorProvider1;
        public System.Windows.Forms.TextBox txtName;
    }
}

