﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VReporteGastoCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VReporteGastoCuentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_GastosCuentasReporte_aceptar = New System.Windows.Forms.Button()
        Me.DateTimePicker_GastosCuentasReporte_ff = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_GastosCuentasReporte_fi = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 93)
        Me.Panel1.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(365, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Reporte de Cuentas de Salidas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(158, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(155, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Desde"
        '
        'Button_GastosCuentasReporte_aceptar
        '
        Me.Button_GastosCuentasReporte_aceptar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button_GastosCuentasReporte_aceptar.ForeColor = System.Drawing.Color.White
        Me.Button_GastosCuentasReporte_aceptar.Location = New System.Drawing.Point(219, 281)
        Me.Button_GastosCuentasReporte_aceptar.Name = "Button_GastosCuentasReporte_aceptar"
        Me.Button_GastosCuentasReporte_aceptar.Size = New System.Drawing.Size(196, 52)
        Me.Button_GastosCuentasReporte_aceptar.TabIndex = 58
        Me.Button_GastosCuentasReporte_aceptar.Text = "Generar"
        Me.Button_GastosCuentasReporte_aceptar.UseVisualStyleBackColor = True
        '
        'DateTimePicker_GastosCuentasReporte_ff
        '
        Me.DateTimePicker_GastosCuentasReporte_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosCuentasReporte_ff.Location = New System.Drawing.Point(219, 202)
        Me.DateTimePicker_GastosCuentasReporte_ff.Name = "DateTimePicker_GastosCuentasReporte_ff"
        Me.DateTimePicker_GastosCuentasReporte_ff.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_GastosCuentasReporte_ff.TabIndex = 57
        '
        'DateTimePicker_GastosCuentasReporte_fi
        '
        Me.DateTimePicker_GastosCuentasReporte_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_GastosCuentasReporte_fi.Location = New System.Drawing.Point(219, 171)
        Me.DateTimePicker_GastosCuentasReporte_fi.Name = "DateTimePicker_GastosCuentasReporte_fi"
        Me.DateTimePicker_GastosCuentasReporte_fi.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_GastosCuentasReporte_fi.TabIndex = 56
        '
        'VReporteGastoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 389)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_GastosCuentasReporte_aceptar)
        Me.Controls.Add(Me.DateTimePicker_GastosCuentasReporte_ff)
        Me.Controls.Add(Me.DateTimePicker_GastosCuentasReporte_fi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VReporteGastoCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_GastosCuentasReporte_aceptar As Button
    Friend WithEvents DateTimePicker_GastosCuentasReporte_ff As DateTimePicker
    Friend WithEvents DateTimePicker_GastosCuentasReporte_fi As DateTimePicker
End Class
