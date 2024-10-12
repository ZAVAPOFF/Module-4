namespace Product
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
            this.ListProducts = new System.Windows.Forms.ListBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListProducts
            // 
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.Location = new System.Drawing.Point(12, 12);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(398, 251);
            this.ListProducts.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(445, 221);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(188, 42);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Показать цену и остаток";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 322);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.ListProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.Button btnProducts;
    }
}

