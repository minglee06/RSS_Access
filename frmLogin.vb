Imports System.Xml
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtPwd.PasswordChar = "*"
        Me.txtPwd.MaxLength = 12
        Me.txtAccount.MaxLength = 20
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.txtAccount.Text = ""
        Me.txtPwd.Text = ""
        lblAccountStr.Text = ""
        lblPwdStr.Text = ""
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim myNameStr As String = txtAccount.Text
        Dim myPwdStr As String = txtPwd.Text
        Dim myXml As New XmlDocument
        Dim myXmlRd As XmlReader = XmlReader.Create("C://RSS_Access/bin/App_Data/Data.xml")
        myXml.Load(myXmlRd)
        Dim myXnode As XmlNode = myXml.SelectSingleNode("Users")
        Dim myXnodeList As XmlNodeList = myXnode.ChildNodes
        myXmlRd.MoveToElement()
        myXmlRd.Read()
        lblAccountStr.Text = ""
        lblPwdStr.Text = ""
        Dim i As Integer
        For i = 0 To myXnodeList.Count - 1

            If myNameStr = myXnodeList.Item(i).Attributes("Account").Value And myPwdStr = myXnodeList.Item(i).Attributes("Password").Value Then
                myXmlRd.Close()
                txtAccount.Text = ""
                txtPwd.Text = ""
                Me.Hide()
                frmLoginSucced.Show()
                MessageBox.Show("登入成功")
                'frmMain.Show()
                Exit For

            ElseIf myNameStr <> myXnodeList.Item(i).Attributes("Account").Value And i = myXnodeList.Count - 1 Then
                If myNameStr = "" Then
                    lblAccountStr.Text = "帳號不能空白"
                    Exit Sub
                Else
                    lblAccountStr.Text = "無此帳號"
                    Exit For
                End If
                myXmlRd.Close()
                txtAccount.Text = ""
                txtPwd.Text = ""
            ElseIf myPwdStr <> myXnodeList.Item(i).Attributes("Password").Value And i = myXnodeList.Count - 1 Then
                If myPwdStr = "" Then
                    lblPwdStr.Text = "密碼不能空白"
                    Exit For
                Else
                    lblPwdStr.Text = "密碼錯誤"
                    Exit For
                End If
                myXmlRd.Close()
                txtAccount.Text = ""
                txtPwd.Text = ""
            End If
        Next
    End Sub
End Class