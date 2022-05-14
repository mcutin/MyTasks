namespace MyTasks
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOrderBy = new System.Windows.Forms.Label();
            this.radioDueDate = new System.Windows.Forms.RadioButton();
            this.radioPriority = new System.Windows.Forms.RadioButton();
            this.groupTaskList = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDueTo = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.groupShortTermPlan = new System.Windows.Forms.GroupBox();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.LinkLabel();
            this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.completeTask = new System.Windows.Forms.ToolStripMenuItem();
            this.editTask = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.groupTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.groupShortTermPlan.SuspendLayout();
            this.dgvContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 605);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1048, 24);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(160, 19);
            this.statusBarLabel.Text = "There are no tasks listed.";
            this.statusBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.AutoSize = true;
            this.txtOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderBy.Location = new System.Drawing.Point(205, 17);
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Size = new System.Drawing.Size(73, 20);
            this.txtOrderBy.TabIndex = 2;
            this.txtOrderBy.Text = "Order by:";
            // 
            // radioDueDate
            // 
            this.radioDueDate.AutoSize = true;
            this.radioDueDate.Checked = true;
            this.radioDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDueDate.Location = new System.Drawing.Point(294, 15);
            this.radioDueDate.Name = "radioDueDate";
            this.radioDueDate.Size = new System.Drawing.Size(213, 24);
            this.radioDueDate.TabIndex = 3;
            this.radioDueDate.TabStop = true;
            this.radioDueDate.Text = "Due date first, then priority";
            this.radioDueDate.UseVisualStyleBackColor = true;
            this.radioDueDate.CheckedChanged += new System.EventHandler(this.radioDueDate_CheckedChanged);
            // 
            // radioPriority
            // 
            this.radioPriority.AutoSize = true;
            this.radioPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPriority.Location = new System.Drawing.Point(531, 15);
            this.radioPriority.Name = "radioPriority";
            this.radioPriority.Size = new System.Drawing.Size(211, 24);
            this.radioPriority.TabIndex = 4;
            this.radioPriority.Text = "Priority first, then due date";
            this.radioPriority.UseVisualStyleBackColor = true;
            this.radioPriority.CheckedChanged += new System.EventHandler(this.radioPriority_CheckedChanged);
            // 
            // groupTaskList
            // 
            this.groupTaskList.Controls.Add(this.lblDescription);
            this.groupTaskList.Controls.Add(this.lblDueTo);
            this.groupTaskList.Controls.Add(this.dgvTasks);
            this.groupTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTaskList.Location = new System.Drawing.Point(12, 62);
            this.groupTaskList.Name = "groupTaskList";
            this.groupTaskList.Size = new System.Drawing.Size(424, 530);
            this.groupTaskList.TabIndex = 5;
            this.groupTaskList.TabStop = false;
            this.groupTaskList.Text = "Task list";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(143, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(264, 30);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDueTo
            // 
            this.lblDueTo.BackColor = System.Drawing.SystemColors.Control;
            this.lblDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueTo.Location = new System.Drawing.Point(40, 34);
            this.lblDueTo.Name = "lblDueTo";
            this.lblDueTo.Size = new System.Drawing.Size(100, 30);
            this.lblDueTo.TabIndex = 36;
            this.lblDueTo.Text = "Due to";
            this.lblDueTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.ColumnHeadersVisible = false;
            this.dgvTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTasks.Location = new System.Drawing.Point(15, 65);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.RowTemplate.ContextMenuStrip = this.dgvContextMenu;
            this.dgvTasks.RowTemplate.Height = 25;
            this.dgvTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ShowCellToolTips = false;
            this.dgvTasks.ShowEditingIcon = false;
            this.dgvTasks.Size = new System.Drawing.Size(392, 450);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_CellMouseDown);
            this.dgvTasks.Click += new System.EventHandler(this.dgvTasks_Click);
            this.dgvTasks.DoubleClick += new System.EventHandler(this.dgvTasks_DoubleClick);
            // 
            // groupShortTermPlan
            // 
            this.groupShortTermPlan.Controls.Add(this.lblSaturday);
            this.groupShortTermPlan.Controls.Add(this.lblFriday);
            this.groupShortTermPlan.Controls.Add(this.lblThursday);
            this.groupShortTermPlan.Controls.Add(this.lblWednesday);
            this.groupShortTermPlan.Controls.Add(this.lblTuesday);
            this.groupShortTermPlan.Controls.Add(this.lblMonday);
            this.groupShortTermPlan.Controls.Add(this.lblSunday);
            this.groupShortTermPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupShortTermPlan.Location = new System.Drawing.Point(451, 62);
            this.groupShortTermPlan.Name = "groupShortTermPlan";
            this.groupShortTermPlan.Size = new System.Drawing.Size(589, 530);
            this.groupShortTermPlan.TabIndex = 6;
            this.groupShortTermPlan.TabStop = false;
            this.groupShortTermPlan.Text = "Short term plan";
            // 
            // lblSaturday
            // 
            this.lblSaturday.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(495, 34);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(80, 30);
            this.lblSaturday.TabIndex = 41;
            this.lblSaturday.Text = "Sat";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.BackColor = System.Drawing.SystemColors.Control;
            this.lblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(415, 34);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(80, 30);
            this.lblFriday.TabIndex = 40;
            this.lblFriday.Text = "Fri";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.BackColor = System.Drawing.SystemColors.Control;
            this.lblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(335, 34);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(80, 30);
            this.lblThursday.TabIndex = 39;
            this.lblThursday.Text = "Thu";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.BackColor = System.Drawing.SystemColors.Control;
            this.lblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(255, 34);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(80, 30);
            this.lblWednesday.TabIndex = 38;
            this.lblWednesday.Text = "Wed";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.BackColor = System.Drawing.SystemColors.Control;
            this.lblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(175, 34);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(80, 30);
            this.lblTuesday.TabIndex = 37;
            this.lblTuesday.Text = "Tue";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.BackColor = System.Drawing.SystemColors.Control;
            this.lblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(95, 34);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(80, 30);
            this.lblMonday.TabIndex = 36;
            this.lblMonday.Text = "Mon";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSunday
            // 
            this.lblSunday.BackColor = System.Drawing.SystemColors.Control;
            this.lblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(15, 34);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(80, 30);
            this.lblSunday.TabIndex = 35;
            this.lblSunday.Text = "Sun";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(976, 17);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(64, 20);
            this.lblAbout.TabIndex = 7;
            this.lblAbout.TabStop = true;
            this.lblAbout.Text = "About...";
            this.lblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbout_LinkClicked);
            // 
            // dgvContextMenu
            // 
            this.dgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeTask,
            this.editTask});
            this.dgvContextMenu.Name = "dgvContextMenu";
            this.dgvContextMenu.Size = new System.Drawing.Size(175, 48);
            this.dgvContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvContextMenu_ItemClicked);
            // 
            // completeTask
            // 
            this.completeTask.Image = global::MyTasks.Properties.Resources.StatusOffline_16x;
            this.completeTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeTask.Name = "completeTask";
            this.completeTask.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.completeTask.Size = new System.Drawing.Size(174, 22);
            this.completeTask.Text = "Complete task";
            // 
            // editTask
            // 
            this.editTask.Image = global::MyTasks.Properties.Resources.ASX_Edit_blue_16x;
            this.editTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(174, 22);
            this.editTask.Text = "Edit task";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.Image = global::MyTasks.Properties.Resources.AddIcon;
            this.btnNewTask.Location = new System.Drawing.Point(12, 12);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(130, 30);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "New task";
            this.btnNewTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.groupShortTermPlan);
            this.Controls.Add(this.groupTaskList);
            this.Controls.Add(this.radioPriority);
            this.Controls.Add(this.radioDueDate);
            this.Controls.Add(this.txtOrderBy);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTasks";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.groupShortTermPlan.ResumeLayout(false);
            this.dgvContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Label txtOrderBy;
        private System.Windows.Forms.RadioButton radioDueDate;
        private System.Windows.Forms.RadioButton radioPriority;
        private System.Windows.Forms.GroupBox groupTaskList;
        private System.Windows.Forms.GroupBox groupShortTermPlan;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Label lblDueTo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.LinkLabel lblAbout;
        private System.Windows.Forms.ContextMenuStrip dgvContextMenu;
        private System.Windows.Forms.ToolStripMenuItem completeTask;
        private System.Windows.Forms.ToolStripMenuItem editTask;
    }
}

