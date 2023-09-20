Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Columns
Imports System.Threading
Imports DevExpress.XtraTreeList

Namespace SimpleTreeListExample

    Public Partial Class ExampleMainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim newColumnDescription As TreeListColumn = MyTtreeList.Columns.Add()
            newColumnDescription.FieldName = "Description"
            newColumnDescription.VisibleIndex = 0
            MyTtreeList.SelectImageList = imageListForTree
            MyTtreeList.DataSource = New Object()
        End Sub

        Private Sub treeList1_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo)
            Dim sCurrentNode As String = TryCast(e.Node, String)
            If Equals(sCurrentNode, Nothing) Then
                e.Children = New String() {"Root node 1", "Root node 2", "Root node 3"}
            Else
                e.Children = CreateChildrenNodes(sCurrentNode)
            End If
        End Sub

        Private Function CreateChildrenNodes(ByVal sCurrentNode As String) As BindingList(Of String)
            Dim sChildren As BindingList(Of String) = New BindingList(Of String)()
            Using workerForChildren As BackgroundWorker = New BackgroundWorker()
                AddHandler workerForChildren.DoWork, New DoWorkEventHandler(AddressOf workerForChildren_DoWork)
                workerForChildren.RunWorkerAsync(sChildren)
            End Using

            Return sChildren
        End Function

        Private Sub workerForChildren_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Dim sChildren As BindingList(Of String) = TryCast(e.Argument, BindingList(Of String))
            For i As Integer = 0 To 4 - 1
                BeginInvoke(New MethodInvoker(Sub() sChildren.Add(String.Format("Child node {0}", i))))
                Thread.Sleep(1000)
            Next
        End Sub

        Private Sub treeList1_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo)
            e.CellData = e.Node
        End Sub

        Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As GetSelectImageEventArgs)
            If e.Node.Id < imageListForTree.Images.Count Then
                e.NodeImageIndex = e.Node.Id
            Else
                e.NodeImageIndex = -1
            End If
        End Sub
    End Class
End Namespace
