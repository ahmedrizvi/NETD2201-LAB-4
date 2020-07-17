<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarInventory
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
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cboMake
        '
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Location = New System.Drawing.Point(84, 6)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(135, 21)
        Me.cboMake.TabIndex = 0
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(41, 9)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(37, 13)
        Me.lblMake.TabIndex = 1
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(41, 44)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model:"
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(86, 81)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(133, 21)
        Me.cboYear.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(84, 41)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(135, 20)
        Me.txtModel.TabIndex = 4
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(41, 84)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(86, 120)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(133, 20)
        Me.txtPrice.TabIndex = 7
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(41, 156)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 13)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "Model:"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(87, 156)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(15, 14)
        Me.chkNew.TabIndex = 9
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'CarInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cboMake)
        Me.Name = "CarInventory"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMake As ComboBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents chkNew As CheckBox
End Class
