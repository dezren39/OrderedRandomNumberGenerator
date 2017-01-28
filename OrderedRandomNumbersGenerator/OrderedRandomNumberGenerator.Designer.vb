<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRandNumGen
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
        Me.lblAmountOfNumbers = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblNumThree = New System.Windows.Forms.Label()
        Me.lvwOutput = New System.Windows.Forms.ListView()
        Me.nmcAmountOfNumbers = New System.Windows.Forms.NumericUpDown()
        Me.nmcLowerLimit = New System.Windows.Forms.NumericUpDown()
        Me.nmcUpperLimit = New System.Windows.Forms.NumericUpDown()
        Me.lblGenerateNumbers = New System.Windows.Forms.Label()
        CType(Me.nmcAmountOfNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmcLowerLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmcUpperLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAmountOfNumbers
        '
        Me.lblAmountOfNumbers.AutoSize = True
        Me.lblAmountOfNumbers.Location = New System.Drawing.Point(30, 10)
        Me.lblAmountOfNumbers.Name = "lblAmountOfNumbers"
        Me.lblAmountOfNumbers.Size = New System.Drawing.Size(103, 13)
        Me.lblAmountOfNumbers.TabIndex = 0
        Me.lblAmountOfNumbers.Text = "Amount of Numbers:"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(154, 85)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(70, 33)
        Me.lblLowerLimit.Name = "lblLowerLimit"
        Me.lblLowerLimit.Size = New System.Drawing.Size(63, 13)
        Me.lblLowerLimit.TabIndex = 2
        Me.lblLowerLimit.Text = "Lower Limit:"
        '
        'lblUpperLimit
        '
        Me.lblUpperLimit.AutoSize = True
        Me.lblUpperLimit.Location = New System.Drawing.Point(70, 59)
        Me.lblUpperLimit.Name = "lblUpperLimit"
        Me.lblUpperLimit.Size = New System.Drawing.Size(63, 13)
        Me.lblUpperLimit.TabIndex = 3
        Me.lblUpperLimit.Text = "Upper Limit:"
        '
        'lblNumThree
        '
        Me.lblNumThree.AutoSize = True
        Me.lblNumThree.Location = New System.Drawing.Point(33, 138)
        Me.lblNumThree.Name = "lblNumThree"
        Me.lblNumThree.Size = New System.Drawing.Size(0, 13)
        Me.lblNumThree.TabIndex = 4
        '
        'lvwOutput
        '
        Me.lvwOutput.Location = New System.Drawing.Point(12, 113)
        Me.lvwOutput.Name = "lvwOutput"
        Me.lvwOutput.Size = New System.Drawing.Size(257, 446)
        Me.lvwOutput.TabIndex = 6
        Me.lvwOutput.UseCompatibleStateImageBehavior = False
        '
        'nmcAmountOfNumbers
        '
        Me.nmcAmountOfNumbers.Location = New System.Drawing.Point(139, 8)
        Me.nmcAmountOfNumbers.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nmcAmountOfNumbers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmcAmountOfNumbers.Name = "nmcAmountOfNumbers"
        Me.nmcAmountOfNumbers.Size = New System.Drawing.Size(90, 20)
        Me.nmcAmountOfNumbers.TabIndex = 7
        Me.nmcAmountOfNumbers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nmcLowerLimit
        '
        Me.nmcLowerLimit.Location = New System.Drawing.Point(139, 31)
        Me.nmcLowerLimit.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nmcLowerLimit.Name = "nmcLowerLimit"
        Me.nmcLowerLimit.Size = New System.Drawing.Size(90, 20)
        Me.nmcLowerLimit.TabIndex = 8
        Me.nmcLowerLimit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nmcUpperLimit
        '
        Me.nmcUpperLimit.Location = New System.Drawing.Point(139, 57)
        Me.nmcUpperLimit.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nmcUpperLimit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmcUpperLimit.Name = "nmcUpperLimit"
        Me.nmcUpperLimit.Size = New System.Drawing.Size(90, 20)
        Me.nmcUpperLimit.TabIndex = 9
        Me.nmcUpperLimit.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'lblGenerateNumbers
        '
        Me.lblGenerateNumbers.AutoSize = True
        Me.lblGenerateNumbers.Location = New System.Drawing.Point(34, 88)
        Me.lblGenerateNumbers.Name = "lblGenerateNumbers"
        Me.lblGenerateNumbers.Size = New System.Drawing.Size(99, 13)
        Me.lblGenerateNumbers.TabIndex = 10
        Me.lblGenerateNumbers.Text = "Generate Numbers:"
        '
        'FrmRandNumGen
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 571)
        Me.Controls.Add(Me.lblGenerateNumbers)
        Me.Controls.Add(Me.nmcUpperLimit)
        Me.Controls.Add(Me.nmcLowerLimit)
        Me.Controls.Add(Me.nmcAmountOfNumbers)
        Me.Controls.Add(Me.lvwOutput)
        Me.Controls.Add(Me.lblNumThree)
        Me.Controls.Add(Me.lblUpperLimit)
        Me.Controls.Add(Me.lblLowerLimit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblAmountOfNumbers)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 610)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 610)
        Me.Name = "FrmRandNumGen"
        Me.Text = "Random Number Generator"
        CType(Me.nmcAmountOfNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmcLowerLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmcUpperLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmountOfNumbers As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblNumThree As Label
    Friend WithEvents lvwOutput As ListView
    Friend WithEvents nmcAmountOfNumbers As NumericUpDown
    Friend WithEvents nmcLowerLimit As NumericUpDown
    Friend WithEvents nmcUpperLimit As NumericUpDown
    Friend WithEvents lblGenerateNumbers As Label
End Class
