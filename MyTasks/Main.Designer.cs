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
            this.dgvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.completeTask = new System.Windows.Forms.ToolStripMenuItem();
            this.groupShortTermPlan = new System.Windows.Forms.GroupBox();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.LinkLabel();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.editTaskTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PDay64 = new MyTasks.PlannerDay();
            this.PDay54 = new MyTasks.PlannerDay();
            this.PDay44 = new MyTasks.PlannerDay();
            this.PDay34 = new MyTasks.PlannerDay();
            this.PDay24 = new MyTasks.PlannerDay();
            this.PDay14 = new MyTasks.PlannerDay();
            this.PDay63 = new MyTasks.PlannerDay();
            this.PDay53 = new MyTasks.PlannerDay();
            this.PDay43 = new MyTasks.PlannerDay();
            this.PDay33 = new MyTasks.PlannerDay();
            this.PDay23 = new MyTasks.PlannerDay();
            this.PDay13 = new MyTasks.PlannerDay();
            this.PDay62 = new MyTasks.PlannerDay();
            this.PDay52 = new MyTasks.PlannerDay();
            this.PDay42 = new MyTasks.PlannerDay();
            this.PDay32 = new MyTasks.PlannerDay();
            this.PDay22 = new MyTasks.PlannerDay();
            this.PDay12 = new MyTasks.PlannerDay();
            this.PDay04 = new MyTasks.PlannerDay();
            this.PDay03 = new MyTasks.PlannerDay();
            this.PDay02 = new MyTasks.PlannerDay();
            this.PDay61 = new MyTasks.PlannerDay();
            this.PDay51 = new MyTasks.PlannerDay();
            this.PDay41 = new MyTasks.PlannerDay();
            this.PDay31 = new MyTasks.PlannerDay();
            this.PDay21 = new MyTasks.PlannerDay();
            this.PDay11 = new MyTasks.PlannerDay();
            this.PDay01 = new MyTasks.PlannerDay();
            this.PDay60 = new MyTasks.PlannerDay();
            this.PDay50 = new MyTasks.PlannerDay();
            this.PDay40 = new MyTasks.PlannerDay();
            this.PDay30 = new MyTasks.PlannerDay();
            this.PDay20 = new MyTasks.PlannerDay();
            this.PDay10 = new MyTasks.PlannerDay();
            this.PDay00 = new MyTasks.PlannerDay();
            this.statusBar.SuspendLayout();
            this.groupTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.dgvContextMenu.SuspendLayout();
            this.groupShortTermPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 605);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1277, 24);
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
            this.groupTaskList.Size = new System.Drawing.Size(661, 530);
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
            this.lblDescription.Size = new System.Drawing.Size(502, 30);
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
            this.dgvTasks.Size = new System.Drawing.Size(630, 450);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_CellMouseDown);
            this.dgvTasks.Click += new System.EventHandler(this.dgvTasks_Click);
            this.dgvTasks.DoubleClick += new System.EventHandler(this.dgvTasks_DoubleClick);
            this.dgvTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTasks_KeyDown);
            // 
            // dgvContextMenu
            // 
            this.dgvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeTask,
            this.editTaskTSMenu});
            this.dgvContextMenu.Name = "dgvContextMenu";
            this.dgvContextMenu.Size = new System.Drawing.Size(181, 70);
            this.dgvContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvContextMenu_ItemClicked);
            // 
            // completeTask
            // 
            this.completeTask.Image = global::MyTasks.Properties.Resources.StatusOffline_16x;
            this.completeTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeTask.Name = "completeTask";
            this.completeTask.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.completeTask.Size = new System.Drawing.Size(180, 22);
            this.completeTask.Text = "Complete task";
            // 
            // groupShortTermPlan
            // 
            this.groupShortTermPlan.Controls.Add(this.PDay64);
            this.groupShortTermPlan.Controls.Add(this.PDay54);
            this.groupShortTermPlan.Controls.Add(this.PDay44);
            this.groupShortTermPlan.Controls.Add(this.PDay34);
            this.groupShortTermPlan.Controls.Add(this.PDay24);
            this.groupShortTermPlan.Controls.Add(this.PDay14);
            this.groupShortTermPlan.Controls.Add(this.PDay63);
            this.groupShortTermPlan.Controls.Add(this.PDay53);
            this.groupShortTermPlan.Controls.Add(this.PDay43);
            this.groupShortTermPlan.Controls.Add(this.PDay33);
            this.groupShortTermPlan.Controls.Add(this.PDay23);
            this.groupShortTermPlan.Controls.Add(this.PDay13);
            this.groupShortTermPlan.Controls.Add(this.PDay62);
            this.groupShortTermPlan.Controls.Add(this.PDay52);
            this.groupShortTermPlan.Controls.Add(this.PDay42);
            this.groupShortTermPlan.Controls.Add(this.PDay32);
            this.groupShortTermPlan.Controls.Add(this.PDay22);
            this.groupShortTermPlan.Controls.Add(this.PDay12);
            this.groupShortTermPlan.Controls.Add(this.PDay04);
            this.groupShortTermPlan.Controls.Add(this.PDay03);
            this.groupShortTermPlan.Controls.Add(this.PDay02);
            this.groupShortTermPlan.Controls.Add(this.PDay61);
            this.groupShortTermPlan.Controls.Add(this.PDay51);
            this.groupShortTermPlan.Controls.Add(this.PDay41);
            this.groupShortTermPlan.Controls.Add(this.PDay31);
            this.groupShortTermPlan.Controls.Add(this.PDay21);
            this.groupShortTermPlan.Controls.Add(this.PDay11);
            this.groupShortTermPlan.Controls.Add(this.PDay01);
            this.groupShortTermPlan.Controls.Add(this.PDay60);
            this.groupShortTermPlan.Controls.Add(this.PDay50);
            this.groupShortTermPlan.Controls.Add(this.PDay40);
            this.groupShortTermPlan.Controls.Add(this.PDay30);
            this.groupShortTermPlan.Controls.Add(this.PDay20);
            this.groupShortTermPlan.Controls.Add(this.PDay10);
            this.groupShortTermPlan.Controls.Add(this.PDay00);
            this.groupShortTermPlan.Controls.Add(this.lblSaturday);
            this.groupShortTermPlan.Controls.Add(this.lblFriday);
            this.groupShortTermPlan.Controls.Add(this.lblThursday);
            this.groupShortTermPlan.Controls.Add(this.lblWednesday);
            this.groupShortTermPlan.Controls.Add(this.lblTuesday);
            this.groupShortTermPlan.Controls.Add(this.lblMonday);
            this.groupShortTermPlan.Controls.Add(this.lblSunday);
            this.groupShortTermPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupShortTermPlan.Location = new System.Drawing.Point(679, 62);
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
            this.lblAbout.Location = new System.Drawing.Point(1207, 17);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(64, 20);
            this.lblAbout.TabIndex = 7;
            this.lblAbout.TabStop = true;
            this.lblAbout.Text = "About...";
            this.lblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbout_LinkClicked);
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
            // editTaskTSMenu
            // 
            this.editTaskTSMenu.Image = global::MyTasks.Properties.Resources.ASX_Edit_blue_16x;
            this.editTaskTSMenu.Name = "editTaskTSMenu";
            this.editTaskTSMenu.Size = new System.Drawing.Size(180, 22);
            this.editTaskTSMenu.Text = "Edit task";
            // 
            // PDay64
            // 
            this.PDay64.BackColor = System.Drawing.Color.Gray;
            this.PDay64.Date = new System.DateTime(((long)(0)));
            this.PDay64.High = 0;
            this.PDay64.Highlight = false;
            this.PDay64.Location = new System.Drawing.Point(495, 425);
            this.PDay64.Low = 0;
            this.PDay64.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay64.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay64.Name = "PDay64";
            this.PDay64.Normal = 0;
            this.PDay64.Padding = new System.Windows.Forms.Padding(1);
            this.PDay64.Size = new System.Drawing.Size(80, 90);
            this.PDay64.TabIndex = 76;
            // 
            // PDay54
            // 
            this.PDay54.BackColor = System.Drawing.Color.Gray;
            this.PDay54.Date = new System.DateTime(((long)(0)));
            this.PDay54.High = 0;
            this.PDay54.Highlight = false;
            this.PDay54.Location = new System.Drawing.Point(415, 425);
            this.PDay54.Low = 0;
            this.PDay54.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay54.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay54.Name = "PDay54";
            this.PDay54.Normal = 0;
            this.PDay54.Padding = new System.Windows.Forms.Padding(1);
            this.PDay54.Size = new System.Drawing.Size(80, 90);
            this.PDay54.TabIndex = 75;
            // 
            // PDay44
            // 
            this.PDay44.BackColor = System.Drawing.Color.Gray;
            this.PDay44.Date = new System.DateTime(((long)(0)));
            this.PDay44.High = 0;
            this.PDay44.Highlight = false;
            this.PDay44.Location = new System.Drawing.Point(335, 425);
            this.PDay44.Low = 0;
            this.PDay44.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay44.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay44.Name = "PDay44";
            this.PDay44.Normal = 0;
            this.PDay44.Padding = new System.Windows.Forms.Padding(1);
            this.PDay44.Size = new System.Drawing.Size(80, 90);
            this.PDay44.TabIndex = 74;
            // 
            // PDay34
            // 
            this.PDay34.BackColor = System.Drawing.Color.Gray;
            this.PDay34.Date = new System.DateTime(((long)(0)));
            this.PDay34.High = 0;
            this.PDay34.Highlight = false;
            this.PDay34.Location = new System.Drawing.Point(255, 425);
            this.PDay34.Low = 0;
            this.PDay34.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay34.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay34.Name = "PDay34";
            this.PDay34.Normal = 0;
            this.PDay34.Padding = new System.Windows.Forms.Padding(1);
            this.PDay34.Size = new System.Drawing.Size(80, 90);
            this.PDay34.TabIndex = 73;
            // 
            // PDay24
            // 
            this.PDay24.BackColor = System.Drawing.Color.Gray;
            this.PDay24.Date = new System.DateTime(((long)(0)));
            this.PDay24.High = 0;
            this.PDay24.Highlight = false;
            this.PDay24.Location = new System.Drawing.Point(175, 425);
            this.PDay24.Low = 0;
            this.PDay24.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay24.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay24.Name = "PDay24";
            this.PDay24.Normal = 0;
            this.PDay24.Padding = new System.Windows.Forms.Padding(1);
            this.PDay24.Size = new System.Drawing.Size(80, 90);
            this.PDay24.TabIndex = 72;
            // 
            // PDay14
            // 
            this.PDay14.BackColor = System.Drawing.Color.Gray;
            this.PDay14.Date = new System.DateTime(((long)(0)));
            this.PDay14.High = 0;
            this.PDay14.Highlight = false;
            this.PDay14.Location = new System.Drawing.Point(95, 425);
            this.PDay14.Low = 0;
            this.PDay14.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay14.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay14.Name = "PDay14";
            this.PDay14.Normal = 0;
            this.PDay14.Padding = new System.Windows.Forms.Padding(1);
            this.PDay14.Size = new System.Drawing.Size(80, 90);
            this.PDay14.TabIndex = 71;
            // 
            // PDay63
            // 
            this.PDay63.BackColor = System.Drawing.Color.Gray;
            this.PDay63.Date = new System.DateTime(((long)(0)));
            this.PDay63.High = 0;
            this.PDay63.Highlight = false;
            this.PDay63.Location = new System.Drawing.Point(495, 335);
            this.PDay63.Low = 0;
            this.PDay63.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay63.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay63.Name = "PDay63";
            this.PDay63.Normal = 0;
            this.PDay63.Padding = new System.Windows.Forms.Padding(1);
            this.PDay63.Size = new System.Drawing.Size(80, 90);
            this.PDay63.TabIndex = 70;
            // 
            // PDay53
            // 
            this.PDay53.BackColor = System.Drawing.Color.Gray;
            this.PDay53.Date = new System.DateTime(((long)(0)));
            this.PDay53.High = 0;
            this.PDay53.Highlight = false;
            this.PDay53.Location = new System.Drawing.Point(415, 335);
            this.PDay53.Low = 0;
            this.PDay53.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay53.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay53.Name = "PDay53";
            this.PDay53.Normal = 0;
            this.PDay53.Padding = new System.Windows.Forms.Padding(1);
            this.PDay53.Size = new System.Drawing.Size(80, 90);
            this.PDay53.TabIndex = 69;
            // 
            // PDay43
            // 
            this.PDay43.BackColor = System.Drawing.Color.Gray;
            this.PDay43.Date = new System.DateTime(((long)(0)));
            this.PDay43.High = 0;
            this.PDay43.Highlight = false;
            this.PDay43.Location = new System.Drawing.Point(335, 335);
            this.PDay43.Low = 0;
            this.PDay43.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay43.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay43.Name = "PDay43";
            this.PDay43.Normal = 0;
            this.PDay43.Padding = new System.Windows.Forms.Padding(1);
            this.PDay43.Size = new System.Drawing.Size(80, 90);
            this.PDay43.TabIndex = 68;
            // 
            // PDay33
            // 
            this.PDay33.BackColor = System.Drawing.Color.Gray;
            this.PDay33.Date = new System.DateTime(((long)(0)));
            this.PDay33.High = 0;
            this.PDay33.Highlight = false;
            this.PDay33.Location = new System.Drawing.Point(255, 335);
            this.PDay33.Low = 0;
            this.PDay33.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay33.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay33.Name = "PDay33";
            this.PDay33.Normal = 0;
            this.PDay33.Padding = new System.Windows.Forms.Padding(1);
            this.PDay33.Size = new System.Drawing.Size(80, 90);
            this.PDay33.TabIndex = 67;
            // 
            // PDay23
            // 
            this.PDay23.BackColor = System.Drawing.Color.Gray;
            this.PDay23.Date = new System.DateTime(((long)(0)));
            this.PDay23.High = 0;
            this.PDay23.Highlight = false;
            this.PDay23.Location = new System.Drawing.Point(175, 335);
            this.PDay23.Low = 0;
            this.PDay23.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay23.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay23.Name = "PDay23";
            this.PDay23.Normal = 0;
            this.PDay23.Padding = new System.Windows.Forms.Padding(1);
            this.PDay23.Size = new System.Drawing.Size(80, 90);
            this.PDay23.TabIndex = 66;
            // 
            // PDay13
            // 
            this.PDay13.BackColor = System.Drawing.Color.Gray;
            this.PDay13.Date = new System.DateTime(((long)(0)));
            this.PDay13.High = 0;
            this.PDay13.Highlight = false;
            this.PDay13.Location = new System.Drawing.Point(95, 335);
            this.PDay13.Low = 0;
            this.PDay13.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay13.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay13.Name = "PDay13";
            this.PDay13.Normal = 0;
            this.PDay13.Padding = new System.Windows.Forms.Padding(1);
            this.PDay13.Size = new System.Drawing.Size(80, 90);
            this.PDay13.TabIndex = 65;
            // 
            // PDay62
            // 
            this.PDay62.BackColor = System.Drawing.Color.Gray;
            this.PDay62.Date = new System.DateTime(((long)(0)));
            this.PDay62.High = 0;
            this.PDay62.Highlight = false;
            this.PDay62.Location = new System.Drawing.Point(495, 245);
            this.PDay62.Low = 0;
            this.PDay62.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay62.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay62.Name = "PDay62";
            this.PDay62.Normal = 0;
            this.PDay62.Padding = new System.Windows.Forms.Padding(1);
            this.PDay62.Size = new System.Drawing.Size(80, 90);
            this.PDay62.TabIndex = 64;
            // 
            // PDay52
            // 
            this.PDay52.BackColor = System.Drawing.Color.Gray;
            this.PDay52.Date = new System.DateTime(((long)(0)));
            this.PDay52.High = 0;
            this.PDay52.Highlight = false;
            this.PDay52.Location = new System.Drawing.Point(415, 245);
            this.PDay52.Low = 0;
            this.PDay52.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay52.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay52.Name = "PDay52";
            this.PDay52.Normal = 0;
            this.PDay52.Padding = new System.Windows.Forms.Padding(1);
            this.PDay52.Size = new System.Drawing.Size(80, 90);
            this.PDay52.TabIndex = 63;
            // 
            // PDay42
            // 
            this.PDay42.BackColor = System.Drawing.Color.Gray;
            this.PDay42.Date = new System.DateTime(((long)(0)));
            this.PDay42.High = 0;
            this.PDay42.Highlight = false;
            this.PDay42.Location = new System.Drawing.Point(335, 245);
            this.PDay42.Low = 0;
            this.PDay42.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay42.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay42.Name = "PDay42";
            this.PDay42.Normal = 0;
            this.PDay42.Padding = new System.Windows.Forms.Padding(1);
            this.PDay42.Size = new System.Drawing.Size(80, 90);
            this.PDay42.TabIndex = 62;
            // 
            // PDay32
            // 
            this.PDay32.BackColor = System.Drawing.Color.Gray;
            this.PDay32.Date = new System.DateTime(((long)(0)));
            this.PDay32.High = 0;
            this.PDay32.Highlight = false;
            this.PDay32.Location = new System.Drawing.Point(255, 245);
            this.PDay32.Low = 0;
            this.PDay32.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay32.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay32.Name = "PDay32";
            this.PDay32.Normal = 0;
            this.PDay32.Padding = new System.Windows.Forms.Padding(1);
            this.PDay32.Size = new System.Drawing.Size(80, 90);
            this.PDay32.TabIndex = 61;
            // 
            // PDay22
            // 
            this.PDay22.BackColor = System.Drawing.Color.Gray;
            this.PDay22.Date = new System.DateTime(((long)(0)));
            this.PDay22.High = 0;
            this.PDay22.Highlight = false;
            this.PDay22.Location = new System.Drawing.Point(175, 245);
            this.PDay22.Low = 0;
            this.PDay22.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay22.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay22.Name = "PDay22";
            this.PDay22.Normal = 0;
            this.PDay22.Padding = new System.Windows.Forms.Padding(1);
            this.PDay22.Size = new System.Drawing.Size(80, 90);
            this.PDay22.TabIndex = 60;
            // 
            // PDay12
            // 
            this.PDay12.BackColor = System.Drawing.Color.Gray;
            this.PDay12.Date = new System.DateTime(((long)(0)));
            this.PDay12.High = 0;
            this.PDay12.Highlight = false;
            this.PDay12.Location = new System.Drawing.Point(95, 245);
            this.PDay12.Low = 0;
            this.PDay12.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay12.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay12.Name = "PDay12";
            this.PDay12.Normal = 0;
            this.PDay12.Padding = new System.Windows.Forms.Padding(1);
            this.PDay12.Size = new System.Drawing.Size(80, 90);
            this.PDay12.TabIndex = 59;
            // 
            // PDay04
            // 
            this.PDay04.BackColor = System.Drawing.Color.Gray;
            this.PDay04.Date = new System.DateTime(((long)(0)));
            this.PDay04.High = 0;
            this.PDay04.Highlight = false;
            this.PDay04.Location = new System.Drawing.Point(15, 425);
            this.PDay04.Low = 0;
            this.PDay04.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay04.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay04.Name = "PDay04";
            this.PDay04.Normal = 0;
            this.PDay04.Padding = new System.Windows.Forms.Padding(1);
            this.PDay04.Size = new System.Drawing.Size(80, 90);
            this.PDay04.TabIndex = 58;
            // 
            // PDay03
            // 
            this.PDay03.BackColor = System.Drawing.Color.Gray;
            this.PDay03.Date = new System.DateTime(((long)(0)));
            this.PDay03.High = 0;
            this.PDay03.Highlight = false;
            this.PDay03.Location = new System.Drawing.Point(15, 335);
            this.PDay03.Low = 0;
            this.PDay03.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay03.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay03.Name = "PDay03";
            this.PDay03.Normal = 0;
            this.PDay03.Padding = new System.Windows.Forms.Padding(1);
            this.PDay03.Size = new System.Drawing.Size(80, 90);
            this.PDay03.TabIndex = 57;
            // 
            // PDay02
            // 
            this.PDay02.BackColor = System.Drawing.Color.Gray;
            this.PDay02.Date = new System.DateTime(((long)(0)));
            this.PDay02.High = 0;
            this.PDay02.Highlight = false;
            this.PDay02.Location = new System.Drawing.Point(15, 245);
            this.PDay02.Low = 0;
            this.PDay02.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay02.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay02.Name = "PDay02";
            this.PDay02.Normal = 0;
            this.PDay02.Padding = new System.Windows.Forms.Padding(1);
            this.PDay02.Size = new System.Drawing.Size(80, 90);
            this.PDay02.TabIndex = 56;
            // 
            // PDay61
            // 
            this.PDay61.BackColor = System.Drawing.Color.Gray;
            this.PDay61.Date = new System.DateTime(((long)(0)));
            this.PDay61.High = 0;
            this.PDay61.Highlight = false;
            this.PDay61.Location = new System.Drawing.Point(495, 155);
            this.PDay61.Low = 0;
            this.PDay61.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay61.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay61.Name = "PDay61";
            this.PDay61.Normal = 0;
            this.PDay61.Padding = new System.Windows.Forms.Padding(1);
            this.PDay61.Size = new System.Drawing.Size(80, 90);
            this.PDay61.TabIndex = 55;
            // 
            // PDay51
            // 
            this.PDay51.BackColor = System.Drawing.Color.Gray;
            this.PDay51.Date = new System.DateTime(((long)(0)));
            this.PDay51.High = 0;
            this.PDay51.Highlight = false;
            this.PDay51.Location = new System.Drawing.Point(415, 155);
            this.PDay51.Low = 0;
            this.PDay51.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay51.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay51.Name = "PDay51";
            this.PDay51.Normal = 0;
            this.PDay51.Padding = new System.Windows.Forms.Padding(1);
            this.PDay51.Size = new System.Drawing.Size(80, 90);
            this.PDay51.TabIndex = 54;
            // 
            // PDay41
            // 
            this.PDay41.BackColor = System.Drawing.Color.Gray;
            this.PDay41.Date = new System.DateTime(((long)(0)));
            this.PDay41.High = 0;
            this.PDay41.Highlight = false;
            this.PDay41.Location = new System.Drawing.Point(335, 155);
            this.PDay41.Low = 0;
            this.PDay41.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay41.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay41.Name = "PDay41";
            this.PDay41.Normal = 0;
            this.PDay41.Padding = new System.Windows.Forms.Padding(1);
            this.PDay41.Size = new System.Drawing.Size(80, 90);
            this.PDay41.TabIndex = 53;
            // 
            // PDay31
            // 
            this.PDay31.BackColor = System.Drawing.Color.Gray;
            this.PDay31.Date = new System.DateTime(((long)(0)));
            this.PDay31.High = 0;
            this.PDay31.Highlight = false;
            this.PDay31.Location = new System.Drawing.Point(255, 155);
            this.PDay31.Low = 0;
            this.PDay31.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay31.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay31.Name = "PDay31";
            this.PDay31.Normal = 0;
            this.PDay31.Padding = new System.Windows.Forms.Padding(1);
            this.PDay31.Size = new System.Drawing.Size(80, 90);
            this.PDay31.TabIndex = 52;
            // 
            // PDay21
            // 
            this.PDay21.BackColor = System.Drawing.Color.Gray;
            this.PDay21.Date = new System.DateTime(((long)(0)));
            this.PDay21.High = 0;
            this.PDay21.Highlight = false;
            this.PDay21.Location = new System.Drawing.Point(175, 155);
            this.PDay21.Low = 0;
            this.PDay21.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay21.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay21.Name = "PDay21";
            this.PDay21.Normal = 0;
            this.PDay21.Padding = new System.Windows.Forms.Padding(1);
            this.PDay21.Size = new System.Drawing.Size(80, 90);
            this.PDay21.TabIndex = 51;
            // 
            // PDay11
            // 
            this.PDay11.BackColor = System.Drawing.Color.Gray;
            this.PDay11.Date = new System.DateTime(((long)(0)));
            this.PDay11.High = 0;
            this.PDay11.Highlight = false;
            this.PDay11.Location = new System.Drawing.Point(95, 155);
            this.PDay11.Low = 0;
            this.PDay11.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay11.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay11.Name = "PDay11";
            this.PDay11.Normal = 0;
            this.PDay11.Padding = new System.Windows.Forms.Padding(1);
            this.PDay11.Size = new System.Drawing.Size(80, 90);
            this.PDay11.TabIndex = 50;
            // 
            // PDay01
            // 
            this.PDay01.BackColor = System.Drawing.Color.Gray;
            this.PDay01.Date = new System.DateTime(((long)(0)));
            this.PDay01.High = 0;
            this.PDay01.Highlight = false;
            this.PDay01.Location = new System.Drawing.Point(15, 155);
            this.PDay01.Low = 0;
            this.PDay01.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay01.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay01.Name = "PDay01";
            this.PDay01.Normal = 0;
            this.PDay01.Padding = new System.Windows.Forms.Padding(1);
            this.PDay01.Size = new System.Drawing.Size(80, 90);
            this.PDay01.TabIndex = 49;
            // 
            // PDay60
            // 
            this.PDay60.BackColor = System.Drawing.Color.Gray;
            this.PDay60.Date = new System.DateTime(((long)(0)));
            this.PDay60.High = 0;
            this.PDay60.Highlight = false;
            this.PDay60.Location = new System.Drawing.Point(495, 65);
            this.PDay60.Low = 0;
            this.PDay60.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay60.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay60.Name = "PDay60";
            this.PDay60.Normal = 0;
            this.PDay60.Padding = new System.Windows.Forms.Padding(1);
            this.PDay60.Size = new System.Drawing.Size(80, 90);
            this.PDay60.TabIndex = 48;
            // 
            // PDay50
            // 
            this.PDay50.BackColor = System.Drawing.Color.Gray;
            this.PDay50.Date = new System.DateTime(((long)(0)));
            this.PDay50.High = 0;
            this.PDay50.Highlight = false;
            this.PDay50.Location = new System.Drawing.Point(415, 65);
            this.PDay50.Low = 0;
            this.PDay50.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay50.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay50.Name = "PDay50";
            this.PDay50.Normal = 0;
            this.PDay50.Padding = new System.Windows.Forms.Padding(1);
            this.PDay50.Size = new System.Drawing.Size(80, 90);
            this.PDay50.TabIndex = 47;
            // 
            // PDay40
            // 
            this.PDay40.BackColor = System.Drawing.Color.Gray;
            this.PDay40.Date = new System.DateTime(((long)(0)));
            this.PDay40.High = 0;
            this.PDay40.Highlight = false;
            this.PDay40.Location = new System.Drawing.Point(335, 65);
            this.PDay40.Low = 0;
            this.PDay40.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay40.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay40.Name = "PDay40";
            this.PDay40.Normal = 0;
            this.PDay40.Padding = new System.Windows.Forms.Padding(1);
            this.PDay40.Size = new System.Drawing.Size(80, 90);
            this.PDay40.TabIndex = 46;
            // 
            // PDay30
            // 
            this.PDay30.BackColor = System.Drawing.Color.Gray;
            this.PDay30.Date = new System.DateTime(((long)(0)));
            this.PDay30.High = 0;
            this.PDay30.Highlight = false;
            this.PDay30.Location = new System.Drawing.Point(255, 65);
            this.PDay30.Low = 0;
            this.PDay30.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay30.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay30.Name = "PDay30";
            this.PDay30.Normal = 0;
            this.PDay30.Padding = new System.Windows.Forms.Padding(1);
            this.PDay30.Size = new System.Drawing.Size(80, 90);
            this.PDay30.TabIndex = 45;
            // 
            // PDay20
            // 
            this.PDay20.BackColor = System.Drawing.Color.Gray;
            this.PDay20.Date = new System.DateTime(((long)(0)));
            this.PDay20.High = 0;
            this.PDay20.Highlight = false;
            this.PDay20.Location = new System.Drawing.Point(175, 65);
            this.PDay20.Low = 0;
            this.PDay20.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay20.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay20.Name = "PDay20";
            this.PDay20.Normal = 0;
            this.PDay20.Padding = new System.Windows.Forms.Padding(1);
            this.PDay20.Size = new System.Drawing.Size(80, 90);
            this.PDay20.TabIndex = 44;
            // 
            // PDay10
            // 
            this.PDay10.BackColor = System.Drawing.Color.Gray;
            this.PDay10.Date = new System.DateTime(((long)(0)));
            this.PDay10.High = 0;
            this.PDay10.Highlight = false;
            this.PDay10.Location = new System.Drawing.Point(95, 65);
            this.PDay10.Low = 0;
            this.PDay10.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay10.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay10.Name = "PDay10";
            this.PDay10.Normal = 0;
            this.PDay10.Padding = new System.Windows.Forms.Padding(1);
            this.PDay10.Size = new System.Drawing.Size(80, 90);
            this.PDay10.TabIndex = 43;
            // 
            // PDay00
            // 
            this.PDay00.BackColor = System.Drawing.Color.Gray;
            this.PDay00.Date = new System.DateTime(((long)(0)));
            this.PDay00.High = 0;
            this.PDay00.Highlight = false;
            this.PDay00.Location = new System.Drawing.Point(15, 65);
            this.PDay00.Low = 0;
            this.PDay00.MaximumSize = new System.Drawing.Size(80, 90);
            this.PDay00.MinimumSize = new System.Drawing.Size(80, 90);
            this.PDay00.Name = "PDay00";
            this.PDay00.Normal = 0;
            this.PDay00.Padding = new System.Windows.Forms.Padding(1);
            this.PDay00.Size = new System.Drawing.Size(80, 90);
            this.PDay00.TabIndex = 42;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 629);
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
            this.dgvContextMenu.ResumeLayout(false);
            this.groupShortTermPlan.ResumeLayout(false);
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
        private PlannerDay PDay00;
        private PlannerDay PDay64;
        private PlannerDay PDay54;
        private PlannerDay PDay44;
        private PlannerDay PDay34;
        private PlannerDay PDay24;
        private PlannerDay PDay14;
        private PlannerDay PDay63;
        private PlannerDay PDay53;
        private PlannerDay PDay43;
        private PlannerDay PDay33;
        private PlannerDay PDay23;
        private PlannerDay PDay13;
        private PlannerDay PDay62;
        private PlannerDay PDay52;
        private PlannerDay PDay42;
        private PlannerDay PDay32;
        private PlannerDay PDay22;
        private PlannerDay PDay12;
        private PlannerDay PDay04;
        private PlannerDay PDay03;
        private PlannerDay PDay02;
        private PlannerDay PDay61;
        private PlannerDay PDay51;
        private PlannerDay PDay41;
        private PlannerDay PDay31;
        private PlannerDay PDay21;
        private PlannerDay PDay11;
        private PlannerDay PDay01;
        private PlannerDay PDay60;
        private PlannerDay PDay50;
        private PlannerDay PDay40;
        private PlannerDay PDay30;
        private PlannerDay PDay20;
        private PlannerDay PDay10;
        private System.Windows.Forms.ToolStripMenuItem editTaskTSMenu;
    }
}

