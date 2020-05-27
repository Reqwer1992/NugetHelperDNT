namespace NugetHelperDntUI
{
    partial class MainWindow
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
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.pnlDntButtons = new System.Windows.Forms.Panel();
            this.btnRunDnt = new System.Windows.Forms.Button();
            this.btnGenerateContent = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.splSelectedFound = new System.Windows.Forms.Splitter();
            this.pnlFoundProjects = new System.Windows.Forms.GroupBox();
            this.foundSourceDependencies = new System.Windows.Forms.TreeView();
            this.splFoundNotFound = new System.Windows.Forms.Splitter();
            this.pnlNotFoundProjects = new System.Windows.Forms.GroupBox();
            this.notFoundSourceDependencies = new System.Windows.Forms.TreeView();
            this.pnlSelectedProjects = new System.Windows.Forms.GroupBox();
            this.selectedSourceDependencies = new System.Windows.Forms.TreeView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLoadSourceProject = new System.Windows.Forms.Button();
            this.btnOpenSourceFile = new System.Windows.Forms.Button();
            this.txTargetSolution = new System.Windows.Forms.TextBox();
            this.btnDntLink = new System.Windows.Forms.Button();
            this.sourceProjects = new System.Windows.Forms.TreeView();
            this.splMain = new System.Windows.Forms.Splitter();
            this.splContent = new System.Windows.Forms.Splitter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlSourceProjects = new System.Windows.Forms.GroupBox();
            this.pnlPreview.SuspendLayout();
            this.pnlDntButtons.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.pnlFoundProjects.SuspendLayout();
            this.pnlNotFoundProjects.SuspendLayout();
            this.pnlSelectedProjects.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSourceProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.pnlDntButtons);
            this.pnlPreview.Controls.Add(this.txtContent);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPreview.Location = new System.Drawing.Point(0, 470);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(988, 111);
            this.pnlPreview.TabIndex = 0;
            // 
            // pnlDntButtons
            // 
            this.pnlDntButtons.Controls.Add(this.btnRunDnt);
            this.pnlDntButtons.Controls.Add(this.btnGenerateContent);
            this.pnlDntButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDntButtons.Location = new System.Drawing.Point(834, 0);
            this.pnlDntButtons.Name = "pnlDntButtons";
            this.pnlDntButtons.Size = new System.Drawing.Size(154, 111);
            this.pnlDntButtons.TabIndex = 1;
            // 
            // btnRunDnt
            // 
            this.btnRunDnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRunDnt.Location = new System.Drawing.Point(0, 23);
            this.btnRunDnt.Name = "btnRunDnt";
            this.btnRunDnt.Size = new System.Drawing.Size(154, 88);
            this.btnRunDnt.TabIndex = 1;
            this.btnRunDnt.Text = "Create switcher file and run DNT switch-to-projects";
            this.btnRunDnt.UseVisualStyleBackColor = true;
            this.btnRunDnt.Click += new System.EventHandler(this.btnRunDnt_Click);
            // 
            // btnGenerateContent
            // 
            this.btnGenerateContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateContent.Location = new System.Drawing.Point(0, 0);
            this.btnGenerateContent.Name = "btnGenerateContent";
            this.btnGenerateContent.Size = new System.Drawing.Size(154, 23);
            this.btnGenerateContent.TabIndex = 0;
            this.btnGenerateContent.Text = "Generate content";
            this.btnGenerateContent.UseVisualStyleBackColor = true;
            this.btnGenerateContent.Click += new System.EventHandler(this.btnGenerateContent_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(834, 111);
            this.txtContent.TabIndex = 0;
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.splSelectedFound);
            this.pnlTarget.Controls.Add(this.pnlFoundProjects);
            this.pnlTarget.Controls.Add(this.splFoundNotFound);
            this.pnlTarget.Controls.Add(this.pnlNotFoundProjects);
            this.pnlTarget.Controls.Add(this.pnlSelectedProjects);
            this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTarget.Location = new System.Drawing.Point(0, 76);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(439, 389);
            this.pnlTarget.TabIndex = 1;
            // 
            // splSelectedFound
            // 
            this.splSelectedFound.Dock = System.Windows.Forms.DockStyle.Top;
            this.splSelectedFound.Location = new System.Drawing.Point(0, 133);
            this.splSelectedFound.Name = "splSelectedFound";
            this.splSelectedFound.Size = new System.Drawing.Size(439, 5);
            this.splSelectedFound.TabIndex = 4;
            this.splSelectedFound.TabStop = false;
            // 
            // pnlFoundProjects
            // 
            this.pnlFoundProjects.Controls.Add(this.foundSourceDependencies);
            this.pnlFoundProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoundProjects.Location = new System.Drawing.Point(0, 133);
            this.pnlFoundProjects.Name = "pnlFoundProjects";
            this.pnlFoundProjects.Size = new System.Drawing.Size(439, 119);
            this.pnlFoundProjects.TabIndex = 2;
            this.pnlFoundProjects.TabStop = false;
            this.pnlFoundProjects.Text = "Dependencies found in source projects";
            // 
            // foundSourceDependencies
            // 
            this.foundSourceDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foundSourceDependencies.Location = new System.Drawing.Point(3, 19);
            this.foundSourceDependencies.Name = "foundSourceDependencies";
            this.foundSourceDependencies.ShowNodeToolTips = true;
            this.foundSourceDependencies.Size = new System.Drawing.Size(433, 97);
            this.foundSourceDependencies.TabIndex = 0;
            // 
            // splFoundNotFound
            // 
            this.splFoundNotFound.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splFoundNotFound.Location = new System.Drawing.Point(0, 252);
            this.splFoundNotFound.Name = "splFoundNotFound";
            this.splFoundNotFound.Size = new System.Drawing.Size(439, 5);
            this.splFoundNotFound.TabIndex = 5;
            this.splFoundNotFound.TabStop = false;
            // 
            // pnlNotFoundProjects
            // 
            this.pnlNotFoundProjects.Controls.Add(this.notFoundSourceDependencies);
            this.pnlNotFoundProjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNotFoundProjects.Location = new System.Drawing.Point(0, 257);
            this.pnlNotFoundProjects.Name = "pnlNotFoundProjects";
            this.pnlNotFoundProjects.Size = new System.Drawing.Size(439, 132);
            this.pnlNotFoundProjects.TabIndex = 1;
            this.pnlNotFoundProjects.TabStop = false;
            this.pnlNotFoundProjects.Text = "Dependencies not found in source projects";
            // 
            // notFoundSourceDependencies
            // 
            this.notFoundSourceDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notFoundSourceDependencies.Location = new System.Drawing.Point(3, 19);
            this.notFoundSourceDependencies.Name = "notFoundSourceDependencies";
            this.notFoundSourceDependencies.ShowNodeToolTips = true;
            this.notFoundSourceDependencies.Size = new System.Drawing.Size(433, 110);
            this.notFoundSourceDependencies.TabIndex = 0;
            // 
            // pnlSelectedProjects
            // 
            this.pnlSelectedProjects.Controls.Add(this.selectedSourceDependencies);
            this.pnlSelectedProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectedProjects.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectedProjects.Name = "pnlSelectedProjects";
            this.pnlSelectedProjects.Size = new System.Drawing.Size(439, 133);
            this.pnlSelectedProjects.TabIndex = 3;
            this.pnlSelectedProjects.TabStop = false;
            this.pnlSelectedProjects.Text = "Selected dependencies";
            // 
            // selectedSourceDependencies
            // 
            this.selectedSourceDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSourceDependencies.Location = new System.Drawing.Point(3, 19);
            this.selectedSourceDependencies.Name = "selectedSourceDependencies";
            this.selectedSourceDependencies.ShowNodeToolTips = true;
            this.selectedSourceDependencies.Size = new System.Drawing.Size(433, 111);
            this.selectedSourceDependencies.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnLoadSourceProject);
            this.pnlTop.Controls.Add(this.btnOpenSourceFile);
            this.pnlTop.Controls.Add(this.txTargetSolution);
            this.pnlTop.Controls.Add(this.btnDntLink);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(988, 76);
            this.pnlTop.TabIndex = 2;
            // 
            // btnLoadSourceProject
            // 
            this.btnLoadSourceProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSourceProject.Location = new System.Drawing.Point(845, 48);
            this.btnLoadSourceProject.Name = "btnLoadSourceProject";
            this.btnLoadSourceProject.Size = new System.Drawing.Size(131, 22);
            this.btnLoadSourceProject.TabIndex = 3;
            this.btnLoadSourceProject.Text = "Add source solution";
            this.btnLoadSourceProject.UseVisualStyleBackColor = true;
            this.btnLoadSourceProject.Click += new System.EventHandler(this.btnLoadSourceProject_Click);
            // 
            // btnOpenSourceFile
            // 
            this.btnOpenSourceFile.Location = new System.Drawing.Point(306, 43);
            this.btnOpenSourceFile.Name = "btnOpenSourceFile";
            this.btnOpenSourceFile.Size = new System.Drawing.Size(106, 23);
            this.btnOpenSourceFile.TabIndex = 2;
            this.btnOpenSourceFile.Text = "Load target solution";
            this.btnOpenSourceFile.UseVisualStyleBackColor = true;
            this.btnOpenSourceFile.Click += new System.EventHandler(this.btnOpenTargetFile_Click);
            // 
            // txTargetSolution
            // 
            this.txTargetSolution.Location = new System.Drawing.Point(12, 44);
            this.txTargetSolution.Name = "txTargetSolution";
            this.txTargetSolution.PlaceholderText = "Path to target solution file";
            this.txTargetSolution.Size = new System.Drawing.Size(288, 23);
            this.txTargetSolution.TabIndex = 1;
            // 
            // btnDntLink
            // 
            this.btnDntLink.Location = new System.Drawing.Point(12, 12);
            this.btnDntLink.Name = "btnDntLink";
            this.btnDntLink.Size = new System.Drawing.Size(158, 22);
            this.btnDntLink.TabIndex = 0;
            this.btnDntLink.Text = "Open DNT Github project";
            this.btnDntLink.UseVisualStyleBackColor = true;
            this.btnDntLink.Click += new System.EventHandler(this.btnDntLink_Click);
            // 
            // sourceProjects
            // 
            this.sourceProjects.CheckBoxes = true;
            this.sourceProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceProjects.Location = new System.Drawing.Point(3, 19);
            this.sourceProjects.Name = "sourceProjects";
            this.sourceProjects.ShowNodeToolTips = true;
            this.sourceProjects.Size = new System.Drawing.Size(538, 367);
            this.sourceProjects.TabIndex = 0;
            this.sourceProjects.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sourceProjects_AfterCheck);
            // 
            // splMain
            // 
            this.splMain.Location = new System.Drawing.Point(439, 76);
            this.splMain.Name = "splMain";
            this.splMain.Size = new System.Drawing.Size(5, 389);
            this.splMain.TabIndex = 4;
            this.splMain.TabStop = false;
            // 
            // splContent
            // 
            this.splContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splContent.Location = new System.Drawing.Point(0, 465);
            this.splContent.Name = "splContent";
            this.splContent.Size = new System.Drawing.Size(988, 5);
            this.splContent.TabIndex = 5;
            this.splContent.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Solution files (*.sln)|*.sln|All files (*.*)|*.*";
            // 
            // pnlSourceProjects
            // 
            this.pnlSourceProjects.Controls.Add(this.sourceProjects);
            this.pnlSourceProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSourceProjects.Location = new System.Drawing.Point(444, 76);
            this.pnlSourceProjects.Name = "pnlSourceProjects";
            this.pnlSourceProjects.Size = new System.Drawing.Size(544, 389);
            this.pnlSourceProjects.TabIndex = 6;
            this.pnlSourceProjects.TabStop = false;
            this.pnlSourceProjects.Text = "Source projects";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 581);
            this.Controls.Add(this.pnlSourceProjects);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.pnlTarget);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.splContent);
            this.Controls.Add(this.pnlPreview);
            this.Name = "MainWindow";
            this.Text = "Nuget Helper DNT UI";
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.pnlDntButtons.ResumeLayout(false);
            this.pnlTarget.ResumeLayout(false);
            this.pnlFoundProjects.ResumeLayout(false);
            this.pnlNotFoundProjects.ResumeLayout(false);
            this.pnlSelectedProjects.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSourceProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnDntLink;
        private System.Windows.Forms.Button btnOpenSourceFile;
        private System.Windows.Forms.TextBox txTargetSolution;
        private System.Windows.Forms.Splitter splMain;
        private System.Windows.Forms.Splitter splContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TreeView sourceProjects;
        private System.Windows.Forms.Button btnLoadSourceProject;
        private System.Windows.Forms.Panel pnlDntButtons;
        private System.Windows.Forms.Button btnGenerateContent;
        private System.Windows.Forms.Button btnRunDnt;
        private System.Windows.Forms.GroupBox pnlSelectedProjects;
        private System.Windows.Forms.Splitter splSelectedFound;
        private System.Windows.Forms.GroupBox pnlFoundProjects;
        private System.Windows.Forms.Splitter splFoundNotFound;
        private System.Windows.Forms.GroupBox pnlNotFoundProjects;
        private System.Windows.Forms.TreeView notFoundSourceDependencies;
        private System.Windows.Forms.GroupBox pnlSourceProjects;
        private System.Windows.Forms.TreeView foundSourceDependencies;
        private System.Windows.Forms.TreeView selectedSourceDependencies;
    }
}

