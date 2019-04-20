namespace Face_Recognition
{
    partial class Training_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Training_Form));
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            this.face_PICBX = new System.Windows.Forms.PictureBox();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.PREV_btn = new System.Windows.Forms.Button();
            this.NEXT_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NAME_PERSON = new System.Windows.Forms.TextBox();
            this.RECORD_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_Data_BTN = new System.Windows.Forms.Button();
            this.Single_btn = new System.Windows.Forms.Button();
            this.count_lbl = new System.Windows.Forms.Label();
            this.ADD_ALL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).BeginInit();
            this.SuspendLayout();
            // 
            // image_PICBX
            // 
            this.image_PICBX.Location = new System.Drawing.Point(12, 4);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(525, 330);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 3;
            this.image_PICBX.TabStop = false;
            // 
            // face_PICBX
            // 
            this.face_PICBX.Location = new System.Drawing.Point(12, 340);
            this.face_PICBX.Name = "face_PICBX";
            this.face_PICBX.Size = new System.Drawing.Size(209, 196);
            this.face_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_PICBX.TabIndex = 4;
            this.face_PICBX.TabStop = false;
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.BackColor = System.Drawing.Color.Transparent;
            this.ADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.ADD_BTN.Location = new System.Drawing.Point(311, 384);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(139, 23);
            this.ADD_BTN.TabIndex = 5;
            this.ADD_BTN.Text = "ADD Image";
            this.ADD_BTN.UseVisualStyleBackColor = false;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // PREV_btn
            // 
            this.PREV_btn.BackColor = System.Drawing.Color.Transparent;
            this.PREV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PREV_btn.ForeColor = System.Drawing.Color.Yellow;
            this.PREV_btn.Location = new System.Drawing.Point(276, 384);
            this.PREV_btn.Name = "PREV_btn";
            this.PREV_btn.Size = new System.Drawing.Size(29, 23);
            this.PREV_btn.TabIndex = 6;
            this.PREV_btn.Text = "<<";
            this.PREV_btn.UseVisualStyleBackColor = false;
            this.PREV_btn.Visible = false;
            this.PREV_btn.Click += new System.EventHandler(this.PREV_btn_Click);
            // 
            // NEXT_BTN
            // 
            this.NEXT_BTN.BackColor = System.Drawing.Color.Transparent;
            this.NEXT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEXT_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.NEXT_BTN.Location = new System.Drawing.Point(456, 384);
            this.NEXT_BTN.Name = "NEXT_BTN";
            this.NEXT_BTN.Size = new System.Drawing.Size(29, 23);
            this.NEXT_BTN.TabIndex = 7;
            this.NEXT_BTN.Text = ">>";
            this.NEXT_BTN.UseVisualStyleBackColor = false;
            this.NEXT_BTN.Visible = false;
            this.NEXT_BTN.Click += new System.EventHandler(this.NEXT_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(238, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME:";
            // 
            // NAME_PERSON
            // 
            this.NAME_PERSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NAME_PERSON.ForeColor = System.Drawing.Color.Yellow;
            this.NAME_PERSON.Location = new System.Drawing.Point(299, 432);
            this.NAME_PERSON.Name = "NAME_PERSON";
            this.NAME_PERSON.Size = new System.Drawing.Size(158, 20);
            this.NAME_PERSON.TabIndex = 9;
            this.NAME_PERSON.Text = "PERSON1";
            // 
            // RECORD_BTN
            // 
            this.RECORD_BTN.BackColor = System.Drawing.Color.Transparent;
            this.RECORD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RECORD_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.RECORD_BTN.Location = new System.Drawing.Point(1340, 87);
            this.RECORD_BTN.Name = "RECORD_BTN";
            this.RECORD_BTN.Size = new System.Drawing.Size(92, 23);
            this.RECORD_BTN.TabIndex = 10;
            this.RECORD_BTN.Text = "Record 10 Faces";
            this.RECORD_BTN.UseVisualStyleBackColor = false;
            this.RECORD_BTN.Click += new System.EventHandler(this.RECORD_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1389, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Options";
            // 
            // Delete_Data_BTN
            // 
            this.Delete_Data_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Data_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Data_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.Delete_Data_BTN.Location = new System.Drawing.Point(311, 340);
            this.Delete_Data_BTN.Name = "Delete_Data_BTN";
            this.Delete_Data_BTN.Size = new System.Drawing.Size(146, 23);
            this.Delete_Data_BTN.TabIndex = 12;
            this.Delete_Data_BTN.Text = "Delete Data";
            this.Delete_Data_BTN.UseVisualStyleBackColor = false;
            this.Delete_Data_BTN.Click += new System.EventHandler(this.Delete_Data_BTN_Click);
            // 
            // Single_btn
            // 
            this.Single_btn.BackColor = System.Drawing.Color.Transparent;
            this.Single_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Single_btn.ForeColor = System.Drawing.Color.Yellow;
            this.Single_btn.Location = new System.Drawing.Point(1342, 116);
            this.Single_btn.Name = "Single_btn";
            this.Single_btn.Size = new System.Drawing.Size(92, 23);
            this.Single_btn.TabIndex = 13;
            this.Single_btn.Text = "Restart 1 Face";
            this.Single_btn.UseVisualStyleBackColor = false;
            this.Single_btn.Visible = false;
            this.Single_btn.Click += new System.EventHandler(this.Single_btn_Click);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.count_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.count_lbl.Location = new System.Drawing.Point(1344, 121);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(47, 13);
            this.count_lbl.TabIndex = 14;
            this.count_lbl.Text = "Count: 0";
            // 
            // ADD_ALL
            // 
            this.ADD_ALL.BackColor = System.Drawing.Color.Transparent;
            this.ADD_ALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_ALL.ForeColor = System.Drawing.Color.Yellow;
            this.ADD_ALL.Location = new System.Drawing.Point(1303, 12);
            this.ADD_ALL.Name = "ADD_ALL";
            this.ADD_ALL.Size = new System.Drawing.Size(129, 23);
            this.ADD_ALL.TabIndex = 15;
            this.ADD_ALL.Text = "ADD ALL...";
            this.ADD_ALL.UseVisualStyleBackColor = false;
            this.ADD_ALL.Visible = false;
            this.ADD_ALL.Click += new System.EventHandler(this.ADD_ALL_Click);
            // 
            // Training_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Face_Recognition.Properties.Resources.ws_Deep_Blue_Digital_1680x1050;
            this.ClientSize = new System.Drawing.Size(568, 540);
            this.Controls.Add(this.ADD_ALL);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.Single_btn);
            this.Controls.Add(this.Delete_Data_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RECORD_BTN);
            this.Controls.Add(this.NAME_PERSON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEXT_BTN);
            this.Controls.Add(this.PREV_btn);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.face_PICBX);
            this.Controls.Add(this.image_PICBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Training_Form";
            this.Text = "let me know you ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Training_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_PICBX;
        private System.Windows.Forms.PictureBox face_PICBX;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.Button PREV_btn;
        private System.Windows.Forms.Button NEXT_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NAME_PERSON;
        private System.Windows.Forms.Button RECORD_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_Data_BTN;
        private System.Windows.Forms.Button Single_btn;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Button ADD_ALL;
    }
}