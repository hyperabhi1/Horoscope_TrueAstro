<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.cmbSgn = New System.Windows.Forms.ComboBox()
        Me.cmbStl = New System.Windows.Forms.ComboBox()
        Me.cmbSub = New System.Windows.Forms.ComboBox()
        Me.cmbSSL = New System.Windows.Forms.ComboBox()
        Me.cmbSuk = New System.Windows.Forms.ComboBox()
        Me.cmbPra = New System.Windows.Forms.ComboBox()
        Me.cmbsPra = New System.Windows.Forms.ComboBox()
        Me.cmbSSP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbSgn
        '
        Me.cmbSgn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSgn.FormattingEnabled = True
        Me.cmbSgn.Items.AddRange(New Object() {"Ari", "Tau", "Gem", "Can", "Leo", "Vir", "Lib", "Sco", "Sag", "Cap", "Aqu", "Pis"})
        Me.cmbSgn.Location = New System.Drawing.Point(12, 31)
        Me.cmbSgn.Name = "cmbSgn"
        Me.cmbSgn.Size = New System.Drawing.Size(58, 28)
        Me.cmbSgn.TabIndex = 0
        '
        'cmbStl
        '
        Me.cmbStl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStl.FormattingEnabled = True
        Me.cmbStl.Location = New System.Drawing.Point(82, 31)
        Me.cmbStl.Name = "cmbStl"
        Me.cmbStl.Size = New System.Drawing.Size(58, 28)
        Me.cmbStl.TabIndex = 1
        '
        'cmbSub
        '
        Me.cmbSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSub.FormattingEnabled = True
        Me.cmbSub.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbSub.Location = New System.Drawing.Point(152, 31)
        Me.cmbSub.Name = "cmbSub"
        Me.cmbSub.Size = New System.Drawing.Size(58, 28)
        Me.cmbSub.TabIndex = 2
        '
        'cmbSSL
        '
        Me.cmbSSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSL.FormattingEnabled = True
        Me.cmbSSL.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbSSL.Location = New System.Drawing.Point(222, 31)
        Me.cmbSSL.Name = "cmbSSL"
        Me.cmbSSL.Size = New System.Drawing.Size(58, 28)
        Me.cmbSSL.TabIndex = 3
        '
        'cmbSuk
        '
        Me.cmbSuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuk.FormattingEnabled = True
        Me.cmbSuk.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbSuk.Location = New System.Drawing.Point(292, 31)
        Me.cmbSuk.Name = "cmbSuk"
        Me.cmbSuk.Size = New System.Drawing.Size(58, 28)
        Me.cmbSuk.TabIndex = 4
        '
        'cmbPra
        '
        Me.cmbPra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPra.FormattingEnabled = True
        Me.cmbPra.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbPra.Location = New System.Drawing.Point(362, 31)
        Me.cmbPra.Name = "cmbPra"
        Me.cmbPra.Size = New System.Drawing.Size(58, 28)
        Me.cmbPra.TabIndex = 5
        '
        'cmbsPra
        '
        Me.cmbsPra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsPra.FormattingEnabled = True
        Me.cmbsPra.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbsPra.Location = New System.Drawing.Point(432, 31)
        Me.cmbsPra.Name = "cmbsPra"
        Me.cmbsPra.Size = New System.Drawing.Size(58, 28)
        Me.cmbsPra.TabIndex = 6
        '
        'cmbSSP
        '
        Me.cmbSSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSSP.FormattingEnabled = True
        Me.cmbSSP.Items.AddRange(New Object() {"Ke", "Ve", "Su", "Mo", "Ma", "Ra", "Ju", "Sa", "Me"})
        Me.cmbSSP.Location = New System.Drawing.Point(502, 31)
        Me.cmbSSP.Name = "cmbSSP"
        Me.cmbSSP.Size = New System.Drawing.Size(58, 28)
        Me.cmbSSP.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 283)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSSP)
        Me.Controls.Add(Me.cmbsPra)
        Me.Controls.Add(Me.cmbPra)
        Me.Controls.Add(Me.cmbSuk)
        Me.Controls.Add(Me.cmbSSL)
        Me.Controls.Add(Me.cmbSub)
        Me.Controls.Add(Me.cmbStl)
        Me.Controls.Add(Me.cmbSgn)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSgn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSub As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSSL As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSuk As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPra As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsPra As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSSP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
