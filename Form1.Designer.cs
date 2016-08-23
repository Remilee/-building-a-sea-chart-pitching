namespace Диаграмма_построения_качки
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
            this.tBLambda = new System.Windows.Forms.TextBox();
            this.labelLambda = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPhi = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDraft = new System.Windows.Forms.Label();
            this.labelMetHeight = new System.Windows.Forms.Label();
            this.tBV = new System.Windows.Forms.TextBox();
            this.tBPhi = new System.Windows.Forms.TextBox();
            this.tBB = new System.Windows.Forms.TextBox();
            this.tBT = new System.Windows.Forms.TextBox();
            this.tBMH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttOk = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResultVar = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBLambda
            // 
            this.tBLambda.Location = new System.Drawing.Point(208, 53);
            this.tBLambda.Name = "tBLambda";
            this.tBLambda.Size = new System.Drawing.Size(100, 20);
            this.tBLambda.TabIndex = 0;
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(12, 56);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(89, 13);
            this.labelLambda.TabIndex = 1;
            this.labelLambda.Text = "Длина волны, м";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 80);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(123, 13);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Скорость корабля, узл";
            // 
            // labelPhi
            // 
            this.labelPhi.AutoSize = true;
            this.labelPhi.Location = new System.Drawing.Point(12, 107);
            this.labelPhi.Name = "labelPhi";
            this.labelPhi.Size = new System.Drawing.Size(109, 13);
            this.labelPhi.TabIndex = 3;
            this.labelPhi.Text = "Курсовой угол, град";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 134);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(105, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Ширина корабля, м";
            // 
            // labelDraft
            // 
            this.labelDraft.AutoSize = true;
            this.labelDraft.Location = new System.Drawing.Point(12, 161);
            this.labelDraft.Name = "labelDraft";
            this.labelDraft.Size = new System.Drawing.Size(104, 13);
            this.labelDraft.TabIndex = 5;
            this.labelDraft.Text = "Осадка корабля, м";
            // 
            // labelMetHeight
            // 
            this.labelMetHeight.AutoSize = true;
            this.labelMetHeight.Location = new System.Drawing.Point(12, 188);
            this.labelMetHeight.Name = "labelMetHeight";
            this.labelMetHeight.Size = new System.Drawing.Size(157, 13);
            this.labelMetHeight.TabIndex = 6;
            this.labelMetHeight.Text = "Метацентрическая высота, м";
            // 
            // tBV
            // 
            this.tBV.Location = new System.Drawing.Point(208, 80);
            this.tBV.Name = "tBV";
            this.tBV.Size = new System.Drawing.Size(100, 20);
            this.tBV.TabIndex = 7;
            // 
            // tBPhi
            // 
            this.tBPhi.Location = new System.Drawing.Point(208, 107);
            this.tBPhi.Name = "tBPhi";
            this.tBPhi.Size = new System.Drawing.Size(100, 20);
            this.tBPhi.TabIndex = 8;
            // 
            // tBB
            // 
            this.tBB.Location = new System.Drawing.Point(208, 134);
            this.tBB.Name = "tBB";
            this.tBB.Size = new System.Drawing.Size(100, 20);
            this.tBB.TabIndex = 9;
            // 
            // tBT
            // 
            this.tBT.Location = new System.Drawing.Point(208, 161);
            this.tBT.Name = "tBT";
            this.tBT.Size = new System.Drawing.Size(100, 20);
            this.tBT.TabIndex = 10;
            // 
            // tBMH
            // 
            this.tBMH.Location = new System.Drawing.Point(208, 188);
            this.tBMH.Name = "tBMH";
            this.tBMH.Size = new System.Drawing.Size(100, 20);
            this.tBMH.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttOk);
            this.panel1.Controls.Add(this.labelInput);
            this.panel1.Location = new System.Drawing.Point(7, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 215);
            this.panel1.TabIndex = 12;
            // 
            // buttOk
            // 
            this.buttOk.Location = new System.Drawing.Point(201, 190);
            this.buttOk.Name = "buttOk";
            this.buttOk.Size = new System.Drawing.Size(100, 23);
            this.buttOk.TabIndex = 1;
            this.buttOk.Text = "Ввод данных";
            this.buttOk.UseVisualStyleBackColor = true;
            this.buttOk.Click += new System.EventHandler(this.buttOk_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(5, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(106, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Входные данные";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelResultVar);
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Location = new System.Drawing.Point(7, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 84);
            this.panel2.TabIndex = 13;
            // 
            // labelResultVar
            // 
            this.labelResultVar.AutoSize = true;
            this.labelResultVar.Location = new System.Drawing.Point(5, 39);
            this.labelResultVar.Name = "labelResultVar";
            this.labelResultVar.Size = new System.Drawing.Size(0, 13);
            this.labelResultVar.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(5, 11);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Построить диаграмму качки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tBMH);
            this.Controls.Add(this.tBT);
            this.Controls.Add(this.tBB);
            this.Controls.Add(this.tBPhi);
            this.Controls.Add(this.tBV);
            this.Controls.Add(this.labelMetHeight);
            this.Controls.Add(this.labelDraft);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelPhi);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.tBLambda);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLambda;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPhi;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDraft;
        private System.Windows.Forms.Label labelMetHeight;
        private System.Windows.Forms.TextBox tBV;
        private System.Windows.Forms.TextBox tBPhi;
        private System.Windows.Forms.TextBox tBB;
        private System.Windows.Forms.TextBox tBT;
        private System.Windows.Forms.TextBox tBMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelResultVar;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttOk;
        private System.Windows.Forms.Button button1;
    }
}

