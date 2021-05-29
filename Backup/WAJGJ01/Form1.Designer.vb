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
        Me.LBLNombre = New System.Windows.Forms.Label
        Me.TXTNombre = New System.Windows.Forms.TextBox
        Me.BTNSaludo = New System.Windows.Forms.Button
        Me.LBLSaludo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LBLNombre
        '
        Me.LBLNombre.AutoSize = True
        Me.LBLNombre.Location = New System.Drawing.Point(45, 45)
        Me.LBLNombre.Name = "LBLNombre"
        Me.LBLNombre.Size = New System.Drawing.Size(95, 13)
        Me.LBLNombre.TabIndex = 0
        Me.LBLNombre.Text = "Ingresa tu nombre:"
        '
        'TXTNombre
        '
        Me.TXTNombre.Location = New System.Drawing.Point(146, 42)
        Me.TXTNombre.Name = "TXTNombre"
        Me.TXTNombre.Size = New System.Drawing.Size(100, 20)
        Me.TXTNombre.TabIndex = 1
        '
        'BTNSaludo
        '
        Me.BTNSaludo.Location = New System.Drawing.Point(102, 165)
        Me.BTNSaludo.Name = "BTNSaludo"
        Me.BTNSaludo.Size = New System.Drawing.Size(75, 23)
        Me.BTNSaludo.TabIndex = 6
        Me.BTNSaludo.Text = "Saludo"
        Me.BTNSaludo.UseVisualStyleBackColor = True
        '
        'LBLSaludo
        '
        Me.LBLSaludo.AutoSize = True
        Me.LBLSaludo.Location = New System.Drawing.Point(114, 101)
        Me.LBLSaludo.Name = "LBLSaludo"
        Me.LBLSaludo.Size = New System.Drawing.Size(0, 13)
        Me.LBLSaludo.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 226)
        Me.Controls.Add(Me.LBLSaludo)
        Me.Controls.Add(Me.BTNSaludo)
        Me.Controls.Add(Me.TXTNombre)
        Me.Controls.Add(Me.LBLNombre)
        Me.Name = "Form1"
        Me.Text = "Saludo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLNombre As System.Windows.Forms.Label
    Friend WithEvents TXTNombre As System.Windows.Forms.TextBox
    Friend WithEvents BTNSaludo As System.Windows.Forms.Button
    Friend WithEvents LBLSaludo As System.Windows.Forms.Label

End Class
