namespace OzoneEventManagement2
{
    partial class Food
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.foodid_txt = new System.Windows.Forms.TextBox();
            this.foodname_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.savefd_btn = new System.Windows.Forms.Button();
            this.addfd_btn = new System.Windows.Forms.Button();
            this.newad_btn = new System.Windows.Forms.Button();
            this.displayfd_btn = new System.Windows.Forms.Button();
            this.deletefd_btn = new System.Windows.Forms.Button();
            this.updatefd_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Manage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // foodid_txt
            // 
            this.foodid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodid_txt.Location = new System.Drawing.Point(178, 109);
            this.foodid_txt.Multiline = true;
            this.foodid_txt.Name = "foodid_txt";
            this.foodid_txt.Size = new System.Drawing.Size(180, 28);
            this.foodid_txt.TabIndex = 6;
            this.foodid_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // foodname_txt
            // 
            this.foodname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodname_txt.Location = new System.Drawing.Point(178, 161);
            this.foodname_txt.Multiline = true;
            this.foodname_txt.Name = "foodname_txt";
            this.foodname_txt.Size = new System.Drawing.Size(180, 28);
            this.foodname_txt.TabIndex = 7;
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.Location = new System.Drawing.Point(178, 209);
            this.price_txt.Multiline = true;
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(180, 28);
            this.price_txt.TabIndex = 8;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.Location = new System.Drawing.Point(178, 262);
            this.quantity_txt.Multiline = true;
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(180, 28);
            this.quantity_txt.TabIndex = 9;
            // 
            // status_txt
            // 
            this.status_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_txt.Location = new System.Drawing.Point(178, 309);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(180, 28);
            this.status_txt.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 202);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // savefd_btn
            // 
            this.savefd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savefd_btn.Location = new System.Drawing.Point(39, 610);
            this.savefd_btn.Name = "savefd_btn";
            this.savefd_btn.Size = new System.Drawing.Size(97, 32);
            this.savefd_btn.TabIndex = 12;
            this.savefd_btn.Text = "Save";
            this.savefd_btn.UseVisualStyleBackColor = true;
            this.savefd_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addfd_btn
            // 
            this.addfd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfd_btn.Location = new System.Drawing.Point(153, 610);
            this.addfd_btn.Name = "addfd_btn";
            this.addfd_btn.Size = new System.Drawing.Size(97, 32);
            this.addfd_btn.TabIndex = 13;
            this.addfd_btn.Text = "Add";
            this.addfd_btn.UseVisualStyleBackColor = true;
            this.addfd_btn.Click += new System.EventHandler(this.addfd_btn_Click);
            // 
            // newad_btn
            // 
            this.newad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newad_btn.Location = new System.Drawing.Point(272, 610);
            this.newad_btn.Name = "newad_btn";
            this.newad_btn.Size = new System.Drawing.Size(97, 32);
            this.newad_btn.TabIndex = 14;
            this.newad_btn.Text = "New";
            this.newad_btn.UseVisualStyleBackColor = true;
            this.newad_btn.Click += new System.EventHandler(this.newad_btn_Click);
            // 
            // displayfd_btn
            // 
            this.displayfd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayfd_btn.Location = new System.Drawing.Point(511, 610);
            this.displayfd_btn.Name = "displayfd_btn";
            this.displayfd_btn.Size = new System.Drawing.Size(97, 32);
            this.displayfd_btn.TabIndex = 15;
            this.displayfd_btn.Text = "Display";
            this.displayfd_btn.UseVisualStyleBackColor = true;
            this.displayfd_btn.Click += new System.EventHandler(this.displayfd_btn_Click);
            // 
            // deletefd_btn
            // 
            this.deletefd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletefd_btn.Location = new System.Drawing.Point(629, 610);
            this.deletefd_btn.Name = "deletefd_btn";
            this.deletefd_btn.Size = new System.Drawing.Size(97, 32);
            this.deletefd_btn.TabIndex = 16;
            this.deletefd_btn.Text = "Delete";
            this.deletefd_btn.UseVisualStyleBackColor = true;
            this.deletefd_btn.Click += new System.EventHandler(this.deletefd_btn_Click);
            // 
            // updatefd_btn
            // 
            this.updatefd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatefd_btn.Location = new System.Drawing.Point(390, 610);
            this.updatefd_btn.Name = "updatefd_btn";
            this.updatefd_btn.Size = new System.Drawing.Size(97, 32);
            this.updatefd_btn.TabIndex = 19;
            this.updatefd_btn.Text = "Update";
            this.updatefd_btn.UseVisualStyleBackColor = true;
            this.updatefd_btn.Click += new System.EventHandler(this.updatefd_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OzoneEventManagement2.Properties.Resources.exit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(683, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OzoneEventManagement2.Properties.Resources.food2;
            this.pictureBox1.Location = new System.Drawing.Point(390, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(764, 666);
            this.Controls.Add(this.updatefd_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deletefd_btn);
            this.Controls.Add(this.displayfd_btn);
            this.Controls.Add(this.newad_btn);
            this.Controls.Add(this.addfd_btn);
            this.Controls.Add(this.savefd_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.foodname_txt);
            this.Controls.Add(this.foodid_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox foodid_txt;
        private System.Windows.Forms.TextBox foodname_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button savefd_btn;
        private System.Windows.Forms.Button addfd_btn;
        private System.Windows.Forms.Button newad_btn;
        private System.Windows.Forms.Button displayfd_btn;
        private System.Windows.Forms.Button deletefd_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button updatefd_btn;
    }
}