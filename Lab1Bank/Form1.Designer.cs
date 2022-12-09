namespace Lab1Bank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SerrialiseButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(834, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(899, 29);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(194, 40);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(898, 94);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(202, 43);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(13, 404);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(57, 55);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1088, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Розпочати/Закінчити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SerrialiseButton
            // 
            this.SerrialiseButton.Location = new System.Drawing.Point(167, 358);
            this.SerrialiseButton.Name = "SerrialiseButton";
            this.SerrialiseButton.Size = new System.Drawing.Size(94, 55);
            this.SerrialiseButton.TabIndex = 6;
            this.SerrialiseButton.Text = "Зберігти зміни";
            this.SerrialiseButton.UseVisualStyleBackColor = true;
            this.SerrialiseButton.Click += new System.EventHandler(this.SerrialiseButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(291, 358);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(110, 57);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Завантажити дані з файлу";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 471);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SerrialiseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddButton;
        private Button DeleteButton;
        private Button InfoButton;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button1;
        private Button SerrialiseButton;
        private Button LoadButton;
    }
}