Imports Microsoft.VisualBasic
Imports System
Namespace SimpleTreeListExample
	Partial Public Class ExampleMainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ExampleMainForm))
			Me.MyTtreeList = New DevExpress.XtraTreeList.TreeList()
			Me.imageListForTree = New System.Windows.Forms.ImageList(Me.components)
			Me.myBackgroundWorker = New System.ComponentModel.BackgroundWorker()
			CType(Me.MyTtreeList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' MyTtreeList
			' 
			Me.MyTtreeList.Dock = System.Windows.Forms.DockStyle.Fill
			Me.MyTtreeList.Location = New System.Drawing.Point(0, 0)
			Me.MyTtreeList.Name = "MyTtreeList"
			Me.MyTtreeList.Size = New System.Drawing.Size(479, 350)
			Me.MyTtreeList.TabIndex = 0
'			Me.MyTtreeList.VirtualTreeGetChildNodes += New DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(Me.treeList1_VirtualTreeGetChildNodes);
'			Me.MyTtreeList.VirtualTreeGetCellValue += New DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(Me.treeList1_VirtualTreeGetCellValue);
'			Me.MyTtreeList.GetSelectImage += New DevExpress.XtraTreeList.GetSelectImageEventHandler(Me.treeList1_GetSelectImage);
			' 
			' imageListForTree
			' 
			Me.imageListForTree.ImageStream = (CType(resources.GetObject("imageListForTree.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageListForTree.TransparentColor = System.Drawing.Color.Transparent
			Me.imageListForTree.Images.SetKeyName(0, "1-1.bmp")
			Me.imageListForTree.Images.SetKeyName(1, "1-2.bmp")
			Me.imageListForTree.Images.SetKeyName(2, "1-3.bmp")
			Me.imageListForTree.Images.SetKeyName(3, "1-4.bmp")
			Me.imageListForTree.Images.SetKeyName(4, "1-5.bmp")
			Me.imageListForTree.Images.SetKeyName(5, "2-1.bmp")
			Me.imageListForTree.Images.SetKeyName(6, "2-2.bmp")
			Me.imageListForTree.Images.SetKeyName(7, "2-3.bmp")
			Me.imageListForTree.Images.SetKeyName(8, "2-4.bmp")
			Me.imageListForTree.Images.SetKeyName(9, "2-5.bmp")
			' 
			' ExampleMainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(479, 350)
			Me.Controls.Add(Me.MyTtreeList)
			Me.Name = "ExampleMainForm"
			Me.Text = "Example main form"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.MyTtreeList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents MyTtreeList As DevExpress.XtraTreeList.TreeList
		Private imageListForTree As System.Windows.Forms.ImageList
		Private myBackgroundWorker As System.ComponentModel.BackgroundWorker
	End Class
End Namespace

