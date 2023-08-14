<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtWebsiteUrl = New TextBox()
        txtSavePath = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnSelectPath = New Button()
        btnStartClone = New Button()
        myProgressBar = New ProgressBar()
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtWebsiteUrl
        ' 
        txtWebsiteUrl.Location = New Point(148, 159)
        txtWebsiteUrl.Margin = New Padding(3, 4, 3, 4)
        txtWebsiteUrl.Name = "txtWebsiteUrl"
        txtWebsiteUrl.Size = New Size(313, 27)
        txtWebsiteUrl.TabIndex = 0
        ' 
        ' txtSavePath
        ' 
        txtSavePath.Location = New Point(148, 194)
        txtSavePath.Margin = New Padding(3, 4, 3, 4)
        txtSavePath.Name = "txtSavePath"
        txtSavePath.Size = New Size(313, 27)
        txtSavePath.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label1.Location = New Point(46, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 23)
        Label1.TabIndex = 2
        Label1.Text = "Web URL:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label2.Location = New Point(46, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 23)
        Label2.TabIndex = 3
        Label2.Text = "Save Path:"
        ' 
        ' btnSelectPath
        ' 
        btnSelectPath.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSelectPath.Location = New Point(148, 268)
        btnSelectPath.Margin = New Padding(3, 4, 3, 4)
        btnSelectPath.Name = "btnSelectPath"
        btnSelectPath.Size = New Size(151, 31)
        btnSelectPath.TabIndex = 4
        btnSelectPath.Text = "Select Path"
        btnSelectPath.UseVisualStyleBackColor = True
        ' 
        ' btnStartClone
        ' 
        btnStartClone.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnStartClone.Location = New Point(310, 268)
        btnStartClone.Margin = New Padding(3, 4, 3, 4)
        btnStartClone.Name = "btnStartClone"
        btnStartClone.Size = New Size(151, 31)
        btnStartClone.TabIndex = 5
        btnStartClone.Text = "Start"
        btnStartClone.UseVisualStyleBackColor = True
        ' 
        ' myProgressBar
        ' 
        myProgressBar.Location = New Point(148, 229)
        myProgressBar.Margin = New Padding(3, 4, 3, 4)
        myProgressBar.Name = "myProgressBar"
        myProgressBar.Size = New Size(313, 31)
        myProgressBar.TabIndex = 6
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_1__png_e337492d02c345db2116506bc63cff1d
        PictureBox1.Location = New Point(30, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(431, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.pngegg
        PictureBox2.Location = New Point(8, 155)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pngegg
        PictureBox3.Location = New Point(8, 192)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(35, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(473, 312)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(myProgressBar)
        Controls.Add(btnStartClone)
        Controls.Add(btnSelectPath)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSavePath)
        Controls.Add(txtWebsiteUrl)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "WebXClone 1.0 | level23hacktools.com"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtWebsiteUrl As TextBox
    Friend WithEvents txtSavePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelectPath As Button
    Friend WithEvents btnStartClone As Button
    Friend WithEvents myProgressBar As ProgressBar
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
