namespace Chisl3._4._Runge_Kutt
{
    partial class FormMain
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
            this.cbEquation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudX0 = new System.Windows.Forms.NumericUpDown();
            this.jhk = new System.Windows.Forms.GroupBox();
            this.nudY0 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudX0)).BeginInit();
            this.jhk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEquation
            // 
            this.cbEquation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEquation.FormattingEnabled = true;
            this.cbEquation.Items.AddRange(new object[] {
            "y\'=x+y",
            "y\'=x^2+3y",
            "y\' = sin(x)+5y^3"});
            this.cbEquation.Location = new System.Drawing.Point(24, 32);
            this.cbEquation.Name = "cbEquation";
            this.cbEquation.Size = new System.Drawing.Size(270, 28);
            this.cbEquation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уравнение: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x0=a=";
            // 
            // nudX0
            // 
            this.nudX0.DecimalPlaces = 3;
            this.nudX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudX0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudX0.Location = new System.Drawing.Point(135, 30);
            this.nudX0.Name = "nudX0";
            this.nudX0.Size = new System.Drawing.Size(120, 23);
            this.nudX0.TabIndex = 3;
            this.nudX0.ValueChanged += new System.EventHandler(this.nudX0_ValueChanged);
            // 
            // jhk
            // 
            this.jhk.Controls.Add(this.label4);
            this.jhk.Controls.Add(this.nudY0);
            this.jhk.Controls.Add(this.label5);
            this.jhk.Controls.Add(this.lbl);
            this.jhk.Controls.Add(this.nudH);
            this.jhk.Controls.Add(this.nudB);
            this.jhk.Controls.Add(this.label3);
            this.jhk.Controls.Add(this.nudX0);
            this.jhk.Controls.Add(this.label2);
            this.jhk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jhk.Location = new System.Drawing.Point(24, 66);
            this.jhk.Name = "jhk";
            this.jhk.Size = new System.Drawing.Size(270, 183);
            this.jhk.TabIndex = 4;
            this.jhk.TabStop = false;
            this.jhk.Text = "Задача Коши:";
            // 
            // nudY0
            // 
            this.nudY0.DecimalPlaces = 3;
            this.nudY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudY0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudY0.Location = new System.Drawing.Point(135, 102);
            this.nudY0.Name = "nudY0";
            this.nudY0.Size = new System.Drawing.Size(120, 23);
            this.nudY0.TabIndex = 9;
            this.nudY0.ValueChanged += new System.EventHandler(this.nudY0_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "y0=";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl.Location = new System.Drawing.Point(9, 142);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 17);
            this.lbl.TabIndex = 7;
            // 
            // nudH
            // 
            this.nudH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudH.Location = new System.Drawing.Point(135, 140);
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(120, 23);
            this.nudH.TabIndex = 5;
            this.nudH.ValueChanged += new System.EventHandler(this.nudH_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 3;
            this.nudB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudB.Location = new System.Drawing.Point(135, 68);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 23);
            this.nudB.TabIndex = 6;
            this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "b=";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSolution.Location = new System.Drawing.Point(21, 269);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(0, 17);
            this.lblSolution.TabIndex = 8;
            // 
            // btnTask
            // 
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTask.Location = new System.Drawing.Point(119, 361);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(95, 26);
            this.btnTask.TabIndex = 9;
            this.btnTask.Text = "Выполнить";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во шагов:";
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
            this.dgv_output.AllowUserToDeleteRows = false;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.ColumnHeadersVisible = false;
            this.dgv_output.Location = new System.Drawing.Point(24, 269);
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.ReadOnly = true;
            this.dgv_output.Size = new System.Drawing.Size(270, 77);
            this.dgv_output.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 399);
            this.Controls.Add(this.dgv_output);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.jhk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEquation);
            this.Name = "FormMain";
            this.Text = "Метод Рунге-Кутта";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudX0)).EndInit();
            this.jhk.ResumeLayout(false);
            this.jhk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudX0;
        private System.Windows.Forms.GroupBox jhk;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.NumericUpDown nudY0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_output;
    }
}

