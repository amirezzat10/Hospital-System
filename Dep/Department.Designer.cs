namespace Hospital_System
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.depImageUserControl11 = new Hospital_System.DepImageUserControl1();
            this.depUpdateUserControl11 = new Hospital_System.DepUpdateUserControl1();
            this.depDeleteUserControl11 = new Hospital_System.DepDeleteUserControl1();
            this.depSearchUserControl11 = new Hospital_System.DepSearchUserControl1();
            this.depInsertUserControl11 = new Hospital_System.DepInsertUserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.ButtonSpecs.FormClose.Image = global::Hospital_System.Properties.Resources.Red_Circle_small_1515_svg__1_;
            this.kryptonPalette2.ButtonSpecs.FormMax.Image = global::Hospital_System.Properties.Resources.lacmta_circle_gold_line1515_818979__1_;
            this.kryptonPalette2.ButtonSpecs.FormMin.Image = global::Hospital_System.Properties.Resources.ski_trail_rating_symbol_green_circle1515_832006__1_;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 374);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospital_System.Properties.Resources.kisspng_hospital_health_care_medicine_physician_computer_i_5af5eb354308f6_0452558215260659732746;
            this.pictureBox2.Location = new System.Drawing.Point(0, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(-47, 143);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(-83, 276);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 73);
            this.button4.TabIndex = 1;
            this.button4.Text = "Show Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(-83, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(-21, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depImageUserControl11
            // 
            this.depImageUserControl11.Location = new System.Drawing.Point(142, -6);
            this.depImageUserControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.depImageUserControl11.Name = "depImageUserControl11";
            this.depImageUserControl11.Size = new System.Drawing.Size(471, 365);
            this.depImageUserControl11.TabIndex = 9;
            // 
            // depUpdateUserControl11
            // 
            this.depUpdateUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.depUpdateUserControl11.Location = new System.Drawing.Point(126, 2);
            this.depUpdateUserControl11.Margin = new System.Windows.Forms.Padding(2);
            this.depUpdateUserControl11.Name = "depUpdateUserControl11";
            this.depUpdateUserControl11.Size = new System.Drawing.Size(521, 379);
            this.depUpdateUserControl11.TabIndex = 8;
            // 
            // depDeleteUserControl11
            // 
            this.depDeleteUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.depDeleteUserControl11.Location = new System.Drawing.Point(126, -1);
            this.depDeleteUserControl11.Margin = new System.Windows.Forms.Padding(2);
            this.depDeleteUserControl11.Name = "depDeleteUserControl11";
            this.depDeleteUserControl11.Size = new System.Drawing.Size(512, 379);
            this.depDeleteUserControl11.TabIndex = 7;
            // 
            // depSearchUserControl11
            // 
            this.depSearchUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.depSearchUserControl11.Location = new System.Drawing.Point(126, -1);
            this.depSearchUserControl11.Margin = new System.Windows.Forms.Padding(2);
            this.depSearchUserControl11.Name = "depSearchUserControl11";
            this.depSearchUserControl11.Size = new System.Drawing.Size(512, 379);
            this.depSearchUserControl11.TabIndex = 6;
            // 
            // depInsertUserControl11
            // 
            this.depInsertUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.depInsertUserControl11.Location = new System.Drawing.Point(126, -1);
            this.depInsertUserControl11.Margin = new System.Windows.Forms.Padding(2);
            this.depInsertUserControl11.Name = "depInsertUserControl11";
            this.depInsertUserControl11.Size = new System.Drawing.Size(502, 379);
            this.depInsertUserControl11.TabIndex = 5;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.depImageUserControl11);
            this.Controls.Add(this.depUpdateUserControl11);
            this.Controls.Add(this.depDeleteUserControl11);
            this.Controls.Add(this.depSearchUserControl11);
            this.Controls.Add(this.depInsertUserControl11);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Department";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Section";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DepInsertUserControl1 depInsertUserControl11;
        private DepSearchUserControl1 depSearchUserControl11;
        private DepDeleteUserControl1 depDeleteUserControl11;
        private DepUpdateUserControl1 depUpdateUserControl11;
        private DepImageUserControl1 depImageUserControl11;
    }
}