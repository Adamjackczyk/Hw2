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
        Me.PicPayroll = New System.Windows.Forms.PictureBox()
        Me.LblPayCalc = New System.Windows.Forms.Label()
        Me.LblPaycheck = New System.Windows.Forms.Label()
        Me.LblCalculation = New System.Windows.Forms.Label()
        Me.LblGrossPay = New System.Windows.Forms.Label()
        Me.TxtGrossPay = New System.Windows.Forms.TextBox()
        Me.BtnComputeTaxes = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblFica = New System.Windows.Forms.Label()
        Me.LblFICAScore = New System.Windows.Forms.Label()
        Me.LblFederalTax = New System.Windows.Forms.Label()
        Me.LblFTaxScore = New System.Windows.Forms.Label()
        Me.LblSTaxScore = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblNetPaycheckIncome = New System.Windows.Forms.Label()
        Me.LblNetPayShow = New System.Windows.Forms.Label()
        CType(Me.PicPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPayroll
        '
        Me.PicPayroll.Image = CType(resources.GetObject("PicPayroll.Image"), System.Drawing.Image)
        Me.PicPayroll.Location = New System.Drawing.Point(-8, -1)
        Me.PicPayroll.Name = "PicPayroll"
        Me.PicPayroll.Size = New System.Drawing.Size(318, 231)
        Me.PicPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPayroll.TabIndex = 0
        Me.PicPayroll.TabStop = False
        '
        'LblPayCalc
        '
        Me.LblPayCalc.AutoSize = True
        Me.LblPayCalc.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayCalc.Location = New System.Drawing.Point(336, 9)
        Me.LblPayCalc.Name = "LblPayCalc"
        Me.LblPayCalc.Size = New System.Drawing.Size(339, 44)
        Me.LblPayCalc.TabIndex = 1
        Me.LblPayCalc.Text = "Payroll Calculator"
        '
        'LblPaycheck
        '
        Me.LblPaycheck.AutoSize = True
        Me.LblPaycheck.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaycheck.Location = New System.Drawing.Point(431, 76)
        Me.LblPaycheck.Name = "LblPaycheck"
        Me.LblPaycheck.Size = New System.Drawing.Size(132, 31)
        Me.LblPaycheck.TabIndex = 2
        Me.LblPaycheck.Text = "Paycheck"
        '
        'LblCalculation
        '
        Me.LblCalculation.AutoSize = True
        Me.LblCalculation.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCalculation.Location = New System.Drawing.Point(427, 129)
        Me.LblCalculation.Name = "LblCalculation"
        Me.LblCalculation.Size = New System.Drawing.Size(155, 31)
        Me.LblCalculation.TabIndex = 3
        Me.LblCalculation.Text = "Calculation"
        '
        'LblGrossPay
        '
        Me.LblGrossPay.AutoSize = True
        Me.LblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrossPay.Location = New System.Drawing.Point(330, 208)
        Me.LblGrossPay.Name = "LblGrossPay"
        Me.LblGrossPay.Size = New System.Drawing.Size(182, 25)
        Me.LblGrossPay.TabIndex = 4
        Me.LblGrossPay.Text = "Enter Gross Pay: "
        '
        'TxtGrossPay
        '
        Me.TxtGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrossPay.Location = New System.Drawing.Point(532, 212)
        Me.TxtGrossPay.Name = "TxtGrossPay"
        Me.TxtGrossPay.Size = New System.Drawing.Size(100, 30)
        Me.TxtGrossPay.TabIndex = 5
        '
        'BtnComputeTaxes
        '
        Me.BtnComputeTaxes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnComputeTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComputeTaxes.ForeColor = System.Drawing.Color.White
        Me.BtnComputeTaxes.Location = New System.Drawing.Point(198, 264)
        Me.BtnComputeTaxes.Name = "BtnComputeTaxes"
        Me.BtnComputeTaxes.Size = New System.Drawing.Size(145, 37)
        Me.BtnComputeTaxes.TabIndex = 6
        Me.BtnComputeTaxes.Text = "Compute Taxes"
        Me.BtnComputeTaxes.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(396, 264)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(116, 37)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(568, 264)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 37)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblFica
        '
        Me.LblFica.AutoSize = True
        Me.LblFica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFica.Location = New System.Drawing.Point(213, 330)
        Me.LblFica.Name = "LblFica"
        Me.LblFica.Size = New System.Drawing.Size(62, 20)
        Me.LblFica.TabIndex = 9
        Me.LblFica.Text = "FICA: "
        '
        'LblFICAScore
        '
        Me.LblFICAScore.AutoSize = True
        Me.LblFICAScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFICAScore.Location = New System.Drawing.Point(271, 330)
        Me.LblFICAScore.Name = "LblFICAScore"
        Me.LblFICAScore.Size = New System.Drawing.Size(60, 20)
        Me.LblFICAScore.TabIndex = 10
        Me.LblFICAScore.Text = "7.65%"
        '
        'LblFederalTax
        '
        Me.LblFederalTax.AutoSize = True
        Me.LblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFederalTax.Location = New System.Drawing.Point(350, 330)
        Me.LblFederalTax.Name = "LblFederalTax"
        Me.LblFederalTax.Size = New System.Drawing.Size(114, 20)
        Me.LblFederalTax.TabIndex = 11
        Me.LblFederalTax.Text = "Federal Tax:"
        '
        'LblFTaxScore
        '
        Me.LblFTaxScore.AutoSize = True
        Me.LblFTaxScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFTaxScore.Location = New System.Drawing.Point(470, 330)
        Me.LblFTaxScore.Name = "LblFTaxScore"
        Me.LblFTaxScore.Size = New System.Drawing.Size(45, 20)
        Me.LblFTaxScore.TabIndex = 12
        Me.LblFTaxScore.Text = "22%"
        '
        'LblSTaxScore
        '
        Me.LblSTaxScore.AutoSize = True
        Me.LblSTaxScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSTaxScore.Location = New System.Drawing.Point(547, 334)
        Me.LblSTaxScore.Name = "LblSTaxScore"
        Me.LblSTaxScore.Size = New System.Drawing.Size(95, 20)
        Me.LblSTaxScore.TabIndex = 13
        Me.LblSTaxScore.Text = "State Tax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(648, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "4%"
        '
        'LblNetPaycheckIncome
        '
        Me.LblNetPaycheckIncome.AutoSize = True
        Me.LblNetPaycheckIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNetPaycheckIncome.Location = New System.Drawing.Point(269, 394)
        Me.LblNetPaycheckIncome.Name = "LblNetPaycheckIncome"
        Me.LblNetPaycheckIncome.Size = New System.Drawing.Size(234, 25)
        Me.LblNetPaycheckIncome.TabIndex = 15
        Me.LblNetPaycheckIncome.Text = "Net Paycheck Income: "
        '
        'LblNetPayShow
        '
        Me.LblNetPayShow.AutoSize = True
        Me.LblNetPayShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNetPayShow.Location = New System.Drawing.Point(563, 394)
        Me.LblNetPayShow.Name = "LblNetPayShow"
        Me.LblNetPayShow.Size = New System.Drawing.Size(36, 25)
        Me.LblNetPayShow.TabIndex = 16
        Me.LblNetPayShow.Text = "$0"
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnComputeTaxes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblNetPayShow)
        Me.Controls.Add(Me.LblNetPaycheckIncome)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblSTaxScore)
        Me.Controls.Add(Me.LblFTaxScore)
        Me.Controls.Add(Me.LblFederalTax)
        Me.Controls.Add(Me.LblFICAScore)
        Me.Controls.Add(Me.LblFica)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnComputeTaxes)
        Me.Controls.Add(Me.TxtGrossPay)
        Me.Controls.Add(Me.LblGrossPay)
        Me.Controls.Add(Me.LblCalculation)
        Me.Controls.Add(Me.LblPaycheck)
        Me.Controls.Add(Me.LblPayCalc)
        Me.Controls.Add(Me.PicPayroll)
        Me.Name = "Form1"
        Me.Text = "Payroll Every 2 Weeks"
        CType(Me.PicPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicPayroll As PictureBox
    Friend WithEvents LblPayCalc As Label
    Friend WithEvents LblPaycheck As Label
    Friend WithEvents LblCalculation As Label
    Friend WithEvents LblGrossPay As Label
    Friend WithEvents TxtGrossPay As TextBox
    Friend WithEvents BtnComputeTaxes As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblFica As Label
    Friend WithEvents LblFICAScore As Label
    Friend WithEvents LblFederalTax As Label
    Friend WithEvents LblFTaxScore As Label
    Friend WithEvents LblSTaxScore As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblNetPaycheckIncome As Label
    Friend WithEvents LblNetPayShow As Label
End Class
