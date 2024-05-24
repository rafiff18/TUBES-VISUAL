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
        dgvLaptops.BackgroundColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        dgvLaptops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaptops.Location = New Point(13, 76)
        dgvLaptops.Margin = New Padding(4)
        dgvLaptops.Name = "dgvLaptops"
        dgvLaptops.Size = New Size(905, 258)
        dgvLaptops.TabIndex = 0
        ' 
        ' numDuration
        ' 
        numDuration.Location = New Point(738, 24)
        numDuration.Margin = New Padding(4)
        numDuration.Name = "numDuration"
        numDuration.Size = New Size(171, 26)
        numDuration.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(538, 22)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(171, 27)
        ComboBox1.TabIndex = 2
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(811, 364)
        btnSubmit.Margin = New Padding(4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(107, 39)
        btnSubmit.TabIndex = 3
        btnSubmit.Text = "submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(87), CByte(123), CByte(141))
        ClientSize = New Size(931, 422)
        Controls.Add(btnSubmit)
        Controls.Add(ComboBox1)
        Controls.Add(numDuration)
        Controls.Add(dgvLaptops)
        Font = New Font("Stencil", 12F)
        Margin = New Padding(4)
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
