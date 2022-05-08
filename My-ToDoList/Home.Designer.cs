
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
            this.panelNuevaTarea = new System.Windows.Forms.Panel();
            this.btnHiddePanelNewTask = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMyDay = new System.Windows.Forms.Panel();
            this.ListMyDay = new System.Windows.Forms.CheckedListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.panelList.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBar.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelNuevaTarea.SuspendLayout();
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
            this.panelBody.Controls.Add(this.panelNuevaTarea);
            this.panelBody.Controls.Add(this.panelMyDay);
            this.panelBody.Controls.Add(this.btnNuevaTarea);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(918, 640);
            this.panelBody.TabIndex = 0;
            // 
            // panelNuevaTarea
            // 
            this.panelNuevaTarea.Controls.Add(this.btnHiddePanelNewTask);
            this.panelNuevaTarea.Controls.Add(this.btnSave);
            this.panelNuevaTarea.Controls.Add(this.label4);
            this.panelNuevaTarea.Controls.Add(this.cmbLists);
            this.panelNuevaTarea.Controls.Add(this.label3);
            this.panelNuevaTarea.Controls.Add(this.txtTask);
            this.panelNuevaTarea.Controls.Add(this.label2);
            this.panelNuevaTarea.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelNuevaTarea.Location = new System.Drawing.Point(719, 0);
            this.panelNuevaTarea.Name = "panelNuevaTarea";
            this.panelNuevaTarea.Size = new System.Drawing.Size(200, 640);
            this.panelNuevaTarea.TabIndex = 2;
            this.panelNuevaTarea.Visible = false;
            // 
            // btnHiddePanelNewTask
            // 
            this.btnHiddePanelNewTask.AutoSize = true;
            this.btnHiddePanelNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHiddePanelNewTask.FlatAppearance.BorderSize = 0;
            this.btnHiddePanelNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiddePanelNewTask.ForeColor = System.Drawing.Color.White;
            this.btnHiddePanelNewTask.Location = new System.Drawing.Point(0, 36);
            this.btnHiddePanelNewTask.Name = "btnHiddePanelNewTask";
            this.btnHiddePanelNewTask.Size = new System.Drawing.Size(38, 35);
            this.btnHiddePanelNewTask.TabIndex = 9;
            this.btnHiddePanelNewTask.Text = "←";
            this.btnHiddePanelNewTask.UseVisualStyleBackColor = true;
            this.btnHiddePanelNewTask.Click += new System.EventHandler(this.btnHiddePanelNewTask_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Agregar Tarea";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLists
            // 
            this.cmbLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLists.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLists.ForeColor = System.Drawing.Color.White;
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Items.AddRange(new object[] {
            "Mi Día",
            "Importante",
            "Planeado",
            "Asignadas a mi",
            "Tareas",
            "MyDay"});
            this.cmbLists.Location = new System.Drawing.Point(18, 301);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(149, 29);
            this.cmbLists.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva Tarea";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTask.ForeColor = System.Drawing.Color.White;
            this.txtTask.Location = new System.Drawing.Point(18, 233);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(178, 29);
            this.txtTask.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Nueva Tarea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMyDay
            // 
            this.panelMyDay.Controls.Add(this.ListMyDay);
            this.panelMyDay.Controls.Add(this.lblDate);
            this.panelMyDay.Controls.Add(this.label1);
            this.panelMyDay.Location = new System.Drawing.Point(6, 72);
            this.panelMyDay.Name = "panelMyDay";
            this.panelMyDay.Size = new System.Drawing.Size(469, 556);
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
            this.ListMyDay.Size = new System.Drawing.Size(438, 456);
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
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.AutoSize = true;
            this.btnNuevaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnNuevaTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaTarea.FlatAppearance.BorderSize = 0;
            this.btnNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTarea.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaTarea.ForeColor = System.Drawing.Color.White;
            this.btnNuevaTarea.Location = new System.Drawing.Point(786, 36);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNuevaTarea.Size = new System.Drawing.Size(120, 30);
            this.btnNuevaTarea.TabIndex = 0;
            this.btnNuevaTarea.Text = "Nueva Tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = false;
            this.btnNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
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
            this.panelNuevaTarea.ResumeLayout(false);
            this.panelNuevaTarea.PerformLayout();
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
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.CheckedListBox ListMyDay;
        private System.Windows.Forms.Panel panelNuevaTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHiddePanelNewTask;
    }
}