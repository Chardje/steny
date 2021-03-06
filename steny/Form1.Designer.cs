namespace steny
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.label_angle = new System.Windows.Forms.Label();
            this.long_lable = new System.Windows.Forms.Label();
            this.angle_textbox = new System.Windows.Forms.NumericUpDown();
            this.longtext = new System.Windows.Forms.NumericUpDown();
            this.HeightText = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.TextBox();
            this.AreaRoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.angle_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longtext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(36, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "new point";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(36, 197);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 1;
            this.del.Text = "del last";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(18, 72);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(33, 13);
            this.label_angle.TabIndex = 5;
            this.label_angle.Text = "angle";
            this.label_angle.Click += new System.EventHandler(this.label_angle_Click);
            // 
            // long_lable
            // 
            this.long_lable.AutoSize = true;
            this.long_lable.Location = new System.Drawing.Point(18, 33);
            this.long_lable.Name = "long_lable";
            this.long_lable.Size = new System.Drawing.Size(27, 13);
            this.long_lable.TabIndex = 6;
            this.long_lable.Text = "long";
            this.long_lable.Click += new System.EventHandler(this.long_lable_Click);
            // 
            // angle_textbox
            // 
            this.angle_textbox.Location = new System.Drawing.Point(21, 88);
            this.angle_textbox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angle_textbox.Name = "angle_textbox";
            this.angle_textbox.Size = new System.Drawing.Size(100, 20);
            this.angle_textbox.TabIndex = 11;
            // 
            // longtext
            // 
            this.longtext.Location = new System.Drawing.Point(21, 49);
            this.longtext.Name = "longtext";
            this.longtext.Size = new System.Drawing.Size(100, 20);
            this.longtext.TabIndex = 12;
            this.longtext.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(21, 127);
            this.HeightText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(100, 20);
            this.HeightText.TabIndex = 14;
            this.HeightText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(18, 111);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(36, 13);
            this.Height.TabIndex = 13;
            this.Height.Text = "height";
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(21, 254);
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Size = new System.Drawing.Size(100, 20);
            this.Area.TabIndex = 17;
            // 
            // AreaRoom
            // 
            this.AreaRoom.Location = new System.Drawing.Point(21, 280);
            this.AreaRoom.Name = "AreaRoom";
            this.AreaRoom.ReadOnly = true;
            this.AreaRoom.Size = new System.Drawing.Size(100, 20);
            this.AreaRoom.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AreaRoom);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.longtext);
            this.Controls.Add(this.angle_textbox);
            this.Controls.Add(this.long_lable);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.angle_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longtext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.Label long_lable;
        private System.Windows.Forms.NumericUpDown angle_textbox;
        private System.Windows.Forms.NumericUpDown longtext;
        private System.Windows.Forms.NumericUpDown HeightText;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox AreaRoom;
    }
}

