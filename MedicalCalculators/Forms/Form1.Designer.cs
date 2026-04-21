namespace MedicalCalculators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmiButton = new System.Windows.Forms.Button();
            this.bsaButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Медицинские калькуляторы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(130, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите необходимый калькулятор:";
            // 
            // bmiButton
            // 
            this.bmiButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bmiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmiButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiButton.Location = new System.Drawing.Point(50, 110);
            this.bmiButton.Name = "bmiButton";
            this.bmiButton.Size = new System.Drawing.Size(450, 70);
            this.bmiButton.TabIndex = 2;
            this.bmiButton.Text = "Индекс массы тела (ИМТ)\r\nРассчитывает ИМТ и показывает норму веса для вашего рост" +
    "а";
            this.bmiButton.UseVisualStyleBackColor = false;
            // 
            // bsaButton
            // 
            this.bsaButton.BackColor = System.Drawing.Color.LightGreen;
            this.bsaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bsaButton.Location = new System.Drawing.Point(50, 210);
            this.bsaButton.Name = "bsaButton";
            this.bsaButton.Size = new System.Drawing.Size(450, 70);
            this.bsaButton.TabIndex = 3;
            this.bsaButton.Text = "Площадь поверхности тела (ППТ)\r\nРассчитывает площадь поверхности тела по формуле " +
    "Мостеллера";
            this.bsaButton.UseVisualStyleBackColor = false;
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.LightCoral;
            this.mapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapButton.Location = new System.Drawing.Point(50, 310);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(450, 70);
            this.mapButton.TabIndex = 4;
            this.mapButton.Text = "Среднее артериальное давление (САД)\r\nРассчитывает среднее артериальное давление";
            this.mapButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.bsaButton);
            this.Controls.Add(this.bmiButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медицинские калькуляторы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bmiButton;
        private System.Windows.Forms.Button bsaButton;
        private System.Windows.Forms.Button mapButton;
    }
}

