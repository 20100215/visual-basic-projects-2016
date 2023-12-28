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
        Me.p1turna = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.p2turn3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.p2turn2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.p2turn1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.p1turn3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.p1turn2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.p1turn1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.p1turnb = New System.Windows.Forms.ComboBox()
        Me.p1turnc = New System.Windows.Forms.ComboBox()
        Me.Playername1 = New System.Windows.Forms.Label()
        Me.Playername2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.life1 = New System.Windows.Forms.Label()
        Me.percent1 = New System.Windows.Forms.Label()
        Me.percent2 = New System.Windows.Forms.Label()
        Me.life2 = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Button()
        Me.p2turnc = New System.Windows.Forms.ComboBox()
        Me.p2turnb = New System.Windows.Forms.ComboBox()
        Me.p2turna = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.p2special = New System.Windows.Forms.Label()
        Me.p1deduct = New System.Windows.Forms.Label()
        Me.p2deduct = New System.Windows.Forms.Label()
        Me.p1special = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'p1turna
        '
        Me.p1turna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p1turna.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1turna.FormattingEnabled = True
        Me.p1turna.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3"})
        Me.p1turna.Location = New System.Drawing.Point(27, 159)
        Me.p1turna.Name = "p1turna"
        Me.p1turna.Size = New System.Drawing.Size(144, 39)
        Me.p1turna.TabIndex = 0
        Me.p1turna.TabStop = False
        Me.p1turna.Tag = ""
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.p2turn3, Me.p2turn2, Me.p2turn1, Me.p1turn3, Me.p1turn2, Me.p1turn1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(644, 372)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape4.BorderWidth = 3
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 406
        Me.LineShape4.X2 = 249
        Me.LineShape4.Y1 = 158
        Me.LineShape4.Y2 = 159
        '
        'LineShape3
        '
        Me.LineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 407
        Me.LineShape3.X2 = 406
        Me.LineShape3.Y1 = 159
        Me.LineShape3.Y2 = 378
        '
        'LineShape2
        '
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 248
        Me.LineShape2.X2 = 247
        Me.LineShape2.Y1 = 157
        Me.LineShape2.Y2 = 376
        '
        'p2turn3
        '
        Me.p2turn3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p2turn3.Location = New System.Drawing.Point(422, 290)
        Me.p2turn3.Name = "p2turn3"
        Me.p2turn3.Size = New System.Drawing.Size(35, 35)
        '
        'p2turn2
        '
        Me.p2turn2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p2turn2.Location = New System.Drawing.Point(422, 224)
        Me.p2turn2.Name = "p2turn2"
        Me.p2turn2.Size = New System.Drawing.Size(35, 35)
        '
        'p2turn1
        '
        Me.p2turn1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p2turn1.Location = New System.Drawing.Point(422, 161)
        Me.p2turn1.Name = "p2turn1"
        Me.p2turn1.Size = New System.Drawing.Size(35, 35)
        '
        'p1turn3
        '
        Me.p1turn3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p1turn3.Location = New System.Drawing.Point(196, 288)
        Me.p1turn3.Name = "p1turn3"
        Me.p1turn3.Size = New System.Drawing.Size(35, 35)
        '
        'p1turn2
        '
        Me.p1turn2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p1turn2.Location = New System.Drawing.Point(196, 222)
        Me.p1turn2.Name = "p1turn2"
        Me.p1turn2.Size = New System.Drawing.Size(35, 35)
        '
        'p1turn1
        '
        Me.p1turn1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.p1turn1.Location = New System.Drawing.Point(196, 159)
        Me.p1turn1.Name = "p1turn1"
        Me.p1turn1.Size = New System.Drawing.Size(35, 35)
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 330
        Me.LineShape1.X2 = 329
        Me.LineShape1.Y1 = -2
        Me.LineShape1.Y2 = 155
        '
        'p1turnb
        '
        Me.p1turnb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p1turnb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1turnb.FormattingEnabled = True
        Me.p1turnb.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3"})
        Me.p1turnb.Location = New System.Drawing.Point(27, 224)
        Me.p1turnb.Name = "p1turnb"
        Me.p1turnb.Size = New System.Drawing.Size(144, 39)
        Me.p1turnb.TabIndex = 2
        '
        'p1turnc
        '
        Me.p1turnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p1turnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1turnc.FormattingEnabled = True
        Me.p1turnc.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3"})
        Me.p1turnc.Location = New System.Drawing.Point(27, 288)
        Me.p1turnc.Name = "p1turnc"
        Me.p1turnc.Size = New System.Drawing.Size(144, 39)
        Me.p1turnc.TabIndex = 3
        '
        'Playername1
        '
        Me.Playername1.AutoSize = True
        Me.Playername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playername1.Location = New System.Drawing.Point(31, 21)
        Me.Playername1.MinimumSize = New System.Drawing.Size(260, 0)
        Me.Playername1.Name = "Playername1"
        Me.Playername1.Size = New System.Drawing.Size(260, 39)
        Me.Playername1.TabIndex = 4
        Me.Playername1.Text = "Player 1"
        Me.Playername1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Playername2
        '
        Me.Playername2.AutoSize = True
        Me.Playername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playername2.Location = New System.Drawing.Point(366, 21)
        Me.Playername2.MinimumSize = New System.Drawing.Size(260, 0)
        Me.Playername2.Name = "Playername2"
        Me.Playername2.Size = New System.Drawing.Size(260, 39)
        Me.Playername2.TabIndex = 5
        Me.Playername2.Text = "Player 2"
        Me.Playername2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 47)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(260, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 47)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Next Turn"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 101)
        Me.Label1.MinimumSize = New System.Drawing.Size(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "HP:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 101)
        Me.Label2.MinimumSize = New System.Drawing.Size(50, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 39)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "HP:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'life1
        '
        Me.life1.AutoSize = True
        Me.life1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.life1.Location = New System.Drawing.Point(94, 101)
        Me.life1.MaximumSize = New System.Drawing.Size(120, 0)
        Me.life1.MinimumSize = New System.Drawing.Size(120, 0)
        Me.life1.Name = "life1"
        Me.life1.Size = New System.Drawing.Size(120, 39)
        Me.life1.TabIndex = 13
        Me.life1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'percent1
        '
        Me.percent1.AutoSize = True
        Me.percent1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percent1.Location = New System.Drawing.Point(214, 107)
        Me.percent1.MaximumSize = New System.Drawing.Size(105, 0)
        Me.percent1.MinimumSize = New System.Drawing.Size(105, 0)
        Me.percent1.Name = "percent1"
        Me.percent1.Size = New System.Drawing.Size(105, 31)
        Me.percent1.TabIndex = 14
        Me.percent1.Text = "(100%)"
        Me.percent1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'percent2
        '
        Me.percent2.AutoSize = True
        Me.percent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percent2.Location = New System.Drawing.Point(535, 107)
        Me.percent2.MaximumSize = New System.Drawing.Size(105, 0)
        Me.percent2.MinimumSize = New System.Drawing.Size(105, 0)
        Me.percent2.Name = "percent2"
        Me.percent2.Size = New System.Drawing.Size(105, 31)
        Me.percent2.TabIndex = 16
        Me.percent2.Text = "(100%)"
        Me.percent2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'life2
        '
        Me.life2.AutoSize = True
        Me.life2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.life2.Location = New System.Drawing.Point(415, 101)
        Me.life2.MaximumSize = New System.Drawing.Size(120, 0)
        Me.life2.MinimumSize = New System.Drawing.Size(120, 0)
        Me.life2.Name = "life2"
        Me.life2.Size = New System.Drawing.Size(120, 39)
        Me.life2.TabIndex = 15
        Me.life2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'help
        '
        Me.help.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help.Location = New System.Drawing.Point(315, 0)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(34, 34)
        Me.help.TabIndex = 17
        Me.help.Text = "?"
        Me.help.UseVisualStyleBackColor = True
        '
        'p2turnc
        '
        Me.p2turnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p2turnc.Enabled = False
        Me.p2turnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2turnc.FormattingEnabled = True
        Me.p2turnc.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3", "Special"})
        Me.p2turnc.Location = New System.Drawing.Point(482, 288)
        Me.p2turnc.Name = "p2turnc"
        Me.p2turnc.Size = New System.Drawing.Size(144, 39)
        Me.p2turnc.TabIndex = 20
        '
        'p2turnb
        '
        Me.p2turnb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p2turnb.Enabled = False
        Me.p2turnb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2turnb.FormattingEnabled = True
        Me.p2turnb.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3", "Special"})
        Me.p2turnb.Location = New System.Drawing.Point(482, 224)
        Me.p2turnb.Name = "p2turnb"
        Me.p2turnb.Size = New System.Drawing.Size(144, 39)
        Me.p2turnb.TabIndex = 19
        '
        'p2turna
        '
        Me.p2turna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p2turna.Enabled = False
        Me.p2turna.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2turna.FormattingEnabled = True
        Me.p2turna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.p2turna.Items.AddRange(New Object() {"---", "Attack 1", "Attack 2", "Attack 3", "Guard 1", "Guard 2", "Guard 3", "Break 1", "Break 2", "Break 3", "Special"})
        Me.p2turna.Location = New System.Drawing.Point(482, 159)
        Me.p2turna.Name = "p2turna"
        Me.p2turna.Size = New System.Drawing.Size(144, 39)
        Me.p2turna.TabIndex = 18
        Me.p2turna.TabStop = False
        Me.p2turna.Tag = ""
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(260, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 51)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Use Special"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'p2special
        '
        Me.p2special.AutoSize = True
        Me.p2special.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2special.Location = New System.Drawing.Point(524, 334)
        Me.p2special.MaximumSize = New System.Drawing.Size(105, 0)
        Me.p2special.MinimumSize = New System.Drawing.Size(105, 0)
        Me.p2special.Name = "p2special"
        Me.p2special.Size = New System.Drawing.Size(105, 31)
        Me.p2special.TabIndex = 23
        Me.p2special.Text = "SP 0/3"
        Me.p2special.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'p1deduct
        '
        Me.p1deduct.AutoSize = True
        Me.p1deduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1deduct.ForeColor = System.Drawing.Color.Red
        Me.p1deduct.Location = New System.Drawing.Point(64, 67)
        Me.p1deduct.MaximumSize = New System.Drawing.Size(150, 0)
        Me.p1deduct.MinimumSize = New System.Drawing.Size(150, 0)
        Me.p1deduct.Name = "p1deduct"
        Me.p1deduct.Size = New System.Drawing.Size(150, 33)
        Me.p1deduct.TabIndex = 24
        Me.p1deduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.p1deduct.Visible = False
        '
        'p2deduct
        '
        Me.p2deduct.AutoSize = True
        Me.p2deduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2deduct.ForeColor = System.Drawing.Color.Red
        Me.p2deduct.Location = New System.Drawing.Point(385, 67)
        Me.p2deduct.MaximumSize = New System.Drawing.Size(150, 0)
        Me.p2deduct.MinimumSize = New System.Drawing.Size(150, 0)
        Me.p2deduct.Name = "p2deduct"
        Me.p2deduct.Size = New System.Drawing.Size(150, 33)
        Me.p2deduct.TabIndex = 25
        Me.p2deduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.p2deduct.Visible = False
        '
        'p1special
        '
        Me.p1special.AutoSize = True
        Me.p1special.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1special.Location = New System.Drawing.Point(28, 334)
        Me.p1special.MaximumSize = New System.Drawing.Size(105, 0)
        Me.p1special.MinimumSize = New System.Drawing.Size(105, 0)
        Me.p1special.Name = "p1special"
        Me.p1special.Size = New System.Drawing.Size(105, 31)
        Me.p1special.TabIndex = 22
        Me.p1special.Text = "SP 0/3"
        Me.p1special.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(120, 334)
        Me.Label3.MaximumSize = New System.Drawing.Size(105, 0)
        Me.Label3.MinimumSize = New System.Drawing.Size(105, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "----------"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(432, 334)
        Me.Label4.MaximumSize = New System.Drawing.Size(105, 0)
        Me.Label4.MinimumSize = New System.Drawing.Size(105, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 31)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "----------"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(253, 170)
        Me.Label5.MaximumSize = New System.Drawing.Size(150, 0)
        Me.Label5.MinimumSize = New System.Drawing.Size(150, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 31)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Round 1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(20, 152)
        Me.Label6.MaximumSize = New System.Drawing.Size(170, 180)
        Me.Label6.MinimumSize = New System.Drawing.Size(170, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 180)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "SPECIAL USED!"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(462, 152)
        Me.Label7.MaximumSize = New System.Drawing.Size(170, 180)
        Me.Label7.MinimumSize = New System.Drawing.Size(170, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 180)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "SPECIAL USED!"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(253, 257)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.MaximumSize = New System.Drawing.Size(150, 110)
        Me.Label8.MinimumSize = New System.Drawing.Size(150, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 110)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "YOU WIN!"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 372)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.p2deduct)
        Me.Controls.Add(Me.p1deduct)
        Me.Controls.Add(Me.p2special)
        Me.Controls.Add(Me.p1special)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.p2turnc)
        Me.Controls.Add(Me.p2turnb)
        Me.Controls.Add(Me.p2turna)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.percent2)
        Me.Controls.Add(Me.life2)
        Me.Controls.Add(Me.percent1)
        Me.Controls.Add(Me.life1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Playername2)
        Me.Controls.Add(Me.Playername1)
        Me.Controls.Add(Me.p1turnc)
        Me.Controls.Add(Me.p1turnb)
        Me.Controls.Add(Me.p1turna)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 400)
        Me.MinimumSize = New System.Drawing.Size(650, 400)
        Me.Name = "Form1"
        Me.Text = "BATTLE!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents p1turnb As System.Windows.Forms.ComboBox
    Friend WithEvents p1turnc As System.Windows.Forms.ComboBox
    Friend WithEvents Playername1 As System.Windows.Forms.Label
    Friend WithEvents Playername2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents p2turn3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents p2turn2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents p2turn1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents p1turn3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents p1turn2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents p1turn1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents life1 As System.Windows.Forms.Label
    Friend WithEvents percent1 As System.Windows.Forms.Label
    Friend WithEvents percent2 As System.Windows.Forms.Label
    Friend WithEvents life2 As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.Button
    Friend WithEvents p1turna As System.Windows.Forms.ComboBox
    Friend WithEvents p2turnc As System.Windows.Forms.ComboBox
    Friend WithEvents p2turnb As System.Windows.Forms.ComboBox
    Friend WithEvents p2turna As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents p2special As System.Windows.Forms.Label
    Friend WithEvents p1deduct As System.Windows.Forms.Label
    Friend WithEvents p2deduct As System.Windows.Forms.Label
    Friend WithEvents p1special As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
