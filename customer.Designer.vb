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
        dgvLaptops = New DataGridView()
        numDuration = New NumericUpDown()
        ComboBox1 = New ComboBox()
        btnSubmit = New Button()
        CType(dgvLaptops, ComponentModel.ISupportInitialize).BeginInit()
        CType(numDuration, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLaptops
        ' 
        dgvLaptops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaptops.Location = New Point(12, 98)
        dgvLaptops.Name = "dgvLaptops"
        dgvLaptops.Size = New Size(776, 294)
        dgvLaptops.TabIndex = 0
        ' 
        ' numDuration
        ' 
        numDuration.Location = New Point(647, 32)
        numDuration.Name = "numDuration"
        numDuration.Size = New Size(120, 23)
        numDuration.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(507, 31)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(660, 415)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 3
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(ComboBox1)
        Controls.Add(numDuration)
        Controls.Add(dgvLaptops)
        Name = "customer"
        Text = "customer"
        CType(dgvLaptops, ComponentModel.ISupportInitialize).EndInit()
        CType(numDuration, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvLaptops As DataGridView
    Friend WithEvents numDuration As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnSubmit As Button
End Class
