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
            this.txtTaskList = new System.Windows.Forms.TextBox();
            this.groupShortTermPlan = new System.Windows.Forms.GroupBox();
            this.rtfDay11 = new System.Windows.Forms.RichTextBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.rtfDay21 = new System.Windows.Forms.RichTextBox();
            this.rtfDay31 = new System.Windows.Forms.RichTextBox();
            this.rtfDay41 = new System.Windows.Forms.RichTextBox();
            this.rtfDay51 = new System.Windows.Forms.RichTextBox();
            this.rtfDay12 = new System.Windows.Forms.RichTextBox();
            this.rtfDay13 = new System.Windows.Forms.RichTextBox();
            this.rtfDay14 = new System.Windows.Forms.RichTextBox();
            this.rtfDay15 = new System.Windows.Forms.RichTextBox();
            this.rtfDay16 = new System.Windows.Forms.RichTextBox();
            this.rtfDay17 = new System.Windows.Forms.RichTextBox();
            this.rtfDay22 = new System.Windows.Forms.RichTextBox();
            this.rtfDay23 = new System.Windows.Forms.RichTextBox();
            this.rtfDay24 = new System.Windows.Forms.RichTextBox();
            this.rtfDay25 = new System.Windows.Forms.RichTextBox();
            this.rtfDay26 = new System.Windows.Forms.RichTextBox();
            this.rtfDay27 = new System.Windows.Forms.RichTextBox();
            this.rtfDay32 = new System.Windows.Forms.RichTextBox();
            this.rtfDay42 = new System.Windows.Forms.RichTextBox();
            this.rtfDay52 = new System.Windows.Forms.RichTextBox();
            this.rtfDay33 = new System.Windows.Forms.RichTextBox();
            this.rtfDay43 = new System.Windows.Forms.RichTextBox();
            this.rtfDay53 = new System.Windows.Forms.RichTextBox();
            this.rtfDay34 = new System.Windows.Forms.RichTextBox();
            this.rtfDay44 = new System.Windows.Forms.RichTextBox();
            this.rtfDay54 = new System.Windows.Forms.RichTextBox();
            this.rtfDay35 = new System.Windows.Forms.RichTextBox();
            this.rtfDay45 = new System.Windows.Forms.RichTextBox();
            this.rtfDay55 = new System.Windows.Forms.RichTextBox();
            this.rtfDay36 = new System.Windows.Forms.RichTextBox();
            this.rtfDay46 = new System.Windows.Forms.RichTextBox();
            this.rtfDay56 = new System.Windows.Forms.RichTextBox();
            this.rtfDay73 = new System.Windows.Forms.RichTextBox();
            this.rtfDay47 = new System.Windows.Forms.RichTextBox();
            this.rtfDay57 = new System.Windows.Forms.RichTextBox();
            this.statusBar.SuspendLayout();
            this.groupTaskList.SuspendLayout();
            this.groupShortTermPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 575);
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
            this.groupTaskList.Controls.Add(this.txtTaskList);
            this.groupTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTaskList.Location = new System.Drawing.Point(12, 62);
            this.groupTaskList.Name = "groupTaskList";
            this.groupTaskList.Size = new System.Drawing.Size(424, 500);
            this.groupTaskList.TabIndex = 5;
            this.groupTaskList.TabStop = false;
            this.groupTaskList.Text = "Task list";
            // 
            // txtTaskList
            // 
            this.txtTaskList.Location = new System.Drawing.Point(15, 34);
            this.txtTaskList.Multiline = true;
            this.txtTaskList.Name = "txtTaskList";
            this.txtTaskList.Size = new System.Drawing.Size(392, 450);
            this.txtTaskList.TabIndex = 0;
            this.txtTaskList.Text = "No pending tasks!";
            // 
            // groupShortTermPlan
            // 
            this.groupShortTermPlan.Controls.Add(this.rtfDay57);
            this.groupShortTermPlan.Controls.Add(this.rtfDay47);
            this.groupShortTermPlan.Controls.Add(this.rtfDay73);
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
            this.groupShortTermPlan.Size = new System.Drawing.Size(589, 500);
            this.groupShortTermPlan.TabIndex = 6;
            this.groupShortTermPlan.TabStop = false;
            this.groupShortTermPlan.Text = "Short term plan";
            // 
            // rtfDay11
            // 
            this.rtfDay11.BackColor = System.Drawing.Color.White;
            this.rtfDay11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay11.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay11.Location = new System.Drawing.Point(15, 35);
            this.rtfDay11.Name = "rtfDay11";
            this.rtfDay11.ReadOnly = true;
            this.rtfDay11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay11.Size = new System.Drawing.Size(80, 90);
            this.rtfDay11.TabIndex = 0;
            this.rtfDay11.Text = "";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.Image = global::MyTasks.Properties.Resources.Orb_plus_icon_16px;
            this.btnNewTask.Location = new System.Drawing.Point(12, 12);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(130, 30);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "New task";
            this.btnNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTask.UseVisualStyleBackColor = true;
            // 
            // rtfDay21
            // 
            this.rtfDay21.BackColor = System.Drawing.Color.White;
            this.rtfDay21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay21.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay21.Location = new System.Drawing.Point(15, 125);
            this.rtfDay21.Name = "rtfDay21";
            this.rtfDay21.ReadOnly = true;
            this.rtfDay21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay21.Size = new System.Drawing.Size(80, 90);
            this.rtfDay21.TabIndex = 1;
            this.rtfDay21.Text = "";
            // 
            // rtfDay31
            // 
            this.rtfDay31.BackColor = System.Drawing.Color.White;
            this.rtfDay31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay31.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay31.Location = new System.Drawing.Point(15, 215);
            this.rtfDay31.Name = "rtfDay31";
            this.rtfDay31.ReadOnly = true;
            this.rtfDay31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay31.Size = new System.Drawing.Size(80, 90);
            this.rtfDay31.TabIndex = 2;
            this.rtfDay31.Text = "";
            // 
            // rtfDay41
            // 
            this.rtfDay41.BackColor = System.Drawing.Color.White;
            this.rtfDay41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay41.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay41.Location = new System.Drawing.Point(15, 305);
            this.rtfDay41.Name = "rtfDay41";
            this.rtfDay41.ReadOnly = true;
            this.rtfDay41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay41.Size = new System.Drawing.Size(80, 90);
            this.rtfDay41.TabIndex = 3;
            this.rtfDay41.Text = "";
            // 
            // rtfDay51
            // 
            this.rtfDay51.BackColor = System.Drawing.Color.White;
            this.rtfDay51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay51.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay51.Location = new System.Drawing.Point(15, 395);
            this.rtfDay51.Name = "rtfDay51";
            this.rtfDay51.ReadOnly = true;
            this.rtfDay51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay51.Size = new System.Drawing.Size(80, 90);
            this.rtfDay51.TabIndex = 4;
            this.rtfDay51.Text = "";
            // 
            // rtfDay12
            // 
            this.rtfDay12.BackColor = System.Drawing.Color.White;
            this.rtfDay12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay12.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay12.Location = new System.Drawing.Point(95, 35);
            this.rtfDay12.Name = "rtfDay12";
            this.rtfDay12.ReadOnly = true;
            this.rtfDay12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay12.Size = new System.Drawing.Size(80, 90);
            this.rtfDay12.TabIndex = 5;
            this.rtfDay12.Text = "";
            // 
            // rtfDay13
            // 
            this.rtfDay13.BackColor = System.Drawing.Color.White;
            this.rtfDay13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay13.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay13.Location = new System.Drawing.Point(175, 34);
            this.rtfDay13.Name = "rtfDay13";
            this.rtfDay13.ReadOnly = true;
            this.rtfDay13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay13.Size = new System.Drawing.Size(80, 90);
            this.rtfDay13.TabIndex = 6;
            this.rtfDay13.Text = "";
            // 
            // rtfDay14
            // 
            this.rtfDay14.BackColor = System.Drawing.Color.White;
            this.rtfDay14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay14.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay14.Location = new System.Drawing.Point(255, 34);
            this.rtfDay14.Name = "rtfDay14";
            this.rtfDay14.ReadOnly = true;
            this.rtfDay14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay14.Size = new System.Drawing.Size(80, 90);
            this.rtfDay14.TabIndex = 7;
            this.rtfDay14.Text = "";
            // 
            // rtfDay15
            // 
            this.rtfDay15.BackColor = System.Drawing.Color.White;
            this.rtfDay15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay15.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay15.Location = new System.Drawing.Point(335, 34);
            this.rtfDay15.Name = "rtfDay15";
            this.rtfDay15.ReadOnly = true;
            this.rtfDay15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay15.Size = new System.Drawing.Size(80, 90);
            this.rtfDay15.TabIndex = 8;
            this.rtfDay15.Text = "";
            // 
            // rtfDay16
            // 
            this.rtfDay16.BackColor = System.Drawing.Color.White;
            this.rtfDay16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay16.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay16.Location = new System.Drawing.Point(415, 34);
            this.rtfDay16.Name = "rtfDay16";
            this.rtfDay16.ReadOnly = true;
            this.rtfDay16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay16.Size = new System.Drawing.Size(80, 90);
            this.rtfDay16.TabIndex = 9;
            this.rtfDay16.Text = "";
            // 
            // rtfDay17
            // 
            this.rtfDay17.BackColor = System.Drawing.Color.White;
            this.rtfDay17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay17.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay17.Location = new System.Drawing.Point(495, 34);
            this.rtfDay17.Name = "rtfDay17";
            this.rtfDay17.ReadOnly = true;
            this.rtfDay17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay17.Size = new System.Drawing.Size(80, 90);
            this.rtfDay17.TabIndex = 10;
            this.rtfDay17.Text = "";
            // 
            // rtfDay22
            // 
            this.rtfDay22.BackColor = System.Drawing.Color.White;
            this.rtfDay22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay22.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay22.Location = new System.Drawing.Point(95, 125);
            this.rtfDay22.Name = "rtfDay22";
            this.rtfDay22.ReadOnly = true;
            this.rtfDay22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay22.Size = new System.Drawing.Size(80, 90);
            this.rtfDay22.TabIndex = 11;
            this.rtfDay22.Text = "";
            // 
            // rtfDay23
            // 
            this.rtfDay23.BackColor = System.Drawing.Color.White;
            this.rtfDay23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay23.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay23.Location = new System.Drawing.Point(175, 125);
            this.rtfDay23.Name = "rtfDay23";
            this.rtfDay23.ReadOnly = true;
            this.rtfDay23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay23.Size = new System.Drawing.Size(80, 90);
            this.rtfDay23.TabIndex = 12;
            this.rtfDay23.Text = "";
            // 
            // rtfDay24
            // 
            this.rtfDay24.BackColor = System.Drawing.Color.White;
            this.rtfDay24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay24.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay24.Location = new System.Drawing.Point(255, 125);
            this.rtfDay24.Name = "rtfDay24";
            this.rtfDay24.ReadOnly = true;
            this.rtfDay24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay24.Size = new System.Drawing.Size(80, 90);
            this.rtfDay24.TabIndex = 13;
            this.rtfDay24.Text = "";
            // 
            // rtfDay25
            // 
            this.rtfDay25.BackColor = System.Drawing.Color.White;
            this.rtfDay25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay25.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay25.Location = new System.Drawing.Point(335, 125);
            this.rtfDay25.Name = "rtfDay25";
            this.rtfDay25.ReadOnly = true;
            this.rtfDay25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay25.Size = new System.Drawing.Size(80, 90);
            this.rtfDay25.TabIndex = 14;
            this.rtfDay25.Text = "";
            // 
            // rtfDay26
            // 
            this.rtfDay26.BackColor = System.Drawing.Color.White;
            this.rtfDay26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay26.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay26.Location = new System.Drawing.Point(415, 125);
            this.rtfDay26.Name = "rtfDay26";
            this.rtfDay26.ReadOnly = true;
            this.rtfDay26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay26.Size = new System.Drawing.Size(80, 90);
            this.rtfDay26.TabIndex = 15;
            this.rtfDay26.Text = "";
            // 
            // rtfDay27
            // 
            this.rtfDay27.BackColor = System.Drawing.Color.White;
            this.rtfDay27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay27.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay27.Location = new System.Drawing.Point(495, 125);
            this.rtfDay27.Name = "rtfDay27";
            this.rtfDay27.ReadOnly = true;
            this.rtfDay27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay27.Size = new System.Drawing.Size(80, 90);
            this.rtfDay27.TabIndex = 16;
            this.rtfDay27.Text = "";
            // 
            // rtfDay32
            // 
            this.rtfDay32.BackColor = System.Drawing.Color.White;
            this.rtfDay32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay32.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay32.Location = new System.Drawing.Point(95, 215);
            this.rtfDay32.Name = "rtfDay32";
            this.rtfDay32.ReadOnly = true;
            this.rtfDay32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay32.Size = new System.Drawing.Size(80, 90);
            this.rtfDay32.TabIndex = 17;
            this.rtfDay32.Text = "";
            // 
            // rtfDay42
            // 
            this.rtfDay42.BackColor = System.Drawing.Color.White;
            this.rtfDay42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay42.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay42.Location = new System.Drawing.Point(95, 305);
            this.rtfDay42.Name = "rtfDay42";
            this.rtfDay42.ReadOnly = true;
            this.rtfDay42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay42.Size = new System.Drawing.Size(80, 90);
            this.rtfDay42.TabIndex = 18;
            this.rtfDay42.Text = "";
            // 
            // rtfDay52
            // 
            this.rtfDay52.BackColor = System.Drawing.Color.White;
            this.rtfDay52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay52.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay52.Location = new System.Drawing.Point(95, 395);
            this.rtfDay52.Name = "rtfDay52";
            this.rtfDay52.ReadOnly = true;
            this.rtfDay52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay52.Size = new System.Drawing.Size(80, 90);
            this.rtfDay52.TabIndex = 19;
            this.rtfDay52.Text = "";
            // 
            // rtfDay33
            // 
            this.rtfDay33.BackColor = System.Drawing.Color.White;
            this.rtfDay33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay33.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay33.Location = new System.Drawing.Point(175, 215);
            this.rtfDay33.Name = "rtfDay33";
            this.rtfDay33.ReadOnly = true;
            this.rtfDay33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay33.Size = new System.Drawing.Size(80, 90);
            this.rtfDay33.TabIndex = 20;
            this.rtfDay33.Text = "";
            // 
            // rtfDay43
            // 
            this.rtfDay43.BackColor = System.Drawing.Color.White;
            this.rtfDay43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay43.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay43.Location = new System.Drawing.Point(175, 305);
            this.rtfDay43.Name = "rtfDay43";
            this.rtfDay43.ReadOnly = true;
            this.rtfDay43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay43.Size = new System.Drawing.Size(80, 90);
            this.rtfDay43.TabIndex = 21;
            this.rtfDay43.Text = "";
            // 
            // rtfDay53
            // 
            this.rtfDay53.BackColor = System.Drawing.Color.White;
            this.rtfDay53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay53.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay53.Location = new System.Drawing.Point(175, 395);
            this.rtfDay53.Name = "rtfDay53";
            this.rtfDay53.ReadOnly = true;
            this.rtfDay53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay53.Size = new System.Drawing.Size(80, 90);
            this.rtfDay53.TabIndex = 22;
            this.rtfDay53.Text = "";
            // 
            // rtfDay34
            // 
            this.rtfDay34.BackColor = System.Drawing.Color.White;
            this.rtfDay34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay34.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay34.Location = new System.Drawing.Point(255, 215);
            this.rtfDay34.Name = "rtfDay34";
            this.rtfDay34.ReadOnly = true;
            this.rtfDay34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay34.Size = new System.Drawing.Size(80, 90);
            this.rtfDay34.TabIndex = 23;
            this.rtfDay34.Text = "";
            // 
            // rtfDay44
            // 
            this.rtfDay44.BackColor = System.Drawing.Color.White;
            this.rtfDay44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay44.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay44.Location = new System.Drawing.Point(255, 305);
            this.rtfDay44.Name = "rtfDay44";
            this.rtfDay44.ReadOnly = true;
            this.rtfDay44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay44.Size = new System.Drawing.Size(80, 90);
            this.rtfDay44.TabIndex = 24;
            this.rtfDay44.Text = "";
            // 
            // rtfDay54
            // 
            this.rtfDay54.BackColor = System.Drawing.Color.White;
            this.rtfDay54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay54.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay54.Location = new System.Drawing.Point(255, 395);
            this.rtfDay54.Name = "rtfDay54";
            this.rtfDay54.ReadOnly = true;
            this.rtfDay54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay54.Size = new System.Drawing.Size(80, 90);
            this.rtfDay54.TabIndex = 25;
            this.rtfDay54.Text = "";
            // 
            // rtfDay35
            // 
            this.rtfDay35.BackColor = System.Drawing.Color.White;
            this.rtfDay35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay35.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay35.Location = new System.Drawing.Point(335, 215);
            this.rtfDay35.Name = "rtfDay35";
            this.rtfDay35.ReadOnly = true;
            this.rtfDay35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay35.Size = new System.Drawing.Size(80, 90);
            this.rtfDay35.TabIndex = 26;
            this.rtfDay35.Text = "";
            // 
            // rtfDay45
            // 
            this.rtfDay45.BackColor = System.Drawing.Color.White;
            this.rtfDay45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay45.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay45.Location = new System.Drawing.Point(335, 305);
            this.rtfDay45.Name = "rtfDay45";
            this.rtfDay45.ReadOnly = true;
            this.rtfDay45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay45.Size = new System.Drawing.Size(80, 90);
            this.rtfDay45.TabIndex = 27;
            this.rtfDay45.Text = "";
            // 
            // rtfDay55
            // 
            this.rtfDay55.BackColor = System.Drawing.Color.White;
            this.rtfDay55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay55.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay55.Location = new System.Drawing.Point(335, 395);
            this.rtfDay55.Name = "rtfDay55";
            this.rtfDay55.ReadOnly = true;
            this.rtfDay55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay55.Size = new System.Drawing.Size(80, 90);
            this.rtfDay55.TabIndex = 28;
            this.rtfDay55.Text = "";
            // 
            // rtfDay36
            // 
            this.rtfDay36.BackColor = System.Drawing.Color.White;
            this.rtfDay36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay36.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay36.Location = new System.Drawing.Point(415, 215);
            this.rtfDay36.Name = "rtfDay36";
            this.rtfDay36.ReadOnly = true;
            this.rtfDay36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay36.Size = new System.Drawing.Size(80, 90);
            this.rtfDay36.TabIndex = 29;
            this.rtfDay36.Text = "";
            // 
            // rtfDay46
            // 
            this.rtfDay46.BackColor = System.Drawing.Color.White;
            this.rtfDay46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay46.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay46.Location = new System.Drawing.Point(415, 305);
            this.rtfDay46.Name = "rtfDay46";
            this.rtfDay46.ReadOnly = true;
            this.rtfDay46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay46.Size = new System.Drawing.Size(80, 90);
            this.rtfDay46.TabIndex = 30;
            this.rtfDay46.Text = "";
            // 
            // rtfDay56
            // 
            this.rtfDay56.BackColor = System.Drawing.Color.White;
            this.rtfDay56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay56.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay56.Location = new System.Drawing.Point(415, 395);
            this.rtfDay56.Name = "rtfDay56";
            this.rtfDay56.ReadOnly = true;
            this.rtfDay56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay56.Size = new System.Drawing.Size(80, 90);
            this.rtfDay56.TabIndex = 31;
            this.rtfDay56.Text = "";
            // 
            // rtfDay73
            // 
            this.rtfDay73.BackColor = System.Drawing.Color.White;
            this.rtfDay73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay73.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay73.Location = new System.Drawing.Point(495, 215);
            this.rtfDay73.Name = "rtfDay73";
            this.rtfDay73.ReadOnly = true;
            this.rtfDay73.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay73.Size = new System.Drawing.Size(80, 90);
            this.rtfDay73.TabIndex = 32;
            this.rtfDay73.Text = "";
            // 
            // rtfDay47
            // 
            this.rtfDay47.BackColor = System.Drawing.Color.White;
            this.rtfDay47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay47.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay47.Location = new System.Drawing.Point(495, 305);
            this.rtfDay47.Name = "rtfDay47";
            this.rtfDay47.ReadOnly = true;
            this.rtfDay47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay47.Size = new System.Drawing.Size(80, 90);
            this.rtfDay47.TabIndex = 33;
            this.rtfDay47.Text = "";
            // 
            // rtfDay57
            // 
            this.rtfDay57.BackColor = System.Drawing.Color.White;
            this.rtfDay57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDay57.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDay57.Location = new System.Drawing.Point(495, 395);
            this.rtfDay57.Name = "rtfDay57";
            this.rtfDay57.ReadOnly = true;
            this.rtfDay57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDay57.Size = new System.Drawing.Size(80, 90);
            this.rtfDay57.TabIndex = 34;
            this.rtfDay57.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 599);
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
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupTaskList.ResumeLayout(false);
            this.groupTaskList.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTaskList;
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
        private System.Windows.Forms.RichTextBox rtfDay73;
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
    }
}

