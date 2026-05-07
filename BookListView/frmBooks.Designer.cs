namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpUse = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpView.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpUse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpView.Location = new System.Drawing.Point(10, 10);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(331, 108);
            this.grpView.TabIndex = 0;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式：";
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(6, 46);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(319, 33);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Controls.Add(this.grpUse);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(588, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTools.Size = new System.Drawing.Size(351, 604);
            this.pnlTools.TabIndex = 1;
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBorrow.Location = new System.Drawing.Point(10, 118);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(331, 399);
            this.grpBorrow.TabIndex = 1;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單：";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 25;
            this.lstBorrow.Location = new System.Drawing.Point(3, 30);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(325, 366);
            this.lstBorrow.TabIndex = 0;
            // 
            // lvwBooks
            // 
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(15, 15);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(558, 574);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 2;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.SelectedIndexChanged += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.bmp");
            this.imgL.Images.SetKeyName(1, "Book2.bmp");
            this.imgL.Images.SetKeyName(2, "Book3.bmp");
            this.imgL.Images.SetKeyName(3, "Book4.bmp");
            this.imgL.Images.SetKeyName(4, "Book5.bmp");
            this.imgL.Images.SetKeyName(5, "Book6.bmp");
            this.imgL.Images.SetKeyName(6, "Book7.bmp");
            this.imgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.bmp");
            this.imgS.Images.SetKeyName(1, "Book2.bmp");
            this.imgS.Images.SetKeyName(2, "Book3.bmp");
            this.imgS.Images.SetKeyName(3, "Book4.bmp");
            this.imgS.Images.SetKeyName(4, "Book5.bmp");
            this.imgS.Images.SetKeyName(5, "Book6.bmp");
            this.imgS.Images.SetKeyName(6, "Book7.bmp");
            this.imgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lvwBooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(588, 604);
            this.panel1.TabIndex = 3;
            // 
            // grpUse
            // 
            this.grpUse.Controls.Add(this.btnClear);
            this.grpUse.Controls.Add(this.btnReturn);
            this.grpUse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUse.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpUse.Location = new System.Drawing.Point(10, 517);
            this.grpUse.Name = "grpUse";
            this.grpUse.Size = new System.Drawing.Size(331, 77);
            this.grpUse.TabIndex = 1;
            this.grpUse.TabStop = false;
            this.grpUse.Text = "功能：";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.Location = new System.Drawing.Point(6, 33);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 33);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "歸還書籍";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(168, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "圖書管理程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBooks_FormClosing);
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.grpView.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpUse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpUse;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
    }
}

