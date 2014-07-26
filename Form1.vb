Public Class Form1
    Private Sub bstart_Click(sender As Object, e As EventArgs) Handles bstart.Click
        Timer1.Enabled = True
    End Sub
    Private Sub bset_Click(sender As Object, e As EventArgs) Handles bset.Click
        Timer1.Enabled = False
        If RadioButton1.Checked = True Then
            lbcountdown.Text = Val(tbupdate.Text)
        Else

        End If
        If RadioButton2.Checked = True Then
            lbcountdown.Text = Val(tbupdate.Text * 60)
        Else
            
        End If

        If RadioButton3.Checked = True Then
            lbcountdown.Text = Val(tbupdate.Text * 3600)
        Else

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbcountdown.Text = 1 Then
            If RadioButton1.Checked = True Then
                lbcountdown.Text = Val(tbupdate.Text)
            Else
            End If

            If RadioButton2.Checked = True Then
                lbcountdown.Text = Val(tbupdate.Text) * 60
            Else
            End If

            If RadioButton3.Checked = True Then
                lbcountdown.Text = Val(tbupdate.Text) * 3600
            End If
            Dim MyFolder As String
            Dim MyFile As String
            MyFolder = "C:\py"
            MyFile = Dir(MyFolder & "\*.py")
            Do While MyFile <> ""
                Process.Start(fileName:=MyFolder & "\" & MyFile)
                MyFile = Dir()
            Loop

            lbupdates.Text = lbupdates.Text + 1
        End If
        If lbcountdown.Text = 0 Then
            Timer1.Enabled = False
            lbcountdown.Text = lbcountdown.Text + 1
        End If
        lbcountdown.Text = Val(lbcountdown.Text) - 1
    End Sub
    Private Sub bstop_Click(sender As Object, e As EventArgs) Handles bstop.Click
        Timer1.Enabled = False
        lbcountdown.Text = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Not System.IO.Directory.Exists("C:\py")) Then
            System.IO.Directory.CreateDirectory("C:\py")
        End If


        Dim folderInfo As New IO.DirectoryInfo("c:\py")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox1.Items.Add(fileInFolder.Name)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As String
        A = "C:\py\" & TextBox2.Text & ".py"
        FileCopy(TextBox1.Text, A)

        ListBox1.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox1.Items.Add(fileInFolder.Name)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.IO.File.Delete(TextBox3.Text)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox1.Items.Add(fileInFolder.Name)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox3.Text = "C:\py\" & ListBox1.SelectedItem
    End Sub
End Class
