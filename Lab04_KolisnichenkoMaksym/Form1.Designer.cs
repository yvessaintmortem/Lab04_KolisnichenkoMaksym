
namespace Lab04_KolisnichenkoMaksym
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKEYLength = new System.Windows.Forms.Label();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.labelFIleWithKeyLength = new System.Windows.Forms.Label();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(590, 70);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(40, 30);
            this.button_fileOUT.TabIndex = 5;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(590, 31);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(40, 30);
            this.button_fileIN.TabIndex = 4;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(170, 71);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(414, 29);
            this.textBox_fileOUT.TabIndex = 3;
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(170, 32);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(414, 29);
            this.textBox_fileIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKEYLength);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Controls.Add(this.button_KEYgenerator);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // labelKEYLength
            // 
            this.labelKEYLength.AutoSize = true;
            this.labelKEYLength.Location = new System.Drawing.Point(33, 54);
            this.labelKEYLength.Name = "labelKEYLength";
            this.labelKEYLength.Size = new System.Drawing.Size(123, 21);
            this.labelKEYLength.TabIndex = 5;
            this.labelKEYLength.Text = "Розмір ключа:";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_KEYgenerator.Image = global::Lab04_KolisnichenkoMaksym.Properties.Resources.ic_vpn_key_128_28771;
            this.button_KEYgenerator.Location = new System.Drawing.Point(293, 57);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(104, 30);
            this.button_KEYgenerator.TabIndex = 2;
            this.button_KEYgenerator.UseVisualStyleBackColor = true;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click);
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(170, 23);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(326, 29);
            this.textBox_fileKEY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл з ключем:";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(538, 255);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(104, 30);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тривалість шифрування (мин, сек, мс)";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(337, 260);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(81, 21);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:00:000";
            // 
            // labelFIleWithKeyLength
            // 
            this.labelFIleWithKeyLength.AutoSize = true;
            this.labelFIleWithKeyLength.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelFIleWithKeyLength.Location = new System.Drawing.Point(45, 295);
            this.labelFIleWithKeyLength.Name = "labelFIleWithKeyLength";
            this.labelFIleWithKeyLength.Size = new System.Drawing.Size(200, 21);
            this.labelFIleWithKeyLength.TabIndex = 5;
            this.labelFIleWithKeyLength.Text = "Розмір файла з ключем:";
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileKEYsave.Image = global::Lab04_KolisnichenkoMaksym.Properties.Resources.Open;
            this.button_fileKEYsave.Location = new System.Drawing.Point(502, 23);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(61, 52);
            this.button_fileKEYsave.TabIndex = 4;
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileKEYopen.Image = global::Lab04_KolisnichenkoMaksym.Properties.Resources.Save;
            this.button_fileKEYopen.Location = new System.Drawing.Point(569, 23);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(61, 52);
            this.button_fileKEYopen.TabIndex = 3;
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 335);
            this.Controls.Add(this.labelFIleWithKeyLength);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 374);
            this.MinimumSize = new System.Drawing.Size(690, 374);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XOR файл";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label labelKEYLength;
        private System.Windows.Forms.Label labelFIleWithKeyLength;
    }
}

