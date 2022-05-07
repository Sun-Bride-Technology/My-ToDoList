
namespace My_ToDoList
{
    partial class Home
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
            this.panelList = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnForMe = new System.Windows.Forms.Button();
            this.btnPlanned = new System.Windows.Forms.Button();
            this.btnImportant = new System.Windows.Forms.Button();
            this.btnMyDay = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMyDay = new System.Windows.Forms.Panel();
            this.ListMyDay = new System.Windows.Forms.CheckedListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelList.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBar.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelMyDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelList.Controls.Add(this.btnLogOut);
            this.panelList.Controls.Add(this.btnTasks);
            this.panelList.Controls.Add(this.btnForMe);
            this.panelList.Controls.Add(this.btnPlanned);
            this.panelList.Controls.Add(this.btnImportant);
            this.panelList.Controls.Add(this.btnMyDay);
            this.panelList.Controls.Add(this.panelInfo);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(150, 640);
            this.panelList.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 606);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 34);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(0, 236);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(150, 34);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Tareas";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.UseVisualStyleBackColor = true;
            // 
            // btnForMe
            // 
            this.btnForMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForMe.FlatAppearance.BorderSize = 0;
            this.btnForMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForMe.ForeColor = System.Drawing.Color.White;
            this.btnForMe.Location = new System.Drawing.Point(0, 202);
            this.btnForMe.Name = "btnForMe";
            this.btnForMe.Size = new System.Drawing.Size(150, 34);
            this.btnForMe.TabIndex = 3;
            this.btnForMe.Text = "Asignadas a mí";
            this.btnForMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForMe.UseVisualStyleBackColor = true;
            // 
            // btnPlanned
            // 
            this.btnPlanned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanned.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanned.FlatAppearance.BorderSize = 0;
            this.btnPlanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanned.ForeColor = System.Drawing.Color.White;
            this.btnPlanned.Location = new System.Drawing.Point(0, 168);
            this.btnPlanned.Name = "btnPlanned";
            this.btnPlanned.Size = new System.Drawing.Size(150, 34);
            this.btnPlanned.TabIndex = 2;
            this.btnPlanned.Text = "Agenda";
            this.btnPlanned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanned.UseVisualStyleBackColor = true;
            // 
            // btnImportant
            // 
            this.btnImportant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportant.FlatAppearance.BorderSize = 0;
            this.btnImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportant.ForeColor = System.Drawing.Color.White;
            this.btnImportant.Location = new System.Drawing.Point(0, 134);
            this.btnImportant.Name = "btnImportant";
            this.btnImportant.Size = new System.Drawing.Size(150, 34);
            this.btnImportant.TabIndex = 1;
            this.btnImportant.Text = "Importante";
            this.btnImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportant.UseVisualStyleBackColor = true;
            // 
            // btnMyDay
            // 
            this.btnMyDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyDay.FlatAppearance.BorderSize = 0;
            this.btnMyDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDay.ForeColor = System.Drawing.Color.White;
            this.btnMyDay.Location = new System.Drawing.Point(0, 100);
            this.btnMyDay.Name = "btnMyDay";
            this.btnMyDay.Size = new System.Drawing.Size(150, 34);
            this.btnMyDay.TabIndex = 0;
            this.btnMyDay.Text = "Mi Día";
            this.btnMyDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyDay.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(150, 100);
            this.panelInfo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::My_ToDoList.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelBar.Controls.Add(this.btnMax);
            this.panelBar.Controls.Add(this.btnMinimize);
            this.panelBar.Controls.Add(this.btnClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(150, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(918, 30);
            this.panelBar.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(854, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 23);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "🗖";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(825, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(883, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelBody.Controls.Add(this.panelMyDay);
            this.panelBody.Controls.Add(this.button1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(918, 640);
            this.panelBody.TabIndex = 0;
            // 
            // panelMyDay
            // 
            this.panelMyDay.Controls.Add(this.ListMyDay);
            this.panelMyDay.Controls.Add(this.lblDate);
            this.panelMyDay.Controls.Add(this.label1);
            this.panelMyDay.Location = new System.Drawing.Point(6, 72);
            this.panelMyDay.Name = "panelMyDay";
            this.panelMyDay.Size = new System.Drawing.Size(900, 556);
            this.panelMyDay.TabIndex = 1;
            // 
            // ListMyDay
            // 
            this.ListMyDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ListMyDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListMyDay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListMyDay.ForeColor = System.Drawing.Color.White;
            this.ListMyDay.FormattingEnabled = true;
            this.ListMyDay.Items.AddRange(new object[] {
            "Item1"});
            this.ListMyDay.Location = new System.Drawing.Point(0, 86);
            this.ListMyDay.Name = "ListMyDay";
            this.ListMyDay.Size = new System.Drawing.Size(450, 456);
            this.ListMyDay.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi Día";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(786, 36);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva Tarea";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 640);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelList.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelMyDay.ResumeLayout(false);
            this.panelMyDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnForMe;
        private System.Windows.Forms.Button btnPlanned;
        private System.Windows.Forms.Button btnImportant;
        private System.Windows.Forms.Button btnMyDay;
        private System.Windows.Forms.Panel panelMyDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox ListMyDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
    }
}