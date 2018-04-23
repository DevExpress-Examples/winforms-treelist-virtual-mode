namespace SimpleTreeListExample
{
    partial class ExampleMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleMainForm));
            this.MyTtreeList = new DevExpress.XtraTreeList.TreeList();
            this.imageListForTree = new System.Windows.Forms.ImageList(this.components);
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.MyTtreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTtreeList
            // 
            this.MyTtreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTtreeList.Location = new System.Drawing.Point(0, 0);
            this.MyTtreeList.Name = "MyTtreeList";
            this.MyTtreeList.Size = new System.Drawing.Size(479, 350);
            this.MyTtreeList.TabIndex = 0;
            this.MyTtreeList.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.treeList1_VirtualTreeGetChildNodes);
            this.MyTtreeList.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.treeList1_VirtualTreeGetCellValue);
            this.MyTtreeList.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage);
            // 
            // imageListForTree
            // 
            this.imageListForTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForTree.ImageStream")));
            this.imageListForTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForTree.Images.SetKeyName(0, "1-1.bmp");
            this.imageListForTree.Images.SetKeyName(1, "1-2.bmp");
            this.imageListForTree.Images.SetKeyName(2, "1-3.bmp");
            this.imageListForTree.Images.SetKeyName(3, "1-4.bmp");
            this.imageListForTree.Images.SetKeyName(4, "1-5.bmp");
            this.imageListForTree.Images.SetKeyName(5, "2-1.bmp");
            this.imageListForTree.Images.SetKeyName(6, "2-2.bmp");
            this.imageListForTree.Images.SetKeyName(7, "2-3.bmp");
            this.imageListForTree.Images.SetKeyName(8, "2-4.bmp");
            this.imageListForTree.Images.SetKeyName(9, "2-5.bmp");
            // 
            // ExampleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 350);
            this.Controls.Add(this.MyTtreeList);
            this.Name = "ExampleMainForm";
            this.Text = "Example main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTtreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList MyTtreeList;
        private System.Windows.Forms.ImageList imageListForTree;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
    }
}

