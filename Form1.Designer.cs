namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groundSc = new SplitContainer();
            panel1 = new Panel();
            calendarBtn = new Button();
            addEventBtn = new Button();
            weekViewBtn = new Button();
            userProfileBtn = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            logoutBtn = new Button();
            toolTip5 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)groundSc).BeginInit();
            groundSc.Panel1.SuspendLayout();
            groundSc.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groundSc
            // 
            groundSc.BackColor = SystemColors.ActiveBorder;
            groundSc.Dock = DockStyle.Fill;
            groundSc.IsSplitterFixed = true;
            groundSc.Location = new Point(0, 0);
            groundSc.Name = "groundSc";
            // 
            // groundSc.Panel1
            // 
            groundSc.Panel1.BackColor = SystemColors.Control;
            groundSc.Panel1.Controls.Add(panel1);
            // 
            // groundSc.Panel2
            // 
            groundSc.Panel2.BackColor = SystemColors.Control;
            groundSc.Size = new Size(1102, 723);
            groundSc.SplitterDistance = 78;
            groundSc.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(calendarBtn);
            panel1.Controls.Add(addEventBtn);
            panel1.Controls.Add(weekViewBtn);
            panel1.Controls.Add(userProfileBtn);
            panel1.Location = new Point(4, 197);
            panel1.Margin = new Padding(3, 188, 3, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 351);
            panel1.TabIndex = 6;
            // 
            // calendarBtn
            // 
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.Location = new Point(3, 3);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Size = new Size(64, 64);
            calendarBtn.TabIndex = 0;
            calendarBtn.UseVisualStyleBackColor = true;
            // 
            // addEventBtn
            // 
            addEventBtn.Image = (Image)resources.GetObject("addEventBtn.Image");
            addEventBtn.Location = new Point(3, 73);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(64, 64);
            addEventBtn.TabIndex = 4;
            addEventBtn.UseVisualStyleBackColor = true;
            // 
            // weekViewBtn
            // 
            weekViewBtn.Image = (Image)resources.GetObject("weekViewBtn.Image");
            weekViewBtn.Location = new Point(3, 143);
            weekViewBtn.Name = "weekViewBtn";
            weekViewBtn.Size = new Size(64, 64);
            weekViewBtn.TabIndex = 1;
            weekViewBtn.UseVisualStyleBackColor = true;
            // 
            // userProfileBtn
            // 
            userProfileBtn.Image = (Image)resources.GetObject("userProfileBtn.Image");
            userProfileBtn.Location = new Point(3, 213);
            userProfileBtn.Name = "userProfileBtn";
            userProfileBtn.Size = new Size(64, 64);
            userProfileBtn.TabIndex = 2;
            userProfileBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.Location = new Point(4, 283);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(64, 64);
            logoutBtn.TabIndex = 5;
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 723);
            Controls.Add(groundSc);
            Name = "Form1";
            Text = "Form1";
            groundSc.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groundSc).EndInit();
            groundSc.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer groundSc;
        private Button calendarBtn;
        private Button addEventBtn;
        private Button userProfileBtn;
        private Button weekViewBtn;
        private Panel panel1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private Button logoutBtn;
        private ToolTip toolTip5;
    }
}
