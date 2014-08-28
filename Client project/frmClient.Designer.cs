namespace FilesSharing
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFileName2Search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvSerachResult = new System.Windows.Forms.ListView();
            this.FileNameCol = new System.Windows.Forms.ColumnHeader();
            this.SizeCol = new System.Windows.Forms.ColumnHeader();
            this.IPcolumn = new System.Windows.Forms.ColumnHeader();
            this.FilePathCol = new System.Windows.Forms.ColumnHeader();
            this.gbChecketlstBox = new System.Windows.Forms.GroupBox();
            this.checkedListBoxExt = new System.Windows.Forms.CheckedListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBrowseDownloads = new System.Windows.Forms.Button();
            this.lblDownloadsPath = new System.Windows.Forms.Label();
            this.lvDownloads = new System.Windows.Forms.ListView();
            this.FileNameColDown = new System.Windows.Forms.ColumnHeader();
            this.SizeColDown = new System.Windows.Forms.ColumnHeader();
            this.UserIPColDown = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileNameColUp = new System.Windows.Forms.ColumnHeader();
            this.SizeColUP = new System.Windows.Forms.ColumnHeader();
            this.userIPColUp = new System.Windows.Forms.ColumnHeader();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbDirectory2Share = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblShowPath = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lblConnectMsg = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblDisconnectMsg = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbChecketlstBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbDirectory2Share.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileName2Search
            // 
            this.lblFileName2Search.AutoSize = true;
            this.lblFileName2Search.Location = new System.Drawing.Point(6, 140);
            this.lblFileName2Search.Name = "lblFileName2Search";
            this.lblFileName2Search.Size = new System.Drawing.Size(136, 13);
            this.lblFileName2Search.TabIndex = 17;
            this.lblFileName2Search.Text = "Enter a file name to search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 456);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.lvSerachResult);
            this.tabPage1.Controls.Add(this.gbChecketlstBox);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.lblFileName2Search);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvSerachResult
            // 
            this.lvSerachResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameCol,
            this.SizeCol,
            this.IPcolumn,
            this.FilePathCol});
            this.lvSerachResult.Location = new System.Drawing.Point(9, 164);
            this.lvSerachResult.MultiSelect = false;
            this.lvSerachResult.Name = "lvSerachResult";
            this.lvSerachResult.Size = new System.Drawing.Size(681, 228);
            this.lvSerachResult.TabIndex = 22;
            this.lvSerachResult.UseCompatibleStateImageBehavior = false;
            this.lvSerachResult.View = System.Windows.Forms.View.Details;
            this.lvSerachResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSerachResult_MouseDoubleClick);
            // 
            // FileNameCol
            // 
            this.FileNameCol.Text = "File name";
            this.FileNameCol.Width = 180;
            // 
            // SizeCol
            // 
            this.SizeCol.Text = "Size";
            this.SizeCol.Width = 200;
            // 
            // IPcolumn
            // 
            this.IPcolumn.Text = "user IP";
            this.IPcolumn.Width = 100;
            // 
            // FilePathCol
            // 
            this.FilePathCol.Text = "File path";
            this.FilePathCol.Width = 200;
            // 
            // gbChecketlstBox
            // 
            this.gbChecketlstBox.Controls.Add(this.checkedListBoxExt);
            this.gbChecketlstBox.Location = new System.Drawing.Point(9, 9);
            this.gbChecketlstBox.Name = "gbChecketlstBox";
            this.gbChecketlstBox.Size = new System.Drawing.Size(402, 122);
            this.gbChecketlstBox.TabIndex = 21;
            this.gbChecketlstBox.TabStop = false;
            this.gbChecketlstBox.Text = "File types";
            // 
            // checkedListBoxExt
            // 
            this.checkedListBoxExt.CheckOnClick = true;
            this.checkedListBoxExt.FormattingEnabled = true;
            this.checkedListBoxExt.Location = new System.Drawing.Point(6, 20);
            this.checkedListBoxExt.MultiColumn = true;
            this.checkedListBoxExt.Name = "checkedListBoxExt";
            this.checkedListBoxExt.Size = new System.Drawing.Size(383, 94);
            this.checkedListBoxExt.TabIndex = 20;
            this.checkedListBoxExt.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxExt_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBrowseDownloads);
            this.tabPage2.Controls.Add(this.lblDownloadsPath);
            this.tabPage2.Controls.Add(this.lvDownloads);
            this.tabPage2.ImageIndex = 5;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Downloads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDownloads
            // 
            this.btnBrowseDownloads.Location = new System.Drawing.Point(9, 6);
            this.btnBrowseDownloads.Name = "btnBrowseDownloads";
            this.btnBrowseDownloads.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDownloads.TabIndex = 2;
            this.btnBrowseDownloads.Text = "Browse";
            this.btnBrowseDownloads.UseVisualStyleBackColor = true;
            this.btnBrowseDownloads.Click += new System.EventHandler(this.btnBrowseDownloads_Click);
            // 
            // lblDownloadsPath
            // 
            this.lblDownloadsPath.AutoSize = true;
            this.lblDownloadsPath.Location = new System.Drawing.Point(6, 42);
            this.lblDownloadsPath.Name = "lblDownloadsPath";
            this.lblDownloadsPath.Size = new System.Drawing.Size(37, 13);
            this.lblDownloadsPath.TabIndex = 1;
            this.lblDownloadsPath.Text = "Path:";
            // 
            // lvDownloads
            // 
            this.lvDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColDown,
            this.SizeColDown,
            this.UserIPColDown});
            this.lvDownloads.Location = new System.Drawing.Point(3, 58);
            this.lvDownloads.Name = "lvDownloads";
            this.lvDownloads.Size = new System.Drawing.Size(690, 334);
            this.lvDownloads.TabIndex = 0;
            this.lvDownloads.UseCompatibleStateImageBehavior = false;
            this.lvDownloads.View = System.Windows.Forms.View.Details;
            // 
            // FileNameColDown
            // 
            this.FileNameColDown.Text = "File name";
            this.FileNameColDown.Width = 200;
            // 
            // SizeColDown
            // 
            this.SizeColDown.Text = "Size";
            this.SizeColDown.Width = 100;
            // 
            // UserIPColDown
            // 
            this.UserIPColDown.Text = "IP";
            this.UserIPColDown.Width = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(696, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Load xml";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColUp,
            this.SizeColUP,
            this.userIPColUp});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(690, 392);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FileNameColUp
            // 
            this.FileNameColUp.Text = "File name";
            this.FileNameColUp.Width = 200;
            // 
            // SizeColUP
            // 
            this.SizeColUP.Text = "Size";
            this.SizeColUP.Width = 100;
            // 
            // userIPColUp
            // 
            this.userIPColUp.Text = "IP";
            this.userIPColUp.Width = 100;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbDirectory2Share);
            this.tabPage5.ImageIndex = 6;
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(696, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Directories";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbDirectory2Share
            // 
            this.gbDirectory2Share.Controls.Add(this.btnBrowse);
            this.gbDirectory2Share.Controls.Add(this.lblShowPath);
            this.gbDirectory2Share.Controls.Add(this.lblPath);
            this.gbDirectory2Share.Location = new System.Drawing.Point(15, 19);
            this.gbDirectory2Share.Name = "gbDirectory2Share";
            this.gbDirectory2Share.Size = new System.Drawing.Size(275, 100);
            this.gbDirectory2Share.TabIndex = 9;
            this.gbDirectory2Share.TabStop = false;
            this.gbDirectory2Share.Text = "Directory to share";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblShowPath
            // 
            this.lblShowPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowPath.Location = new System.Drawing.Point(6, 69);
            this.lblShowPath.Name = "lblShowPath";
            this.lblShowPath.Size = new System.Drawing.Size(263, 28);
            this.lblShowPath.TabIndex = 7;
            this.lblShowPath.Text = "Path:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 44);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 13);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Path:";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lblConnectMsg);
            this.tabPage7.ImageIndex = 7;
            this.tabPage7.Location = new System.Drawing.Point(4, 54);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(696, 398);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Connect";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lblConnectMsg
            // 
            this.lblConnectMsg.BackColor = System.Drawing.Color.White;
            this.lblConnectMsg.Location = new System.Drawing.Point(22, 23);
            this.lblConnectMsg.Name = "lblConnectMsg";
            this.lblConnectMsg.Size = new System.Drawing.Size(303, 106);
            this.lblConnectMsg.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblDisconnectMsg);
            this.tabPage4.ImageIndex = 2;
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(696, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Disconnect";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblDisconnectMsg
            // 
            this.lblDisconnectMsg.BackColor = System.Drawing.Color.White;
            this.lblDisconnectMsg.Location = new System.Drawing.Point(13, 12);
            this.lblDisconnectMsg.Name = "lblDisconnectMsg";
            this.lblDisconnectMsg.Size = new System.Drawing.Size(303, 106);
            this.lblDisconnectMsg.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageIndex = 3;
            this.tabPage6.Location = new System.Drawing.Point(4, 54);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(696, 398);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Close";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Search_black.BMP");
            this.imageList1.Images.SetKeyName(1, "XML.JPG");
            this.imageList1.Images.SetKeyName(2, "Disconnect.jpg");
            this.imageList1.Images.SetKeyName(3, "Home.BMP");
            this.imageList1.Images.SetKeyName(4, "UpArrow.JPG");
            this.imageList1.Images.SetKeyName(5, "DownArrow.jpg");
            this.imageList1.Images.SetKeyName(6, "Directories.BMP");
            this.imageList1.Images.SetKeyName(7, "Connect.BMP");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(728, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbChecketlstBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbDirectory2Share.ResumeLayout(false);
            this.gbDirectory2Share.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblFileName2Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox gbDirectory2Share;
        private System.Windows.Forms.Label lblShowPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label lblConnectMsg;
        private System.Windows.Forms.CheckedListBox checkedListBoxExt;
        private System.Windows.Forms.GroupBox gbChecketlstBox;
        private System.Windows.Forms.Label lblDisconnectMsg;
        private System.Windows.Forms.ListView lvSerachResult;
        private System.Windows.Forms.ColumnHeader FileNameCol;
        private System.Windows.Forms.ColumnHeader SizeCol;
        private System.Windows.Forms.ColumnHeader IPcolumn;
        private System.Windows.Forms.ColumnHeader FilePathCol;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListView lvDownloads;
        private System.Windows.Forms.ColumnHeader FileNameColDown;
        private System.Windows.Forms.ColumnHeader SizeColDown;
        private System.Windows.Forms.ColumnHeader UserIPColDown;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileNameColUp;
        private System.Windows.Forms.ColumnHeader SizeColUP;
        private System.Windows.Forms.ColumnHeader userIPColUp;
        private System.Windows.Forms.Label lblDownloadsPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseDownloads;
    }
}

