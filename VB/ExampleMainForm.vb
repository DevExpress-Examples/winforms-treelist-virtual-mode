Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports System.Threading
Imports DevExpress.XtraTreeList

Namespace SimpleTreeListExample
	Partial Public Class ExampleMainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Dim newColumnDescription As TreeListColumn = MyTtreeList.Columns.Add()
			newColumnDescription.FieldName = "Description"
			newColumnDescription.VisibleIndex = 0

			MyTtreeList.SelectImageList = imageListForTree
			MyTtreeList.DataSource = New Object()
		End Sub

		Private Sub treeList1_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Handles MyTtreeList.VirtualTreeGetChildNodes
			Dim sCurrentNode As String = TryCast(e.Node, String)
			If sCurrentNode Is Nothing Then
				e.Children = New String() { "Root node 1", "Root node 2", "Root node 3" }
			Else
				e.Children = CreateChildrenNodes(sCurrentNode)
			End If
		End Sub

		Private Function CreateChildrenNodes(ByVal sCurrentNode As String) As BindingList(Of String)
			Dim sChildren As New BindingList(Of String)()
			Using workerForChildren As New BackgroundWorker()
				AddHandler workerForChildren.DoWork, AddressOf workerForChildren_DoWork
				workerForChildren.RunWorkerAsync(sChildren)
			End Using
			Return sChildren
		End Function

		Private Sub workerForChildren_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim sChildren As BindingList(Of String) = TryCast(e.Argument, BindingList(Of String))
			For i As Integer = 0 To 3
				BeginInvoke(New MethodInvoker(Function() AnonymousMethod1(sChildren, i)))
				Thread.Sleep(1000)
			Next i
		End Sub
		
		Private Function AnonymousMethod1(ByVal sChildren As BindingList(Of String), ByVal i As Integer) As Boolean
			sChildren.Add(String.Format("Child node {0}", i))
			Return True
		End Function

		Private Sub treeList1_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Handles MyTtreeList.VirtualTreeGetCellValue
			e.CellData = e.Node
		End Sub

		Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles MyTtreeList.GetSelectImage
			If e.Node.Id < imageListForTree.Images.Count Then
				e.NodeImageIndex = e.Node.Id
			Else
				e.NodeImageIndex = -1
			End If
		End Sub
	End Class
End Namespace
