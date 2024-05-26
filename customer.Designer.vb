<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        dgvLaptops = New DataGridView()
        numDuration = New NumericUpDown()
        btnSubmit = New Button()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        Button2 = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgvLaptops, ComponentModel.ISupportInitialize).BeginInit()
        CType(numDuration, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLaptops
        ' 
        dgvLaptops.BackgroundColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        dgvLaptops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaptops.Location = New Point(14, 71)
        dgvLaptops.Margin = New Padding(4, 5, 4, 5)
        dgvLaptops.Name = "dgvLaptops"
        dgvLaptops.Size = New Size(936, 299)
        dgvLaptops.TabIndex = 0
        ' 
        ' numDuration
        ' 
        numDuration.Location = New Point(190, 20)
        numDuration.Margin = New Padding(4, 5, 4, 5)
        numDuration.Name = "numDuration"
        numDuration.Size = New Size(212, 29)
        numDuration.TabIndex = 1
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("STHupo", 15.7499981F)
        btnSubmit.Location = New Point(425, 375)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(118, 45)
        btnSubmit.TabIndex = 3
        btnSubmit.Text = "submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(48, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 22)
        Label1.TabIndex = 4
        Label1.Text = "Berapa hari :"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("STHupo", 15.7499981F)
        Button2.Location = New Point(839, 384)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 13
        Button2.Text = "back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(87), CByte(123), CByte(141))
        ClientSize = New Size(959, 435)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(numDuration)
        Controls.Add(dgvLaptops)
        Font = New Font("STHupo", 15.7499981F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "customer"
        Text = "customer"
        CType(dgvLaptops, ComponentModel.ISupportInitialize).EndInit()
        CType(numDuration, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvLaptops As DataGridView
    Friend WithEvents numDuration As NumericUpDown
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
