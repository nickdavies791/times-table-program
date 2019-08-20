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
        Me.txtNumOne = New System.Windows.Forms.TextBox()
        Me.txtNumTwo = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbxList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMultiplier = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNumOne
        '
        Me.txtNumOne.Location = New System.Drawing.Point(84, 23)
        Me.txtNumOne.Name = "txtNumOne"
        Me.txtNumOne.Size = New System.Drawing.Size(101, 20)
        Me.txtNumOne.TabIndex = 0
        '
        'txtNumTwo
        '
        Me.txtNumTwo.Location = New System.Drawing.Point(84, 49)
        Me.txtNumTwo.Name = "txtNumTwo"
        Me.txtNumTwo.Size = New System.Drawing.Size(101, 20)
        Me.txtNumTwo.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(12, 105)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(173, 32)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End"
        '
        'lbxList
        '
        Me.lbxList.FormattingEnabled = True
        Me.lbxList.Location = New System.Drawing.Point(12, 143)
        Me.lbxList.Name = "lbxList"
        Me.lbxList.Size = New System.Drawing.Size(173, 95)
        Me.lbxList.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Multiplier"
        '
        'txtMultiplier
        '
        Me.txtMultiplier.Location = New System.Drawing.Point(84, 76)
        Me.txtMultiplier.Name = "txtMultiplier"
        Me.txtMultiplier.Size = New System.Drawing.Size(101, 20)
        Me.txtMultiplier.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 250)
        Me.Controls.Add(Me.txtMultiplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbxList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtNumTwo)
        Me.Controls.Add(Me.txtNumOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumOne As TextBox
    Friend WithEvents txtNumTwo As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbxList As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMultiplier As TextBox
End Class
