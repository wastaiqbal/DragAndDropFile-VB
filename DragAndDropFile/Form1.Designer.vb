<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PicIcon = New System.Windows.Forms.PictureBox()
        Me.LbModified = New System.Windows.Forms.Label()
        Me.LbCreated = New System.Windows.Forms.Label()
        Me.LbFiletype = New System.Windows.Forms.Label()
        Me.LbFilesize = New System.Windows.Forms.Label()
        Me.LbFilename = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.BtnDropFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicIcon)
        Me.GroupBox1.Controls.Add(Me.LbModified)
        Me.GroupBox1.Controls.Add(Me.LbCreated)
        Me.GroupBox1.Controls.Add(Me.LbFiletype)
        Me.GroupBox1.Controls.Add(Me.LbFilesize)
        Me.GroupBox1.Controls.Add(Me.LbFilename)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 167)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(693, 191)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Info"
        '
        'PicIcon
        '
        Me.PicIcon.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PicIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicIcon.Location = New System.Drawing.Point(20, 29)
        Me.PicIcon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PicIcon.Name = "PicIcon"
        Me.PicIcon.Size = New System.Drawing.Size(59, 60)
        Me.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIcon.TabIndex = 5
        Me.PicIcon.TabStop = False
        '
        'LbModified
        '
        Me.LbModified.AutoSize = True
        Me.LbModified.Location = New System.Drawing.Point(102, 152)
        Me.LbModified.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbModified.Name = "LbModified"
        Me.LbModified.Size = New System.Drawing.Size(73, 20)
        Me.LbModified.TabIndex = 4
        Me.LbModified.Text = "Modified:"
        '
        'LbCreated
        '
        Me.LbCreated.AutoSize = True
        Me.LbCreated.Location = New System.Drawing.Point(102, 128)
        Me.LbCreated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCreated.Name = "LbCreated"
        Me.LbCreated.Size = New System.Drawing.Size(70, 20)
        Me.LbCreated.TabIndex = 3
        Me.LbCreated.Text = "Created:"
        '
        'LbFiletype
        '
        Me.LbFiletype.AutoSize = True
        Me.LbFiletype.Location = New System.Drawing.Point(102, 55)
        Me.LbFiletype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbFiletype.Name = "LbFiletype"
        Me.LbFiletype.Size = New System.Drawing.Size(76, 20)
        Me.LbFiletype.TabIndex = 2
        Me.LbFiletype.Text = "File Type:"
        '
        'LbFilesize
        '
        Me.LbFilesize.AutoSize = True
        Me.LbFilesize.Location = New System.Drawing.Point(102, 80)
        Me.LbFilesize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbFilesize.Name = "LbFilesize"
        Me.LbFilesize.Size = New System.Drawing.Size(73, 20)
        Me.LbFilesize.TabIndex = 1
        Me.LbFilesize.Text = "File Size:"
        '
        'LbFilename
        '
        Me.LbFilename.AutoSize = True
        Me.LbFilename.Location = New System.Drawing.Point(102, 29)
        Me.LbFilename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbFilename.Name = "LbFilename"
        Me.LbFilename.Size = New System.Drawing.Size(84, 20)
        Me.LbFilename.TabIndex = 0
        Me.LbFilename.Text = "File Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Drag And Drop Your File"
        '
        'BtnOpen
        '
        Me.BtnOpen.AllowDrop = True
        Me.BtnOpen.Location = New System.Drawing.Point(621, 122)
        Me.BtnOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(112, 35)
        Me.BtnOpen.TabIndex = 6
        Me.BtnOpen.Text = "Open File"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'TxtFileName
        '
        Me.TxtFileName.AllowDrop = True
        Me.TxtFileName.Location = New System.Drawing.Point(39, 509)
        Me.TxtFileName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.ReadOnly = True
        Me.TxtFileName.Size = New System.Drawing.Size(694, 26)
        Me.TxtFileName.TabIndex = 5
        '
        'BtnDropFile
        '
        Me.BtnDropFile.AllowDrop = True
        Me.BtnDropFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDropFile.Location = New System.Drawing.Point(60, 382)
        Me.BtnDropFile.Name = "BtnDropFile"
        Me.BtnDropFile.Size = New System.Drawing.Size(650, 105)
        Me.BtnDropFile.TabIndex = 9
        Me.BtnDropFile.Text = "Drop File Here"
        Me.BtnDropFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Click to open your file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 648)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.TxtFileName)
        Me.Controls.Add(Me.BtnDropFile)
        Me.Name = "Form1"
        Me.Text = "FormDropFile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PicIcon As System.Windows.Forms.PictureBox
    Friend WithEvents LbModified As System.Windows.Forms.Label
    Friend WithEvents LbCreated As System.Windows.Forms.Label
    Friend WithEvents LbFiletype As System.Windows.Forms.Label
    Friend WithEvents LbFilesize As System.Windows.Forms.Label
    Friend WithEvents LbFilename As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents TxtFileName As System.Windows.Forms.TextBox
    Friend WithEvents BtnDropFile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
