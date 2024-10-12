namespace WindowsFormsApp1
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
            this.Круг = new System.Windows.Forms.Button();
            this.Прямоугольник = new System.Windows.Forms.Button();
            this.Треугольник = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Площадь = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Периметр = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Круг
            // 
            this.Круг.Location = new System.Drawing.Point(643, 87);
            this.Круг.Name = "Круг";
            this.Круг.Size = new System.Drawing.Size(144, 23);
            this.Круг.TabIndex = 0;
            this.Круг.Text = "Круг";
            this.Круг.UseVisualStyleBackColor = true;
            this.Круг.Click += new System.EventHandler(this.button1_Click);
            // 
            // Прямоугольник
            // 
            this.Прямоугольник.Location = new System.Drawing.Point(643, 114);
            this.Прямоугольник.Name = "Прямоугольник";
            this.Прямоугольник.Size = new System.Drawing.Size(144, 23);
            this.Прямоугольник.TabIndex = 1;
            this.Прямоугольник.Text = "Прямоугольник";
            this.Прямоугольник.UseVisualStyleBackColor = true;
            this.Прямоугольник.Click += new System.EventHandler(this.button2_Click);
            // 
            // Треугольник
            // 
            this.Треугольник.Location = new System.Drawing.Point(643, 171);
            this.Треугольник.Name = "Треугольник";
            this.Треугольник.Size = new System.Drawing.Size(144, 23);
            this.Треугольник.TabIndex = 2;
            this.Треугольник.Text = "Треугольник";
            this.Треугольник.UseVisualStyleBackColor = true;
            this.Треугольник.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(570, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Площадь
            // 
            this.Площадь.AutoSize = true;
            this.Площадь.Location = new System.Drawing.Point(64, 272);
            this.Площадь.Name = "Площадь";
            this.Площадь.Size = new System.Drawing.Size(68, 16);
            this.Площадь.TabIndex = 4;
            this.Площадь.Text = "Площадь:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(570, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(570, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(570, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(67, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(570, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(67, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(570, 22);
            this.textBox6.TabIndex = 9;
            // 
            // Периметр
            // 
            this.Периметр.AutoSize = true;
            this.Периметр.Location = new System.Drawing.Point(64, 288);
            this.Периметр.Name = "Периметр";
            this.Периметр.Size = new System.Drawing.Size(76, 16);
            this.Периметр.TabIndex = 10;
            this.Периметр.Text = "Периметр:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(816, 377);
            this.Controls.Add(this.Периметр);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Площадь);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Треугольник);
            this.Controls.Add(this.Прямоугольник);
            this.Controls.Add(this.Круг);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculateCircle;
        private System.Windows.Forms.Label lblCircleArea;
        private System.Windows.Forms.Label lblCirclePerimeter;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRectangleArea;
        private System.Windows.Forms.Label lblRectanglePerimeter;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculateRectangle;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblTriangleArea;
        private System.Windows.Forms.Label lblTrianglePerimeter;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnCalculateTriangle;
        private System.Windows.Forms.Button Круг;
        private System.Windows.Forms.Button Прямоугольник;
        private System.Windows.Forms.Button Треугольник;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Площадь;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Периметр;
    }
}

