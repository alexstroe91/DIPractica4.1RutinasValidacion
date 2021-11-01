<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNombre = New System.Windows.Forms.Button()
        Me.btnNumero = New System.Windows.Forms.Button()
        Me.btnNif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNombre
        '
        Me.btnNombre.BackColor = System.Drawing.Color.Thistle
        Me.btnNombre.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNombre.ForeColor = System.Drawing.Color.Maroon
        Me.btnNombre.Location = New System.Drawing.Point(18, 12)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.Size = New System.Drawing.Size(219, 40)
        Me.btnNombre.TabIndex = 0
        Me.btnNombre.Text = "NOMBRE COMPUESTO"
        Me.btnNombre.UseVisualStyleBackColor = False
        '
        'btnNumero
        '
        Me.btnNumero.BackColor = System.Drawing.Color.Thistle
        Me.btnNumero.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumero.ForeColor = System.Drawing.Color.Maroon
        Me.btnNumero.Location = New System.Drawing.Point(18, 67)
        Me.btnNumero.Name = "btnNumero"
        Me.btnNumero.Size = New System.Drawing.Size(219, 40)
        Me.btnNumero.TabIndex = 1
        Me.btnNumero.Text = "NUMERO DECIMAL"
        Me.btnNumero.UseVisualStyleBackColor = False
        '
        'btnNif
        '
        Me.btnNif.BackColor = System.Drawing.Color.Thistle
        Me.btnNif.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNif.ForeColor = System.Drawing.Color.Maroon
        Me.btnNif.Location = New System.Drawing.Point(18, 122)
        Me.btnNif.Name = "btnNif"
        Me.btnNif.Size = New System.Drawing.Size(219, 40)
        Me.btnNif.TabIndex = 2
        Me.btnNif.Text = "NIF"
        Me.btnNif.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(249, 174)
        Me.Controls.Add(Me.btnNif)
        Me.Controls.Add(Me.btnNumero)
        Me.Controls.Add(Me.btnNombre)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNombre As Button
    Friend WithEvents btnNumero As Button
    Friend WithEvents btnNif As Button
End Class
