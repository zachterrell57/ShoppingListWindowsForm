
namespace ShoppingListWindowsForm
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommonItemsButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(358, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nicki\'s Shopping List";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 32;
            this.ItemListBox.Location = new System.Drawing.Point(686, 151);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(499, 580);
            this.ItemListBox.TabIndex = 1;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(147, 322);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(353, 39);
            this.ItemTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Item:";
            // 
            // CommonItemsButton
            // 
            this.CommonItemsButton.Location = new System.Drawing.Point(406, 437);
            this.CommonItemsButton.Name = "CommonItemsButton";
            this.CommonItemsButton.Size = new System.Drawing.Size(201, 121);
            this.CommonItemsButton.TabIndex = 5;
            this.CommonItemsButton.Text = "Add Common Items to List";
            this.CommonItemsButton.UseVisualStyleBackColor = true;
            this.CommonItemsButton.Click += new System.EventHandler(this.CommonItemsButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(115, 437);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(201, 121);
            this.EraseButton.TabIndex = 6;
            this.EraseButton.Text = "Erase List";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(525, 315);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 53);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(1222, 160);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(169, 115);
            this.CheckButton.TabIndex = 8;
            this.CheckButton.Text = "Check Off Item";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1417, 779);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.CommonItemsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Nicki\'s Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CommonItemsButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CheckButton;
    }
}

