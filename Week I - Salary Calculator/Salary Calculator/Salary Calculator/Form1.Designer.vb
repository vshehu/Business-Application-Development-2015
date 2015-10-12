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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblGrossSalary = New System.Windows.Forms.Label()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRetirement = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSicnkess = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTaxable = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGrossSalary
        '
        Me.lblGrossSalary.AutoSize = True
        Me.lblGrossSalary.Location = New System.Drawing.Point(13, 85)
        Me.lblGrossSalary.Name = "lblGrossSalary"
        Me.lblGrossSalary.Size = New System.Drawing.Size(64, 13)
        Me.lblGrossSalary.TabIndex = 0
        Me.lblGrossSalary.Text = "Gross salary"
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.Location = New System.Drawing.Point(154, 80)
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.Size = New System.Drawing.Size(175, 20)
        Me.txtGrossSalary.TabIndex = 1
        Me.txtGrossSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetSalary
        '
        Me.txtNetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetSalary.Location = New System.Drawing.Point(154, 106)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.ReadOnly = True
        Me.txtNetSalary.Size = New System.Drawing.Size(175, 20)
        Me.txtNetSalary.TabIndex = 3
        Me.txtNetSalary.TabStop = False
        Me.txtNetSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Net salary"
        '
        'txtHealth
        '
        Me.txtHealth.Location = New System.Drawing.Point(154, 158)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.ReadOnly = True
        Me.txtHealth.Size = New System.Drawing.Size(175, 20)
        Me.txtHealth.TabIndex = 7
        Me.txtHealth.TabStop = False
        Me.txtHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Health insurance (7.3 %)"
        '
        'txtRetirement
        '
        Me.txtRetirement.Location = New System.Drawing.Point(154, 132)
        Me.txtRetirement.Name = "txtRetirement"
        Me.txtRetirement.ReadOnly = True
        Me.txtRetirement.Size = New System.Drawing.Size(175, 20)
        Me.txtRetirement.TabIndex = 5
        Me.txtRetirement.TabStop = False
        Me.txtRetirement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Retirement (18 %)"
        '
        'txtSicnkess
        '
        Me.txtSicnkess.Location = New System.Drawing.Point(154, 210)
        Me.txtSicnkess.Name = "txtSicnkess"
        Me.txtSicnkess.ReadOnly = True
        Me.txtSicnkess.Size = New System.Drawing.Size(175, 20)
        Me.txtSicnkess.TabIndex = 11
        Me.txtSicnkess.TabStop = False
        Me.txtSicnkess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sickness fund (0.5 %)"
        '
        'txtEmployment
        '
        Me.txtEmployment.Location = New System.Drawing.Point(154, 184)
        Me.txtEmployment.Name = "txtEmployment"
        Me.txtEmployment.ReadOnly = True
        Me.txtEmployment.Size = New System.Drawing.Size(175, 20)
        Me.txtEmployment.TabIndex = 9
        Me.txtEmployment.TabStop = False
        Me.txtEmployment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Employment benefits (1.2%)"
        '
        'txtTaxable
        '
        Me.txtTaxable.Location = New System.Drawing.Point(154, 236)
        Me.txtTaxable.Name = "txtTaxable"
        Me.txtTaxable.ReadOnly = True
        Me.txtTaxable.Size = New System.Drawing.Size(175, 20)
        Me.txtTaxable.TabIndex = 13
        Me.txtTaxable.TabStop = False
        Me.txtTaxable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Taxable income"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(334, 80)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(334, 106)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Cl&ear "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtPersonal
        '
        Me.txtPersonal.Location = New System.Drawing.Point(154, 262)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.ReadOnly = True
        Me.txtPersonal.Size = New System.Drawing.Size(175, 20)
        Me.txtPersonal.TabIndex = 18
        Me.txtPersonal.TabStop = False
        Me.txtPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Personal tax (10 %)"
        '
        'pctLogo
        '
        Me.pctLogo.Image = CType(resources.GetObject("pctLogo.Image"), System.Drawing.Image)
        Me.pctLogo.Location = New System.Drawing.Point(12, 12)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(435, 62)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 19
        Me.pctLogo.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 289)
        Me.Controls.Add(Me.pctLogo)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTaxable)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSicnkess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmployment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHealth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRetirement)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNetSalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGrossSalary)
        Me.Controls.Add(Me.lblGrossSalary)
        Me.Name = "Form1"
        Me.Text = "Salary Calculator"
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGrossSalary As System.Windows.Forms.Label
    Friend WithEvents txtGrossSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtNetSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHealth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRetirement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSicnkess As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmployment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTaxable As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox

End Class
