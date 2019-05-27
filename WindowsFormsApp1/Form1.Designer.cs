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
         this.label16 = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.calculateQUAD = new System.Windows.Forms.Button();
         this.rTB1quad = new System.Windows.Forms.RichTextBox();
         this.ax = new System.Windows.Forms.NumericUpDown();
         this.ay = new System.Windows.Forms.NumericUpDown();
         this.dy = new System.Windows.Forms.NumericUpDown();
         this.dx = new System.Windows.Forms.NumericUpDown();
         this.cy = new System.Windows.Forms.NumericUpDown();
         this.cx = new System.Windows.Forms.NumericUpDown();
         this.by = new System.Windows.Forms.NumericUpDown();
         this.bx = new System.Windows.Forms.NumericUpDown();
         this.calculateRHOM = new System.Windows.Forms.Button();
         this.rTBrhom = new System.Windows.Forms.RichTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.ax)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ay)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dy)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dx)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cy)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cx)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.by)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bx)).BeginInit();
         this.SuspendLayout();
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label16.Location = new System.Drawing.Point(54, 135);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(31, 29);
         this.label16.TabIndex = 41;
         this.label16.Text = "C";
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label15.Location = new System.Drawing.Point(54, 163);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(31, 29);
         this.label15.TabIndex = 40;
         this.label15.Text = "D";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label12.Location = new System.Drawing.Point(54, 107);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(30, 29);
         this.label12.TabIndex = 39;
         this.label12.Text = "B";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label11.Location = new System.Drawing.Point(54, 79);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(29, 29);
         this.label11.TabIndex = 38;
         this.label11.Text = "A";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label10.Location = new System.Drawing.Point(154, 45);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(25, 29);
         this.label10.TabIndex = 37;
         this.label10.Text = "y";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(102, 45);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(25, 29);
         this.label1.TabIndex = 36;
         this.label1.Text = "x";
         // 
         // calculateQUAD
         // 
         this.calculateQUAD.Location = new System.Drawing.Point(239, 360);
         this.calculateQUAD.Name = "calculateQUAD";
         this.calculateQUAD.Size = new System.Drawing.Size(200, 52);
         this.calculateQUAD.TabIndex = 27;
         this.calculateQUAD.Text = "Calculate Quadrilateral";
         this.calculateQUAD.UseVisualStyleBackColor = true;
         this.calculateQUAD.Click += new System.EventHandler(this.calculateQUAD_Click);
         // 
         // rTB1quad
         // 
         this.rTB1quad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.rTB1quad.Location = new System.Drawing.Point(239, 52);
         this.rTB1quad.Name = "rTB1quad";
         this.rTB1quad.Size = new System.Drawing.Size(200, 302);
         this.rTB1quad.TabIndex = 26;
         this.rTB1quad.Text = "";
         // 
         // ax
         // 
         this.ax.Location = new System.Drawing.Point(89, 86);
         this.ax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.ax.Name = "ax";
         this.ax.Size = new System.Drawing.Size(57, 22);
         this.ax.TabIndex = 42;
         // 
         // ay
         // 
         this.ay.Location = new System.Drawing.Point(152, 87);
         this.ay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.ay.Name = "ay";
         this.ay.Size = new System.Drawing.Size(57, 22);
         this.ay.TabIndex = 43;
         // 
         // dy
         // 
         this.dy.Location = new System.Drawing.Point(152, 171);
         this.dy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.dy.Name = "dy";
         this.dy.Size = new System.Drawing.Size(57, 22);
         this.dy.TabIndex = 44;
         // 
         // dx
         // 
         this.dx.Location = new System.Drawing.Point(89, 171);
         this.dx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.dx.Name = "dx";
         this.dx.Size = new System.Drawing.Size(57, 22);
         this.dx.TabIndex = 45;
         // 
         // cy
         // 
         this.cy.Location = new System.Drawing.Point(152, 143);
         this.cy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.cy.Name = "cy";
         this.cy.Size = new System.Drawing.Size(57, 22);
         this.cy.TabIndex = 46;
         // 
         // cx
         // 
         this.cx.Location = new System.Drawing.Point(89, 142);
         this.cx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.cx.Name = "cx";
         this.cx.Size = new System.Drawing.Size(57, 22);
         this.cx.TabIndex = 47;
         // 
         // by
         // 
         this.by.Location = new System.Drawing.Point(152, 115);
         this.by.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.by.Name = "by";
         this.by.Size = new System.Drawing.Size(57, 22);
         this.by.TabIndex = 48;
         // 
         // bx
         // 
         this.bx.Location = new System.Drawing.Point(89, 114);
         this.bx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
         this.bx.Name = "bx";
         this.bx.Size = new System.Drawing.Size(57, 22);
         this.bx.TabIndex = 49;
         // 
         // calculateRHOM
         // 
         this.calculateRHOM.Location = new System.Drawing.Point(466, 360);
         this.calculateRHOM.Name = "calculateRHOM";
         this.calculateRHOM.Size = new System.Drawing.Size(190, 52);
         this.calculateRHOM.TabIndex = 50;
         this.calculateRHOM.Text = "Calculate Rhombus";
         this.calculateRHOM.UseVisualStyleBackColor = true;
         this.calculateRHOM.Click += new System.EventHandler(this.calculateRHOM_Click);
         // 
         // rTBrhom
         // 
         this.rTBrhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.rTBrhom.Location = new System.Drawing.Point(466, 52);
         this.rTBrhom.Name = "rTBrhom";
         this.rTBrhom.Size = new System.Drawing.Size(190, 302);
         this.rTBrhom.TabIndex = 51;
         this.rTBrhom.Text = "";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(461, 13);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(123, 29);
         this.label2.TabIndex = 52;
         this.label2.Text = "Rhombus";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(234, 13);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(165, 29);
         this.label3.TabIndex = 53;
         this.label3.Text = "Quadrilateral";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(678, 452);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.rTBrhom);
         this.Controls.Add(this.calculateRHOM);
         this.Controls.Add(this.bx);
         this.Controls.Add(this.by);
         this.Controls.Add(this.cx);
         this.Controls.Add(this.cy);
         this.Controls.Add(this.dx);
         this.Controls.Add(this.dy);
         this.Controls.Add(this.ay);
         this.Controls.Add(this.ax);
         this.Controls.Add(this.label16);
         this.Controls.Add(this.label15);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.calculateQUAD);
         this.Controls.Add(this.rTB1quad);
         this.Name = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.ax)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ay)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dy)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dx)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cy)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cx)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.by)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bx)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button calculateQUAD;
      private System.Windows.Forms.RichTextBox rTB1quad;
      private System.Windows.Forms.NumericUpDown ax;
      private System.Windows.Forms.NumericUpDown ay;
      private System.Windows.Forms.NumericUpDown dy;
      private System.Windows.Forms.NumericUpDown dx;
      private System.Windows.Forms.NumericUpDown cy;
      private System.Windows.Forms.NumericUpDown cx;
      private System.Windows.Forms.NumericUpDown by;
      private System.Windows.Forms.NumericUpDown bx;
      private System.Windows.Forms.Button calculateRHOM;
      private System.Windows.Forms.RichTextBox rTBrhom;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}

