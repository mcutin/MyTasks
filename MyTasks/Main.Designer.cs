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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOrderBy = new System.Windows.Forms.Label();
            this.radioDueDate = new System.Windows.Forms.RadioButton();
            this.radioPriority = new System.Windows.Forms.RadioButton();
            this.groupTaskList = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.groupShortTermPlan = new System.Windows.Forms.GroupBox();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.rtfDay57 = new System.Windows.Forms.RichTextBox();
            this.rtfDay47 = new System.Windows.Forms.RichTextBox();
            this.rtfDay37 = new System.Windows.Forms.RichTextBox();
            this.rtfDay56 = new System.Windows.Forms.RichTextBox();
            this.rtfDay46 = new System.Windows.Forms.RichTextBox();
            this.rtfDay36 = new System.Windows.Forms.RichTextBox();
            this.rtfDay55 = new System.Windows.Forms.RichTextBox();
            this.rtfDay45 = new System.Windows.Forms.RichTextBox();
            this.rtfDay35 = new System.Windows.Forms.RichTextBox();
            this.rtfDay54 = new System.Windows.Forms.RichTextBox();
            this.rtfDay44 = new System.Windows.Forms.RichTextBox();
            this.rtfDay34 = new System.Windows.Forms.RichTextBox();
            this.rtfDay53 = new System.Windows.Forms.RichTextBox();
            this.rtfDay43 = new System.Windows.Forms.RichTextBox();
            this.rtfDay33 = new System.Windows.Forms.RichTextBox();
            this.rtfDay52 = new System.Windows.Forms.RichTextBox();
            this.rtfDay42 = new System.Windows.Forms.RichTextBox();
            this.rtfDay32 = new System.Windows.Forms.RichTextBox();
            this.rtfDay27 = new System.Windows.Forms.RichTextBox();
            this.rtfDay26 = new System.Windows.Forms.RichTextBox();
            this.rtfDay25 = new System.Windows.Forms.RichTextBox();
            this.rtfDay24 = new System.Windows.Forms.RichTextBox();
            this.rtfDay23 = new System.Windows.Forms.RichTextBox();
            this.rtfDay22 = new System.Windows.Forms.RichTextBox();
            this.rtfDay17 = new System.Windows.Forms.RichTextBox();
            this.rtfDay16 = new System.Windows.Forms.RichTextBox();
            this.rtfDay15 = new System.Windows.Forms.RichTextBox();
            this.rtfDay14 = new System.Windows.Forms.RichTextBox();
            this.rtfDay13 = new System.Windows.Forms.RichTextBox();
            this.rtfDay12 = new System.Windows.Forms.RichTextBox();
            this.rtfDay51 = new System.Windows.Forms.RichTextBox();
            this.rtfDay41 = new System.Windows.Forms.RichTextBox();
            this.rtfDay31 = new System.Windows.Forms.RichTextBox();
            this.rtfDay21 = new System.Windows.Forms.RichTextBox();
            this.rtfDay11 = new System.Windows.Forms.RichTextBox();
            this.lblDueTo = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.groupTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.groupShortTermPlan.SuspendLayout();
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
            this.radioDueDate.Size = new System.Drawing.Size(93, 24);
            this.radioDueDate.TabIndex = 3;
            this.radioDueDate.TabStop = true;
            this.radioDueDate.Text = "Due date";
            this.radioDueDate.UseVisualStyleBackColor = true;
            // 
            // radioPriority
            // 
            this.radioPriority.AutoSize = true;
            this.radioPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPriority.Location = new System.Drawing.Point(427, 15);
            this.radioPriority.Name = "radioPriority";
            this.radioPriority.Size = new System.Drawing.Size(211, 24);
            this.radioPriority.TabIndex = 4;
            this.radioPriority.Text = "Priority first, then due date";
            this.radioPriority.UseVisualStyleBackColor = true;
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
            this.dgvTasks.RowTemplate.Height = 25;
            this.dgvTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ShowCellToolTips = false;
            this.dgvTasks.ShowEditingIcon = false;
            this.dgvTasks.Size = new System.Drawing.Size(392, 450);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentDoubleClick);
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
            this.groupShortTermPlan.Controls.Add(this.rtfDay57);
            this.groupShortTermPlan.Controls.Add(this.rtfDay47);
            this.groupShortTermPlan.Controls.Add(this.rtfDay37);
            this.groupShortTermPlan.Controls.Add(this.rtfDay56);
            this.groupShortTermPlan.Controls.Add(this.rtfDay46);
            this.groupShortTermPlan.Controls.Add(this.rtfDay36);
            this.groupShortTermPlan.Controls.Add(this.rtfDay55);
            this.groupShortTermPlan.Controls.Add(this.rtfDay45);
            this.groupShortTermPlan.Controls.Add(this.rtfDay35);
            this.groupShortTermPlan.Controls.Add(this.rtfDay54);
            this.groupShortTermPlan.Controls.Add(this.rtfDay44);
            this.groupShortTermPlan.Controls.Add(this.rtfDay34);
            this.groupShortTermPlan.Controls.Add(this.rtfDay53);
            this.groupShortTermPlan.Controls.Add(this.rtfDay43);
            this.groupShortTermPlan.Controls.Add(this.rtfDay33);
            this.groupShortTermPlan.Controls.Add(this.rtfDay52);
            this.groupShortTermPlan.Controls.Add(this.rtfDay42);
            this.groupShortTermPlan.Controls.Add(this.rtfDay32);
            this.groupShortTermPlan.Controls.Add(this.rtfDay27);
            this.groupShortTermPlan.Controls.Add(this.rtfDay26);
            this.groupShortTermPlan.Controls.Add(this.rtfDay25);
            this.groupShortTermPlan.Controls.Add(this.rtfDay24);
            this.groupShortTermPlan.Controls.Add(this.rtfDay23);
            this.groupShortTermPlan.Controls.Add(this.rtfDay22);
            this.groupShortTermPlan.Controls.Add(this.rtfDay17);
            this.groupShortTermPlan.Controls.Add(this.rtfDay16);
            this.groupShortTermPlan.Controls.Add(this.rtfDay15);
            this.groupShortTermPlan.Controls.Add(this.rtfDay14);
            this.groupShortTermPlan.Controls.Add(this.rtfDay13);
            this.groupShortTermPlan.Controls.Add(this.rtfDay12);
            this.groupShortTermPlan.Controls.Add(this.rtfDay51);
            this.groupShortTermPlan.Controls.Add(this.rtfDay41);
            this.groupShortTermPlan.Controls.Add(this.rtfDay31);
            this.groupShortTermPlan.Controls.Add(this.rtfDay21);
            this.groupShortTermPlan.Controls.Add(this.rtfDay11);
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
            // rtfDay57
            // 
            this.rtfDay57.BackColor = System.Drawing.Color.White;
            this.rtfDay57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay57.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay57.Location = new System.Drawing.Point(495, 425);
            this.rtfDay57.Name = "rtfDay57";
            this.rtfDay57.ReadOnly = true;
            this.rtfDay57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay57.Size = new System.Drawing.Size(80, 90);
            this.rtfDay57.TabIndex = 34;
            this.rtfDay57.Text = "";
            // 
            // rtfDay47
            // 
            this.rtfDay47.BackColor = System.Drawing.Color.White;
            this.rtfDay47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay47.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay47.Location = new System.Drawing.Point(495, 335);
            this.rtfDay47.Name = "rtfDay47";
            this.rtfDay47.ReadOnly = true;
            this.rtfDay47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay47.Size = new System.Drawing.Size(80, 90);
            this.rtfDay47.TabIndex = 33;
            this.rtfDay47.Text = "";
            // 
            // rtfDay37
            // 
            this.rtfDay37.BackColor = System.Drawing.Color.White;
            this.rtfDay37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay37.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay37.Location = new System.Drawing.Point(495, 245);
            this.rtfDay37.Name = "rtfDay37";
            this.rtfDay37.ReadOnly = true;
            this.rtfDay37.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay37.Size = new System.Drawing.Size(80, 90);
            this.rtfDay37.TabIndex = 32;
            this.rtfDay37.Text = "";
            // 
            // rtfDay56
            // 
            this.rtfDay56.BackColor = System.Drawing.Color.White;
            this.rtfDay56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay56.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay56.Location = new System.Drawing.Point(415, 425);
            this.rtfDay56.Name = "rtfDay56";
            this.rtfDay56.ReadOnly = true;
            this.rtfDay56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay56.Size = new System.Drawing.Size(80, 90);
            this.rtfDay56.TabIndex = 31;
            this.rtfDay56.Text = "";
            // 
            // rtfDay46
            // 
            this.rtfDay46.BackColor = System.Drawing.Color.White;
            this.rtfDay46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay46.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay46.Location = new System.Drawing.Point(415, 335);
            this.rtfDay46.Name = "rtfDay46";
            this.rtfDay46.ReadOnly = true;
            this.rtfDay46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay46.Size = new System.Drawing.Size(80, 90);
            this.rtfDay46.TabIndex = 30;
            this.rtfDay46.Text = "";
            // 
            // rtfDay36
            // 
            this.rtfDay36.BackColor = System.Drawing.Color.White;
            this.rtfDay36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay36.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay36.Location = new System.Drawing.Point(415, 245);
            this.rtfDay36.Name = "rtfDay36";
            this.rtfDay36.ReadOnly = true;
            this.rtfDay36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay36.Size = new System.Drawing.Size(80, 90);
            this.rtfDay36.TabIndex = 29;
            this.rtfDay36.Text = "";
            // 
            // rtfDay55
            // 
            this.rtfDay55.BackColor = System.Drawing.Color.White;
            this.rtfDay55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay55.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay55.Location = new System.Drawing.Point(335, 425);
            this.rtfDay55.Name = "rtfDay55";
            this.rtfDay55.ReadOnly = true;
            this.rtfDay55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay55.Size = new System.Drawing.Size(80, 90);
            this.rtfDay55.TabIndex = 28;
            this.rtfDay55.Text = "";
            // 
            // rtfDay45
            // 
            this.rtfDay45.BackColor = System.Drawing.Color.White;
            this.rtfDay45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay45.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay45.Location = new System.Drawing.Point(335, 335);
            this.rtfDay45.Name = "rtfDay45";
            this.rtfDay45.ReadOnly = true;
            this.rtfDay45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay45.Size = new System.Drawing.Size(80, 90);
            this.rtfDay45.TabIndex = 27;
            this.rtfDay45.Text = "";
            // 
            // rtfDay35
            // 
            this.rtfDay35.BackColor = System.Drawing.Color.White;
            this.rtfDay35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay35.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay35.Location = new System.Drawing.Point(335, 245);
            this.rtfDay35.Name = "rtfDay35";
            this.rtfDay35.ReadOnly = true;
            this.rtfDay35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay35.Size = new System.Drawing.Size(80, 90);
            this.rtfDay35.TabIndex = 26;
            this.rtfDay35.Text = "";
            // 
            // rtfDay54
            // 
            this.rtfDay54.BackColor = System.Drawing.Color.White;
            this.rtfDay54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay54.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay54.Location = new System.Drawing.Point(255, 425);
            this.rtfDay54.Name = "rtfDay54";
            this.rtfDay54.ReadOnly = true;
            this.rtfDay54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay54.Size = new System.Drawing.Size(80, 90);
            this.rtfDay54.TabIndex = 25;
            this.rtfDay54.Text = "";
            // 
            // rtfDay44
            // 
            this.rtfDay44.BackColor = System.Drawing.Color.White;
            this.rtfDay44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay44.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay44.Location = new System.Drawing.Point(255, 335);
            this.rtfDay44.Name = "rtfDay44";
            this.rtfDay44.ReadOnly = true;
            this.rtfDay44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay44.Size = new System.Drawing.Size(80, 90);
            this.rtfDay44.TabIndex = 24;
            this.rtfDay44.Text = "";
            // 
            // rtfDay34
            // 
            this.rtfDay34.BackColor = System.Drawing.Color.White;
            this.rtfDay34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay34.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay34.Location = new System.Drawing.Point(255, 245);
            this.rtfDay34.Name = "rtfDay34";
            this.rtfDay34.ReadOnly = true;
            this.rtfDay34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay34.Size = new System.Drawing.Size(80, 90);
            this.rtfDay34.TabIndex = 23;
            this.rtfDay34.Text = "";
            // 
            // rtfDay53
            // 
            this.rtfDay53.BackColor = System.Drawing.Color.White;
            this.rtfDay53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay53.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay53.Location = new System.Drawing.Point(175, 425);
            this.rtfDay53.Name = "rtfDay53";
            this.rtfDay53.ReadOnly = true;
            this.rtfDay53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay53.Size = new System.Drawing.Size(80, 90);
            this.rtfDay53.TabIndex = 22;
            this.rtfDay53.Text = "";
            // 
            // rtfDay43
            // 
            this.rtfDay43.BackColor = System.Drawing.Color.White;
            this.rtfDay43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay43.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay43.Location = new System.Drawing.Point(175, 335);
            this.rtfDay43.Name = "rtfDay43";
            this.rtfDay43.ReadOnly = true;
            this.rtfDay43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay43.Size = new System.Drawing.Size(80, 90);
            this.rtfDay43.TabIndex = 21;
            this.rtfDay43.Text = "";
            // 
            // rtfDay33
            // 
            this.rtfDay33.BackColor = System.Drawing.Color.White;
            this.rtfDay33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay33.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay33.Location = new System.Drawing.Point(175, 245);
            this.rtfDay33.Name = "rtfDay33";
            this.rtfDay33.ReadOnly = true;
            this.rtfDay33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay33.Size = new System.Drawing.Size(80, 90);
            this.rtfDay33.TabIndex = 20;
            this.rtfDay33.Text = "";
            // 
            // rtfDay52
            // 
            this.rtfDay52.BackColor = System.Drawing.Color.White;
            this.rtfDay52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay52.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay52.Location = new System.Drawing.Point(95, 425);
            this.rtfDay52.Name = "rtfDay52";
            this.rtfDay52.ReadOnly = true;
            this.rtfDay52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay52.Size = new System.Drawing.Size(80, 90);
            this.rtfDay52.TabIndex = 19;
            this.rtfDay52.Text = "";
            // 
            // rtfDay42
            // 
            this.rtfDay42.BackColor = System.Drawing.Color.White;
            this.rtfDay42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay42.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay42.Location = new System.Drawing.Point(95, 335);
            this.rtfDay42.Name = "rtfDay42";
            this.rtfDay42.ReadOnly = true;
            this.rtfDay42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay42.Size = new System.Drawing.Size(80, 90);
            this.rtfDay42.TabIndex = 18;
            this.rtfDay42.Text = "";
            // 
            // rtfDay32
            // 
            this.rtfDay32.BackColor = System.Drawing.Color.White;
            this.rtfDay32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay32.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay32.Location = new System.Drawing.Point(95, 245);
            this.rtfDay32.Name = "rtfDay32";
            this.rtfDay32.ReadOnly = true;
            this.rtfDay32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay32.Size = new System.Drawing.Size(80, 90);
            this.rtfDay32.TabIndex = 17;
            this.rtfDay32.Text = "";
            // 
            // rtfDay27
            // 
            this.rtfDay27.BackColor = System.Drawing.Color.White;
            this.rtfDay27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay27.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay27.Location = new System.Drawing.Point(495, 155);
            this.rtfDay27.Name = "rtfDay27";
            this.rtfDay27.ReadOnly = true;
            this.rtfDay27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay27.Size = new System.Drawing.Size(80, 90);
            this.rtfDay27.TabIndex = 16;
            this.rtfDay27.Text = "";
            // 
            // rtfDay26
            // 
            this.rtfDay26.BackColor = System.Drawing.Color.White;
            this.rtfDay26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay26.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay26.Location = new System.Drawing.Point(415, 155);
            this.rtfDay26.Name = "rtfDay26";
            this.rtfDay26.ReadOnly = true;
            this.rtfDay26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay26.Size = new System.Drawing.Size(80, 90);
            this.rtfDay26.TabIndex = 15;
            this.rtfDay26.Text = "";
            // 
            // rtfDay25
            // 
            this.rtfDay25.BackColor = System.Drawing.Color.White;
            this.rtfDay25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay25.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay25.Location = new System.Drawing.Point(335, 155);
            this.rtfDay25.Name = "rtfDay25";
            this.rtfDay25.ReadOnly = true;
            this.rtfDay25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay25.Size = new System.Drawing.Size(80, 90);
            this.rtfDay25.TabIndex = 14;
            this.rtfDay25.Text = "";
            // 
            // rtfDay24
            // 
            this.rtfDay24.BackColor = System.Drawing.Color.White;
            this.rtfDay24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay24.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay24.Location = new System.Drawing.Point(255, 155);
            this.rtfDay24.Name = "rtfDay24";
            this.rtfDay24.ReadOnly = true;
            this.rtfDay24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay24.Size = new System.Drawing.Size(80, 90);
            this.rtfDay24.TabIndex = 13;
            this.rtfDay24.Text = "";
            // 
            // rtfDay23
            // 
            this.rtfDay23.BackColor = System.Drawing.Color.White;
            this.rtfDay23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay23.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay23.Location = new System.Drawing.Point(175, 155);
            this.rtfDay23.Name = "rtfDay23";
            this.rtfDay23.ReadOnly = true;
            this.rtfDay23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay23.Size = new System.Drawing.Size(80, 90);
            this.rtfDay23.TabIndex = 12;
            this.rtfDay23.Text = "";
            // 
            // rtfDay22
            // 
            this.rtfDay22.BackColor = System.Drawing.Color.White;
            this.rtfDay22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay22.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay22.Location = new System.Drawing.Point(95, 155);
            this.rtfDay22.Name = "rtfDay22";
            this.rtfDay22.ReadOnly = true;
            this.rtfDay22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay22.Size = new System.Drawing.Size(80, 90);
            this.rtfDay22.TabIndex = 11;
            this.rtfDay22.Text = "";
            // 
            // rtfDay17
            // 
            this.rtfDay17.BackColor = System.Drawing.Color.White;
            this.rtfDay17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay17.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay17.Location = new System.Drawing.Point(495, 65);
            this.rtfDay17.Name = "rtfDay17";
            this.rtfDay17.ReadOnly = true;
            this.rtfDay17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay17.Size = new System.Drawing.Size(80, 90);
            this.rtfDay17.TabIndex = 10;
            this.rtfDay17.Text = "";
            // 
            // rtfDay16
            // 
            this.rtfDay16.BackColor = System.Drawing.Color.White;
            this.rtfDay16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay16.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay16.Location = new System.Drawing.Point(415, 65);
            this.rtfDay16.Name = "rtfDay16";
            this.rtfDay16.ReadOnly = true;
            this.rtfDay16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay16.Size = new System.Drawing.Size(80, 90);
            this.rtfDay16.TabIndex = 9;
            this.rtfDay16.Text = "";
            // 
            // rtfDay15
            // 
            this.rtfDay15.BackColor = System.Drawing.Color.White;
            this.rtfDay15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay15.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay15.Location = new System.Drawing.Point(335, 65);
            this.rtfDay15.Name = "rtfDay15";
            this.rtfDay15.ReadOnly = true;
            this.rtfDay15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay15.Size = new System.Drawing.Size(80, 90);
            this.rtfDay15.TabIndex = 8;
            this.rtfDay15.Text = "";
            // 
            // rtfDay14
            // 
            this.rtfDay14.BackColor = System.Drawing.Color.White;
            this.rtfDay14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay14.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay14.Location = new System.Drawing.Point(255, 65);
            this.rtfDay14.Name = "rtfDay14";
            this.rtfDay14.ReadOnly = true;
            this.rtfDay14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay14.Size = new System.Drawing.Size(80, 90);
            this.rtfDay14.TabIndex = 7;
            this.rtfDay14.Text = "";
            // 
            // rtfDay13
            // 
            this.rtfDay13.BackColor = System.Drawing.Color.White;
            this.rtfDay13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay13.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay13.Location = new System.Drawing.Point(175, 65);
            this.rtfDay13.Name = "rtfDay13";
            this.rtfDay13.ReadOnly = true;
            this.rtfDay13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay13.Size = new System.Drawing.Size(80, 90);
            this.rtfDay13.TabIndex = 6;
            this.rtfDay13.Text = "";
            // 
            // rtfDay12
            // 
            this.rtfDay12.BackColor = System.Drawing.Color.White;
            this.rtfDay12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay12.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay12.Location = new System.Drawing.Point(95, 65);
            this.rtfDay12.Name = "rtfDay12";
            this.rtfDay12.ReadOnly = true;
            this.rtfDay12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay12.Size = new System.Drawing.Size(80, 90);
            this.rtfDay12.TabIndex = 5;
            this.rtfDay12.Text = "";
            // 
            // rtfDay51
            // 
            this.rtfDay51.BackColor = System.Drawing.Color.White;
            this.rtfDay51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay51.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay51.Location = new System.Drawing.Point(15, 425);
            this.rtfDay51.Name = "rtfDay51";
            this.rtfDay51.ReadOnly = true;
            this.rtfDay51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay51.Size = new System.Drawing.Size(80, 90);
            this.rtfDay51.TabIndex = 4;
            this.rtfDay51.Text = "";
            // 
            // rtfDay41
            // 
            this.rtfDay41.BackColor = System.Drawing.Color.White;
            this.rtfDay41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay41.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay41.Location = new System.Drawing.Point(15, 335);
            this.rtfDay41.Name = "rtfDay41";
            this.rtfDay41.ReadOnly = true;
            this.rtfDay41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay41.Size = new System.Drawing.Size(80, 90);
            this.rtfDay41.TabIndex = 3;
            this.rtfDay41.Text = "";
            // 
            // rtfDay31
            // 
            this.rtfDay31.BackColor = System.Drawing.Color.White;
            this.rtfDay31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay31.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay31.Location = new System.Drawing.Point(15, 245);
            this.rtfDay31.Name = "rtfDay31";
            this.rtfDay31.ReadOnly = true;
            this.rtfDay31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay31.Size = new System.Drawing.Size(80, 90);
            this.rtfDay31.TabIndex = 2;
            this.rtfDay31.Text = "";
            // 
            // rtfDay21
            // 
            this.rtfDay21.BackColor = System.Drawing.Color.White;
            this.rtfDay21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay21.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay21.Location = new System.Drawing.Point(15, 155);
            this.rtfDay21.Name = "rtfDay21";
            this.rtfDay21.ReadOnly = true;
            this.rtfDay21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay21.Size = new System.Drawing.Size(80, 90);
            this.rtfDay21.TabIndex = 1;
            this.rtfDay21.Text = "";
            // 
            // rtfDay11
            // 
            this.rtfDay11.BackColor = System.Drawing.Color.White;
            this.rtfDay11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay11.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay11.Location = new System.Drawing.Point(15, 65);
            this.rtfDay11.Name = "rtfDay11";
            this.rtfDay11.ReadOnly = true;
            this.rtfDay11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay11.Size = new System.Drawing.Size(80, 90);
            this.rtfDay11.TabIndex = 0;
            this.rtfDay11.Text = "";
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
        private System.Windows.Forms.RichTextBox rtfDay11;
        private System.Windows.Forms.RichTextBox rtfDay17;
        private System.Windows.Forms.RichTextBox rtfDay16;
        private System.Windows.Forms.RichTextBox rtfDay15;
        private System.Windows.Forms.RichTextBox rtfDay14;
        private System.Windows.Forms.RichTextBox rtfDay13;
        private System.Windows.Forms.RichTextBox rtfDay12;
        private System.Windows.Forms.RichTextBox rtfDay51;
        private System.Windows.Forms.RichTextBox rtfDay41;
        private System.Windows.Forms.RichTextBox rtfDay31;
        private System.Windows.Forms.RichTextBox rtfDay21;
        private System.Windows.Forms.RichTextBox rtfDay22;
        private System.Windows.Forms.RichTextBox rtfDay27;
        private System.Windows.Forms.RichTextBox rtfDay26;
        private System.Windows.Forms.RichTextBox rtfDay25;
        private System.Windows.Forms.RichTextBox rtfDay24;
        private System.Windows.Forms.RichTextBox rtfDay23;
        private System.Windows.Forms.RichTextBox rtfDay57;
        private System.Windows.Forms.RichTextBox rtfDay47;
        private System.Windows.Forms.RichTextBox rtfDay37;
        private System.Windows.Forms.RichTextBox rtfDay56;
        private System.Windows.Forms.RichTextBox rtfDay46;
        private System.Windows.Forms.RichTextBox rtfDay36;
        private System.Windows.Forms.RichTextBox rtfDay55;
        private System.Windows.Forms.RichTextBox rtfDay45;
        private System.Windows.Forms.RichTextBox rtfDay35;
        private System.Windows.Forms.RichTextBox rtfDay54;
        private System.Windows.Forms.RichTextBox rtfDay44;
        private System.Windows.Forms.RichTextBox rtfDay34;
        private System.Windows.Forms.RichTextBox rtfDay53;
        private System.Windows.Forms.RichTextBox rtfDay43;
        private System.Windows.Forms.RichTextBox rtfDay33;
        private System.Windows.Forms.RichTextBox rtfDay52;
        private System.Windows.Forms.RichTextBox rtfDay42;
        private System.Windows.Forms.RichTextBox rtfDay32;
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
    }
}

