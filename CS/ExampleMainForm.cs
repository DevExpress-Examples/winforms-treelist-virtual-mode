using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System.Threading;
using DevExpress.XtraTreeList;

namespace SimpleTreeListExample
{
    public partial class ExampleMainForm : Form
    {
        public ExampleMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TreeListColumn newColumnDescription = MyTtreeList.Columns.Add();
            newColumnDescription.FieldName = "Description";
            newColumnDescription.VisibleIndex = 0;

            MyTtreeList.SelectImageList = imageListForTree;
            MyTtreeList.DataSource = new object();
        }

        private void treeList1_VirtualTreeGetChildNodes(object sender, DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e)
        {
            String sCurrentNode = e.Node as String;
            if (sCurrentNode == null)
            {
                e.Children = new string[] { "Root node 1", 
                                            "Root node 2", 
                                            "Root node 3" };
            }
            else
            {
                e.Children = CreateChildrenNodes(sCurrentNode);
            }
        }

        private BindingList<string> CreateChildrenNodes(string sCurrentNode)
        {
            BindingList<string> sChildren = new BindingList<string>();
            using (BackgroundWorker workerForChildren = new BackgroundWorker())
            {
                workerForChildren.DoWork += new DoWorkEventHandler(workerForChildren_DoWork);
                workerForChildren.RunWorkerAsync(sChildren);
            }
            return sChildren;
        }

        void workerForChildren_DoWork(object sender, DoWorkEventArgs e)
        {
            BindingList<string> sChildren = e.Argument as BindingList<string>;
            for (int i = 0; i < 4; i++)
            {
                BeginInvoke(new MethodInvoker(delegate() {                
                    sChildren.Add(String.Format("Child node {0}", i)); }));
                Thread.Sleep(1000);
            }
        }

        private void treeList1_VirtualTreeGetCellValue(object sender, DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e)
        {
            e.CellData = e.Node;
        }

        private void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            if (e.Node.Id < imageListForTree.Images.Count)
            {
                e.NodeImageIndex = e.Node.Id;
            }
            else
            {
                e.NodeImageIndex = -1;
            }
        }
    }
}
