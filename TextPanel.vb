Public Class TextPanel
    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()


    End Sub

    Private Sub TextPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Location = New Point(6, 16)
    End Sub
End Class
