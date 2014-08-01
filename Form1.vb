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
            MyFolder = "C:\py\group1"
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

        totalupdates.Text = (("Total updates: ") & Val(lbupdates.Text) + Val(lbupdates2.Text))


    End Sub
    Private Sub bstop_Click(sender As Object, e As EventArgs) Handles bstop.Click
        Timer1.Enabled = False
        lbcountdown.Text = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Not System.IO.Directory.Exists("C:\py")) Then
            System.IO.Directory.CreateDirectory("C:\py")
        End If
        If (Not System.IO.Directory.Exists("C:\py\group1")) Then
            System.IO.Directory.CreateDirectory("C:\py\group1")
        End If
        If (Not System.IO.Directory.Exists("C:\py\group2")) Then
            System.IO.Directory.CreateDirectory("C:\py\group2")
        End If
        If (Not System.IO.Directory.Exists("C:\py\group3")) Then
            System.IO.Directory.CreateDirectory("C:\py\group3")
        End If

        Dim folderInfo As New IO.DirectoryInfo("c:\py\group1")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox1.Items.Add(fileInFolder.Name)
        Next

        totalupdates.Text = (("Total updates: ") & Val(lbupdates.Text) + Val(lbupdates2.Text))

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As String
        A = "C:\py\group1" & TextBox2.Text & ".py"
        FileCopy(TextBox1.Text, A)

        ListBox1.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py\group1")
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
        Dim folderInfo As New IO.DirectoryInfo("c:\py\group1")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox1.Items.Add(fileInFolder.Name)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox3.Text = "C:\py\group1\" & ListBox1.SelectedItem
    End Sub





    ' Group 2 under this line: -------------------------------------------------







    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        ListBox2.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py\group2")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox2.Items.Add(fileInFolder.Name)
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer2.Enabled = False
        lbcountdown2.Text = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.ShowDialog()
        directorybox2.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim A As String
        A = "C:\py\group2" & TextBox2.Text & ".py"
        FileCopy(TextBox1.Text, A)

        ListBox2.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py\group2")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox2.Items.Add(fileInFolder.Name)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.IO.File.Delete(directory2.Text)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox2.Items.Clear()
        Dim folderInfo As New IO.DirectoryInfo("c:\py\group2")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            ListBox2.Items.Add(fileInFolder.Name)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer2.Enabled = False
        If RadioButton6.Checked = True Then
            lbcountdown2.Text = Val(tbupdate2.Text)
        Else

        End If
        If RadioButton5.Checked = True Then
            lbcountdown2.Text = Val(tbupdate2.Text * 60)
        Else

        End If

        If RadioButton4.Checked = True Then
            lbcountdown2.Text = Val(tbupdate2.Text * 3600)
        Else

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If lbcountdown2.Text = 1 Then
            If RadioButton6.Checked = True Then
                lbcountdown2.Text = Val(tbupdate2.Text)
            Else
            End If

            If RadioButton5.Checked = True Then
                lbcountdown2.Text = Val(tbupdate2.Text) * 60
            Else
            End If

            If RadioButton4.Checked = True Then
                lbcountdown2.Text = Val(tbupdate2.Text) * 3600
            End If
            Dim MyFolder As String
            Dim MyFile As String
            MyFolder = "C:\py\group2"
            MyFile = Dir(MyFolder & "\*.py")
            Do While MyFile <> ""
                Process.Start(fileName:=MyFolder & "\" & MyFile)
                MyFile = Dir()
            Loop

            lbupdates2.Text = lbupdates2.Text + 1


        End If
        If lbcountdown2.Text = 0 Then
            Timer1.Enabled = False
            lbcountdown2.Text = lbcountdown2.Text + 1
        End If
        lbcountdown2.Text = Val(lbcountdown2.Text) - 1

        totalupdates.Text = (("Total updates: ") & Val(lbupdates.Text) + Val(lbupdates2.Text))

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        directory2.Text = "C:\py\group2\" & ListBox2.SelectedItem
    End Sub
End Class
