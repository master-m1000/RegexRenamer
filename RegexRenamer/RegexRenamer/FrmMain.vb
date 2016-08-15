Public Class FrmMain
    Dim fileList As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.Icon
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetStatus("Ready", 0)
    End Sub

    Private Sub BtnDirectory_Click(sender As Object, e As EventArgs) Handles BtnDirectory.Click
        If IO.Directory.Exists(TbDirectory.Text) = True Then
            FolderBrowserDialog1.SelectedPath = TbDirectory.Text
        End If
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TbDirectory.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtnRename_Click(sender As Object, e As EventArgs) Handles BtnRename.Click
        If String.IsNullOrEmpty(TbLookupPattern.Text) = False And String.IsNullOrEmpty(TbReplacePattern.Text) = False Then
            If MessageBox.Show(Me, "Are you sure to continue?" & vbNewLine & "That is the last chance to cancel!", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                SetStatus("Checking directory...", 0, ProgressBarStyle.Marquee)
                If IO.Directory.Exists(TbDirectory.Text) = True And TbDirectory.Text.Count > 2 Then
                    Dim processedFiles As Integer = 0, renamedFiles As Integer = 0
                    For Each file In fileList
                        If Not GetNewFilename(file) Is Nothing Then
                            Try
                                IO.File.Move(IO.Path.Combine(TbDirectory.Text, file), IO.Path.Combine(TbDirectory.Text, GetNewFilename(file)))
                                renamedFiles += 1
                            Catch ex As Exception
                                Dim message As String
                                If ex.InnerException Is Nothing Then
                                    message = "There was an error: " & vbNewLine & ex.ToString
                                Else
                                    message = "There was an error: " & vbNewLine & ex.ToString & vbNewLine & ex.InnerException.ToString
                                End If
                                Select Case MessageBox.Show(Me, message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                    Case DialogResult.Abort
                                        SetStatus("Aborted!", 0)
                                        Exit Sub
                                    Case DialogResult.Retry
                                        Try
                                            IO.File.Move(IO.Path.Combine(TbDirectory.Text, file), IO.Path.Combine(TbDirectory.Text, GetNewFilename(file)))
                                            renamedFiles += 1
                                        Catch ex2 As Exception
                                            Dim message2 As String
                                            If ex.InnerException Is Nothing Then
                                                message2 = "There was an error: " & vbNewLine & ex.ToString
                                            Else
                                                message2 = "There was an error: " & vbNewLine & ex.ToString & vbNewLine & ex.InnerException.ToString
                                            End If
                                            If MessageBox.Show(Me, message & vbNewLine & vbNewLine & "Continuing with next file.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Cancel Then
                                                SetStatus("Aborted!", 0)
                                                Exit Sub
                                            End If
                                        End Try
                                End Select
                            End Try
                        End If
                        processedFiles += 1
                        SetStatus("Renaming (" & processedFiles & " of " & fileList.Count & ") ...", processedFiles, fileList.Count)
                    Next
                    RefreshPreview(TbDirectory, New EventArgs)
                    SetStatus("Renamed " & renamedFiles & "of " & processedFiles, processedFiles)
                Else
                    SetStatus("Directory doesn't exist!", 0, ProgressBarStyle.Blocks)
                    TbDirectory.ForeColor = Color.Red
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub RefreshPreview(sender As Object, e As EventArgs) Handles TbDirectory.TextChanged, TbLookupPattern.TextChanged, TbReplacePattern.TextChanged
        LvPreview.Items.Clear()

        If sender Is TbDirectory Then
            fileList.Clear()
            If IO.Directory.Exists(TbDirectory.Text) = True And TbDirectory.Text.Count > 2 Then
                TbDirectory.ForeColor = SystemColors.WindowText
                SetStatus("Scanning directory...", 0, ProgressBarStyle.Marquee)
                For Each file In IO.Directory.GetFiles(TbDirectory.Text)
                    fileList.Add(IO.Path.GetFileName(file))
                Next
            Else
                SetStatus("Directory doesn't exist!", 0, ProgressBarStyle.Blocks)
                TbDirectory.ForeColor = Color.Red
                Exit Sub
            End If
        End If

        SetStatus("Refreshing preview...", 0, ProgressBarStyle.Marquee)
        For Each file In fileList
            Dim lvItem As ListViewItem
            lvItem = LvPreview.Items.Add(file)
            Try
                lvItem.SubItems.AddRange(New String() {GetNewFilename(file)})
            Catch ex As Exception
                lvItem.SubItems.AddRange(New String() {IO.Path.GetFileName(file)})
            End Try

        Next
        SetStatus("Refreshed preview!", 0, ProgressBarStyle.Blocks)
    End Sub

    Private Function GetNewFilename(oldFilename As String) As String
        Dim result As String = Nothing
        Dim lookupPattern As String = TbLookupPattern.Text
        Dim replacePattern As String = TbReplacePattern.Text
        Dim regexMC As Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(oldFilename, lookupPattern)
        If regexMC.Count > 0 Then
            result = regexMC(0).Result(replacePattern)
        End If
        Return result
    End Function

#Region "Status"
    ''' <summary>
    ''' Set the status and progress
    ''' </summary>
    ''' <param name="statusText"></param>
    ''' <param name="progress"></param>
    ''' <param name="style"></param>
    Public Sub SetStatus(statusText As String, progress As Integer, Optional style As ProgressBarStyle = ProgressBarStyle.Blocks)
        TsLblStatus.Text = statusText
        TsPbStatus.Style = style
        TsPbStatus.Value = progress
        Update()
    End Sub

    ''' <summary>
    ''' Set the status and progress
    ''' </summary>
    ''' <param name="statusText"></param>
    ''' <param name="progress"></param>
    ''' <param name="maxProgress"></param>
    ''' <param name="style"></param>
    Public Sub SetStatus(statusText As String, progress As Integer, maxProgress As Integer, Optional style As ProgressBarStyle = ProgressBarStyle.Blocks)
        TsLblStatus.Text = statusText
        TsPbStatus.Maximum = maxProgress
        TsPbStatus.Style = style
        TsPbStatus.Value = progress
        Update()
    End Sub
#End Region

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show(Me, "RegexRenamer" & vbNewLine & "Version " & Application.ProductVersion & vbNewLine & "made by Mario Wagenknecht" & vbNewLine & vbNewLine & "Get more information at GitHub!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click
        MessageBox.Show(Me, "MIT License" & vbNewLine & vbNewLine & "Copyright (c) 2016 Mario Wagenknecht" & vbNewLine & vbNewLine & "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:" & vbNewLine & vbNewLine & "The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software." & vbNewLine & vbNewLine & "THE SOFTWARE IS PROVIDED ""As Is"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.", "License", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
