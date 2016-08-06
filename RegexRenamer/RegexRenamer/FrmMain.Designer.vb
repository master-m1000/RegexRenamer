<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblDirectory = New System.Windows.Forms.Label()
        Me.TbDirectory = New System.Windows.Forms.TextBox()
        Me.BtnDirectory = New System.Windows.Forms.Button()
        Me.LblLookupPattern = New System.Windows.Forms.Label()
        Me.LblReplacePattern = New System.Windows.Forms.Label()
        Me.TbLookupPattern = New System.Windows.Forms.TextBox()
        Me.TbReplacePattern = New System.Windows.Forms.TextBox()
        Me.BtnRename = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsPbStatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.TsLblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LvPreview = New System.Windows.Forms.ListView()
        Me.ChOldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNewName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TsDdBtnAbout = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblDirectory
        '
        Me.LblDirectory.AutoSize = True
        Me.LblDirectory.Location = New System.Drawing.Point(12, 15)
        Me.LblDirectory.Name = "LblDirectory"
        Me.LblDirectory.Size = New System.Drawing.Size(56, 13)
        Me.LblDirectory.TabIndex = 0
        Me.LblDirectory.Text = "&Directory:"
        '
        'TbDirectory
        '
        Me.TbDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbDirectory.Location = New System.Drawing.Point(74, 12)
        Me.TbDirectory.Name = "TbDirectory"
        Me.TbDirectory.Size = New System.Drawing.Size(568, 22)
        Me.TbDirectory.TabIndex = 1
        '
        'BtnDirectory
        '
        Me.BtnDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDirectory.Location = New System.Drawing.Point(648, 12)
        Me.BtnDirectory.Name = "BtnDirectory"
        Me.BtnDirectory.Size = New System.Drawing.Size(24, 23)
        Me.BtnDirectory.TabIndex = 2
        Me.BtnDirectory.Text = "..."
        Me.BtnDirectory.UseVisualStyleBackColor = True
        '
        'LblLookupPattern
        '
        Me.LblLookupPattern.AutoSize = True
        Me.LblLookupPattern.Location = New System.Drawing.Point(12, 43)
        Me.LblLookupPattern.Name = "LblLookupPattern"
        Me.LblLookupPattern.Size = New System.Drawing.Size(90, 13)
        Me.LblLookupPattern.TabIndex = 3
        Me.LblLookupPattern.Text = "&Lookup pattern:"
        '
        'LblReplacePattern
        '
        Me.LblReplacePattern.AutoSize = True
        Me.LblReplacePattern.Location = New System.Drawing.Point(12, 69)
        Me.LblReplacePattern.Name = "LblReplacePattern"
        Me.LblReplacePattern.Size = New System.Drawing.Size(91, 13)
        Me.LblReplacePattern.TabIndex = 4
        Me.LblReplacePattern.Text = "&Replace pattern:"
        '
        'TbLookupPattern
        '
        Me.TbLookupPattern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbLookupPattern.Location = New System.Drawing.Point(109, 40)
        Me.TbLookupPattern.Name = "TbLookupPattern"
        Me.TbLookupPattern.Size = New System.Drawing.Size(563, 22)
        Me.TbLookupPattern.TabIndex = 5
        '
        'TbReplacePattern
        '
        Me.TbReplacePattern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbReplacePattern.Location = New System.Drawing.Point(109, 68)
        Me.TbReplacePattern.Name = "TbReplacePattern"
        Me.TbReplacePattern.Size = New System.Drawing.Size(563, 22)
        Me.TbReplacePattern.TabIndex = 6
        '
        'BtnRename
        '
        Me.BtnRename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRename.Location = New System.Drawing.Point(12, 96)
        Me.BtnRename.Name = "BtnRename"
        Me.BtnRename.Size = New System.Drawing.Size(660, 23)
        Me.BtnRename.TabIndex = 7
        Me.BtnRename.Text = "Rename"
        Me.BtnRename.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsDdBtnAbout, Me.TsPbStatus, Me.TsLblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 299)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.TabIndex = 8
        '
        'TsPbStatus
        '
        Me.TsPbStatus.Name = "TsPbStatus"
        Me.TsPbStatus.Size = New System.Drawing.Size(100, 16)
        '
        'TsLblStatus
        '
        Me.TsLblStatus.Name = "TsLblStatus"
        Me.TsLblStatus.Size = New System.Drawing.Size(50, 17)
        Me.TsLblStatus.Text = "Loading"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please select a directory."
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'LvPreview
        '
        Me.LvPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChOldName, Me.ChNewName})
        Me.LvPreview.GridLines = True
        Me.LvPreview.Location = New System.Drawing.Point(12, 125)
        Me.LvPreview.Name = "LvPreview"
        Me.LvPreview.Size = New System.Drawing.Size(660, 171)
        Me.LvPreview.TabIndex = 9
        Me.LvPreview.UseCompatibleStateImageBehavior = False
        Me.LvPreview.View = System.Windows.Forms.View.Details
        '
        'ChOldName
        '
        Me.ChOldName.Text = "old name"
        Me.ChOldName.Width = 128
        '
        'ChNewName
        '
        Me.ChNewName.Text = "new name"
        Me.ChNewName.Width = 128
        '
        'TsDdBtnAbout
        '
        Me.TsDdBtnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TsDdBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TsDdBtnAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToGitHubToolStripMenuItem, Me.ToolStripSeparator1, Me.LicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.TsDdBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsDdBtnAbout.Name = "TsDdBtnAbout"
        Me.TsDdBtnAbout.Size = New System.Drawing.Size(53, 20)
        Me.TsDdBtnAbout.Text = "About"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GoToGitHubToolStripMenuItem
        '
        Me.GoToGitHubToolStripMenuItem.Name = "GoToGitHubToolStripMenuItem"
        Me.GoToGitHubToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GoToGitHubToolStripMenuItem.Text = "Go to GitHub"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 321)
        Me.Controls.Add(Me.LvPreview)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnRename)
        Me.Controls.Add(Me.TbReplacePattern)
        Me.Controls.Add(Me.TbLookupPattern)
        Me.Controls.Add(Me.LblReplacePattern)
        Me.Controls.Add(Me.LblLookupPattern)
        Me.Controls.Add(Me.BtnDirectory)
        Me.Controls.Add(Me.TbDirectory)
        Me.Controls.Add(Me.LblDirectory)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(300, 270)
        Me.Name = "FrmMain"
        Me.Text = "RegexRenamer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDirectory As Label
    Friend WithEvents TbDirectory As TextBox
    Friend WithEvents BtnDirectory As Button
    Friend WithEvents LblLookupPattern As Label
    Friend WithEvents LblReplacePattern As Label
    Friend WithEvents TbLookupPattern As TextBox
    Friend WithEvents TbReplacePattern As TextBox
    Friend WithEvents BtnRename As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsLblStatus As ToolStripStatusLabel
    Friend WithEvents TsPbStatus As ToolStripProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LvPreview As ListView
    Friend WithEvents ChOldName As ColumnHeader
    Friend WithEvents ChNewName As ColumnHeader
    Friend WithEvents TsDdBtnAbout As ToolStripDropDownButton
    Friend WithEvents GoToGitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
End Class
