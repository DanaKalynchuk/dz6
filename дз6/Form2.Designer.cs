
namespace дз6
{
    partial class Form2
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
            this.Close = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(160, 366);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(152, 52);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(544, 31);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(164, 45);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(544, 113);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(164, 45);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "Add";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(544, 193);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(164, 45);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(544, 280);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(164, 45);
            this.Yes.TabIndex = 5;
            this.Yes.Text = "Edit";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.ItemHeight = 20;
            this.Products.Location = new System.Drawing.Point(29, 17);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(429, 304);
            this.Products.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Close);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Yes;
        public System.Windows.Forms.ListBox Products;
    }
}