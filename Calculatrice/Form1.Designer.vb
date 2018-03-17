<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculatrice))
        Me.Ecran = New System.Windows.Forms.TextBox()
        Me.Bouton2 = New System.Windows.Forms.Button()
        Me.Bouton1 = New System.Windows.Forms.Button()
        Me.Bouton3 = New System.Windows.Forms.Button()
        Me.Diviser = New System.Windows.Forms.Button()
        Me.Bouton4 = New System.Windows.Forms.Button()
        Me.Bouton5 = New System.Windows.Forms.Button()
        Me.Bouton6 = New System.Windows.Forms.Button()
        Me.Multiplier = New System.Windows.Forms.Button()
        Me.Bouton7 = New System.Windows.Forms.Button()
        Me.Bouton8 = New System.Windows.Forms.Button()
        Me.Bouton9 = New System.Windows.Forms.Button()
        Me.Moins = New System.Windows.Forms.Button()
        Me.Bouton0 = New System.Windows.Forms.Button()
        Me.Point = New System.Windows.Forms.Button()
        Me.Egal = New System.Windows.Forms.Button()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Mem1 = New System.Windows.Forms.Button()
        Me.M1Receive = New System.Windows.Forms.Button()
        Me.M1Clear = New System.Windows.Forms.Button()
        Me.DelEcran = New System.Windows.Forms.Button()
        Me.Pi = New System.Windows.Forms.Button()
        Me.carré = New System.Windows.Forms.Button()
        Me.Racine = New System.Windows.Forms.Button()
        Me.Sinus = New System.Windows.Forms.Button()
        Me.Cosinus = New System.Windows.Forms.Button()
        Me.Ecran2 = New System.Windows.Forms.TextBox()
        Me.Inverse = New System.Windows.Forms.Button()
        Me.Puissance = New System.Windows.Forms.Button()
        Me.Tangeante = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ln = New System.Windows.Forms.Button()
        Me.Sin_inv = New System.Windows.Forms.Button()
        Me.Cos_inv = New System.Windows.Forms.Button()
        Me.Tan_inv = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Cube = New System.Windows.Forms.Button()
        Me.Mem2 = New System.Windows.Forms.Button()
        Me.Mem3 = New System.Windows.Forms.Button()
        Me.M2Receive = New System.Windows.Forms.Button()
        Me.M3Receive = New System.Windows.Forms.Button()
        Me.M2Clear = New System.Windows.Forms.Button()
        Me.M3Clear = New System.Windows.Forms.Button()
        Me.EcranM1 = New System.Windows.Forms.TextBox()
        Me.EcranM2 = New System.Windows.Forms.TextBox()
        Me.EcranM3 = New System.Windows.Forms.TextBox()
        Me.plusmoins = New System.Windows.Forms.Button()
        Me.puissance10 = New System.Windows.Forms.Button()
        Me.Pourcent = New System.Windows.Forms.Button()
        Me.OuvrePar = New System.Windows.Forms.Button()
        Me.FermePar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ecran
        '
        Me.Ecran.BackColor = System.Drawing.Color.Wheat
        Me.Ecran.Location = New System.Drawing.Point(15, 41)
        Me.Ecran.Name = "Ecran"
        Me.Ecran.Size = New System.Drawing.Size(351, 20)
        Me.Ecran.TabIndex = 0
        Me.Ecran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Bouton2
        '
        Me.Bouton2.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bouton2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton2.Location = New System.Drawing.Point(66, 83)
        Me.Bouton2.Name = "Bouton2"
        Me.Bouton2.Size = New System.Drawing.Size(45, 37)
        Me.Bouton2.TabIndex = 1
        Me.Bouton2.Text = "2"
        Me.Bouton2.UseVisualStyleBackColor = False
        '
        'Bouton1
        '
        Me.Bouton1.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bouton1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton1.Location = New System.Drawing.Point(15, 83)
        Me.Bouton1.Name = "Bouton1"
        Me.Bouton1.Size = New System.Drawing.Size(45, 37)
        Me.Bouton1.TabIndex = 2
        Me.Bouton1.Text = "1"
        Me.Bouton1.UseVisualStyleBackColor = False
        '
        'Bouton3
        '
        Me.Bouton3.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton3.Location = New System.Drawing.Point(117, 83)
        Me.Bouton3.Name = "Bouton3"
        Me.Bouton3.Size = New System.Drawing.Size(45, 37)
        Me.Bouton3.TabIndex = 3
        Me.Bouton3.Text = "3"
        Me.Bouton3.UseVisualStyleBackColor = False
        '
        'Diviser
        '
        Me.Diviser.BackColor = System.Drawing.Color.LightSalmon
        Me.Diviser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diviser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Diviser.Location = New System.Drawing.Point(168, 83)
        Me.Diviser.Name = "Diviser"
        Me.Diviser.Size = New System.Drawing.Size(45, 37)
        Me.Diviser.TabIndex = 4
        Me.Diviser.Text = "/"
        Me.Diviser.UseVisualStyleBackColor = False
        '
        'Bouton4
        '
        Me.Bouton4.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton4.Location = New System.Drawing.Point(15, 126)
        Me.Bouton4.Name = "Bouton4"
        Me.Bouton4.Size = New System.Drawing.Size(45, 37)
        Me.Bouton4.TabIndex = 5
        Me.Bouton4.Text = "4"
        Me.Bouton4.UseVisualStyleBackColor = False
        '
        'Bouton5
        '
        Me.Bouton5.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton5.Location = New System.Drawing.Point(66, 126)
        Me.Bouton5.Name = "Bouton5"
        Me.Bouton5.Size = New System.Drawing.Size(45, 37)
        Me.Bouton5.TabIndex = 6
        Me.Bouton5.Text = "5"
        Me.Bouton5.UseVisualStyleBackColor = False
        '
        'Bouton6
        '
        Me.Bouton6.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton6.Location = New System.Drawing.Point(117, 126)
        Me.Bouton6.Name = "Bouton6"
        Me.Bouton6.Size = New System.Drawing.Size(45, 37)
        Me.Bouton6.TabIndex = 7
        Me.Bouton6.Text = "6"
        Me.Bouton6.UseVisualStyleBackColor = False
        '
        'Multiplier
        '
        Me.Multiplier.BackColor = System.Drawing.Color.LightSalmon
        Me.Multiplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Multiplier.Location = New System.Drawing.Point(168, 126)
        Me.Multiplier.Name = "Multiplier"
        Me.Multiplier.Size = New System.Drawing.Size(45, 37)
        Me.Multiplier.TabIndex = 8
        Me.Multiplier.Text = "x"
        Me.Multiplier.UseVisualStyleBackColor = False
        '
        'Bouton7
        '
        Me.Bouton7.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton7.Location = New System.Drawing.Point(15, 169)
        Me.Bouton7.Name = "Bouton7"
        Me.Bouton7.Size = New System.Drawing.Size(45, 37)
        Me.Bouton7.TabIndex = 9
        Me.Bouton7.Text = "7"
        Me.Bouton7.UseVisualStyleBackColor = False
        '
        'Bouton8
        '
        Me.Bouton8.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton8.Location = New System.Drawing.Point(66, 169)
        Me.Bouton8.Name = "Bouton8"
        Me.Bouton8.Size = New System.Drawing.Size(45, 37)
        Me.Bouton8.TabIndex = 10
        Me.Bouton8.Text = "8"
        Me.Bouton8.UseVisualStyleBackColor = False
        '
        'Bouton9
        '
        Me.Bouton9.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton9.Location = New System.Drawing.Point(117, 169)
        Me.Bouton9.Name = "Bouton9"
        Me.Bouton9.Size = New System.Drawing.Size(45, 37)
        Me.Bouton9.TabIndex = 11
        Me.Bouton9.Text = "9"
        Me.Bouton9.UseVisualStyleBackColor = False
        '
        'Moins
        '
        Me.Moins.BackColor = System.Drawing.Color.LightSalmon
        Me.Moins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Moins.Location = New System.Drawing.Point(168, 169)
        Me.Moins.Name = "Moins"
        Me.Moins.Size = New System.Drawing.Size(45, 37)
        Me.Moins.TabIndex = 12
        Me.Moins.Text = "-"
        Me.Moins.UseVisualStyleBackColor = False
        '
        'Bouton0
        '
        Me.Bouton0.BackColor = System.Drawing.Color.BurlyWood
        Me.Bouton0.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Bouton0.Location = New System.Drawing.Point(15, 212)
        Me.Bouton0.Name = "Bouton0"
        Me.Bouton0.Size = New System.Drawing.Size(45, 37)
        Me.Bouton0.TabIndex = 13
        Me.Bouton0.Text = "0"
        Me.Bouton0.UseVisualStyleBackColor = False
        '
        'Point
        '
        Me.Point.BackColor = System.Drawing.Color.BurlyWood
        Me.Point.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Point.Location = New System.Drawing.Point(66, 212)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(45, 37)
        Me.Point.TabIndex = 14
        Me.Point.Text = ","
        Me.Point.UseVisualStyleBackColor = False
        '
        'Egal
        '
        Me.Egal.BackColor = System.Drawing.Color.Pink
        Me.Egal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egal.ForeColor = System.Drawing.Color.Red
        Me.Egal.Location = New System.Drawing.Point(117, 212)
        Me.Egal.Name = "Egal"
        Me.Egal.Size = New System.Drawing.Size(45, 37)
        Me.Egal.TabIndex = 15
        Me.Egal.Text = "="
        Me.Egal.UseVisualStyleBackColor = False
        '
        'Plus
        '
        Me.Plus.BackColor = System.Drawing.Color.LightSalmon
        Me.Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Plus.Location = New System.Drawing.Point(168, 212)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(45, 37)
        Me.Plus.TabIndex = 16
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = False
        '
        'Mem1
        '
        Me.Mem1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Mem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mem1.ForeColor = System.Drawing.Color.Black
        Me.Mem1.Location = New System.Drawing.Point(219, 83)
        Me.Mem1.Name = "Mem1"
        Me.Mem1.Size = New System.Drawing.Size(45, 22)
        Me.Mem1.TabIndex = 17
        Me.Mem1.Text = "M1"
        Me.Mem1.UseVisualStyleBackColor = False
        '
        'M1Receive
        '
        Me.M1Receive.BackColor = System.Drawing.Color.DarkKhaki
        Me.M1Receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1Receive.ForeColor = System.Drawing.Color.Black
        Me.M1Receive.Location = New System.Drawing.Point(270, 83)
        Me.M1Receive.Name = "M1Receive"
        Me.M1Receive.Size = New System.Drawing.Size(45, 22)
        Me.M1Receive.TabIndex = 18
        Me.M1Receive.Text = "M1R"
        Me.M1Receive.UseVisualStyleBackColor = False
        '
        'M1Clear
        '
        Me.M1Clear.BackColor = System.Drawing.Color.DarkKhaki
        Me.M1Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1Clear.ForeColor = System.Drawing.Color.Black
        Me.M1Clear.Location = New System.Drawing.Point(321, 83)
        Me.M1Clear.Name = "M1Clear"
        Me.M1Clear.Size = New System.Drawing.Size(44, 22)
        Me.M1Clear.TabIndex = 19
        Me.M1Clear.Text = "M1C"
        Me.M1Clear.UseVisualStyleBackColor = False
        '
        'DelEcran
        '
        Me.DelEcran.BackColor = System.Drawing.Color.LightYellow
        Me.DelEcran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelEcran.ForeColor = System.Drawing.Color.Black
        Me.DelEcran.Location = New System.Drawing.Point(270, 255)
        Me.DelEcran.Name = "DelEcran"
        Me.DelEcran.Size = New System.Drawing.Size(45, 37)
        Me.DelEcran.TabIndex = 20
        Me.DelEcran.Text = "Del"
        Me.DelEcran.UseVisualStyleBackColor = False
        '
        'Pi
        '
        Me.Pi.BackColor = System.Drawing.Color.LemonChiffon
        Me.Pi.Font = New System.Drawing.Font("Algerian", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pi.ForeColor = System.Drawing.Color.ForestGreen
        Me.Pi.Location = New System.Drawing.Point(219, 255)
        Me.Pi.Name = "Pi"
        Me.Pi.Size = New System.Drawing.Size(45, 37)
        Me.Pi.TabIndex = 21
        Me.Pi.Text = "∏"
        Me.Pi.UseVisualStyleBackColor = False
        '
        'carré
        '
        Me.carré.BackColor = System.Drawing.Color.LemonChiffon
        Me.carré.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carré.ForeColor = System.Drawing.Color.ForestGreen
        Me.carré.Location = New System.Drawing.Point(66, 298)
        Me.carré.Name = "carré"
        Me.carré.Size = New System.Drawing.Size(45, 37)
        Me.carré.TabIndex = 22
        Me.carré.Text = "x²"
        Me.carré.UseVisualStyleBackColor = False
        '
        'Racine
        '
        Me.Racine.BackColor = System.Drawing.Color.LemonChiffon
        Me.Racine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Racine.ForeColor = System.Drawing.Color.ForestGreen
        Me.Racine.Location = New System.Drawing.Point(15, 298)
        Me.Racine.Name = "Racine"
        Me.Racine.Size = New System.Drawing.Size(45, 37)
        Me.Racine.TabIndex = 23
        Me.Racine.Text = "√"
        Me.Racine.UseVisualStyleBackColor = False
        '
        'Sinus
        '
        Me.Sinus.BackColor = System.Drawing.Color.LemonChiffon
        Me.Sinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sinus.ForeColor = System.Drawing.Color.ForestGreen
        Me.Sinus.Location = New System.Drawing.Point(15, 341)
        Me.Sinus.Name = "Sinus"
        Me.Sinus.Size = New System.Drawing.Size(45, 37)
        Me.Sinus.TabIndex = 24
        Me.Sinus.Text = "sin"
        Me.Sinus.UseVisualStyleBackColor = False
        '
        'Cosinus
        '
        Me.Cosinus.BackColor = System.Drawing.Color.LemonChiffon
        Me.Cosinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cosinus.ForeColor = System.Drawing.Color.ForestGreen
        Me.Cosinus.Location = New System.Drawing.Point(66, 341)
        Me.Cosinus.Name = "Cosinus"
        Me.Cosinus.Size = New System.Drawing.Size(45, 37)
        Me.Cosinus.TabIndex = 25
        Me.Cosinus.Text = "cos"
        Me.Cosinus.UseVisualStyleBackColor = False
        '
        'Ecran2
        '
        Me.Ecran2.BackColor = System.Drawing.Color.Wheat
        Me.Ecran2.Location = New System.Drawing.Point(15, 24)
        Me.Ecran2.Name = "Ecran2"
        Me.Ecran2.Size = New System.Drawing.Size(351, 20)
        Me.Ecran2.TabIndex = 26
        Me.Ecran2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Inverse
        '
        Me.Inverse.BackColor = System.Drawing.Color.LemonChiffon
        Me.Inverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inverse.ForeColor = System.Drawing.Color.ForestGreen
        Me.Inverse.Location = New System.Drawing.Point(219, 298)
        Me.Inverse.Name = "Inverse"
        Me.Inverse.Size = New System.Drawing.Size(45, 37)
        Me.Inverse.TabIndex = 27
        Me.Inverse.Text = "1/x"
        Me.Inverse.UseVisualStyleBackColor = False
        '
        'Puissance
        '
        Me.Puissance.BackColor = System.Drawing.Color.LemonChiffon
        Me.Puissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puissance.ForeColor = System.Drawing.Color.ForestGreen
        Me.Puissance.Location = New System.Drawing.Point(168, 298)
        Me.Puissance.Name = "Puissance"
        Me.Puissance.Size = New System.Drawing.Size(45, 37)
        Me.Puissance.TabIndex = 28
        Me.Puissance.Text = "x^y"
        Me.Puissance.UseVisualStyleBackColor = False
        '
        'Tangeante
        '
        Me.Tangeante.BackColor = System.Drawing.Color.LemonChiffon
        Me.Tangeante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tangeante.ForeColor = System.Drawing.Color.ForestGreen
        Me.Tangeante.Location = New System.Drawing.Point(117, 341)
        Me.Tangeante.Name = "Tangeante"
        Me.Tangeante.Size = New System.Drawing.Size(45, 37)
        Me.Tangeante.TabIndex = 29
        Me.Tangeante.Text = "tan"
        Me.Tangeante.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button2.Location = New System.Drawing.Point(270, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 37)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "log"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ln
        '
        Me.ln.BackColor = System.Drawing.Color.LemonChiffon
        Me.ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ln.ForeColor = System.Drawing.Color.ForestGreen
        Me.ln.Location = New System.Drawing.Point(321, 298)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(45, 37)
        Me.ln.TabIndex = 31
        Me.ln.Text = "ln"
        Me.ln.UseVisualStyleBackColor = False
        '
        'Sin_inv
        '
        Me.Sin_inv.BackColor = System.Drawing.Color.LemonChiffon
        Me.Sin_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sin_inv.ForeColor = System.Drawing.Color.ForestGreen
        Me.Sin_inv.Location = New System.Drawing.Point(168, 341)
        Me.Sin_inv.Name = "Sin_inv"
        Me.Sin_inv.Size = New System.Drawing.Size(45, 37)
        Me.Sin_inv.TabIndex = 32
        Me.Sin_inv.Text = "Asin"
        Me.Sin_inv.UseVisualStyleBackColor = False
        '
        'Cos_inv
        '
        Me.Cos_inv.BackColor = System.Drawing.Color.LemonChiffon
        Me.Cos_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cos_inv.ForeColor = System.Drawing.Color.ForestGreen
        Me.Cos_inv.Location = New System.Drawing.Point(219, 341)
        Me.Cos_inv.Name = "Cos_inv"
        Me.Cos_inv.Size = New System.Drawing.Size(45, 37)
        Me.Cos_inv.TabIndex = 33
        Me.Cos_inv.Text = "Acos"
        Me.Cos_inv.UseVisualStyleBackColor = False
        '
        'Tan_inv
        '
        Me.Tan_inv.BackColor = System.Drawing.Color.LemonChiffon
        Me.Tan_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tan_inv.ForeColor = System.Drawing.Color.ForestGreen
        Me.Tan_inv.Location = New System.Drawing.Point(270, 341)
        Me.Tan_inv.Name = "Tan_inv"
        Me.Tan_inv.Size = New System.Drawing.Size(45, 37)
        Me.Tan_inv.TabIndex = 34
        Me.Tan_inv.Text = "Atan"
        Me.Tan_inv.UseVisualStyleBackColor = False
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.Color.LemonChiffon
        Me.Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour.ForeColor = System.Drawing.Color.ForestGreen
        Me.Retour.Location = New System.Drawing.Point(321, 255)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(45, 37)
        Me.Retour.TabIndex = 35
        Me.Retour.Text = "<--"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'Cube
        '
        Me.Cube.BackColor = System.Drawing.Color.LemonChiffon
        Me.Cube.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cube.ForeColor = System.Drawing.Color.ForestGreen
        Me.Cube.Location = New System.Drawing.Point(117, 298)
        Me.Cube.Name = "Cube"
        Me.Cube.Size = New System.Drawing.Size(45, 37)
        Me.Cube.TabIndex = 36
        Me.Cube.Text = "x^3"
        Me.Cube.UseVisualStyleBackColor = False
        '
        'Mem2
        '
        Me.Mem2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Mem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mem2.ForeColor = System.Drawing.Color.Black
        Me.Mem2.Location = New System.Drawing.Point(219, 141)
        Me.Mem2.Name = "Mem2"
        Me.Mem2.Size = New System.Drawing.Size(45, 22)
        Me.Mem2.TabIndex = 37
        Me.Mem2.Text = "M2"
        Me.Mem2.UseVisualStyleBackColor = False
        '
        'Mem3
        '
        Me.Mem3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Mem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mem3.ForeColor = System.Drawing.Color.Black
        Me.Mem3.Location = New System.Drawing.Point(219, 201)
        Me.Mem3.Name = "Mem3"
        Me.Mem3.Size = New System.Drawing.Size(45, 22)
        Me.Mem3.TabIndex = 38
        Me.Mem3.Text = "M3"
        Me.Mem3.UseVisualStyleBackColor = False
        '
        'M2Receive
        '
        Me.M2Receive.BackColor = System.Drawing.Color.DarkKhaki
        Me.M2Receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2Receive.ForeColor = System.Drawing.Color.Black
        Me.M2Receive.Location = New System.Drawing.Point(270, 141)
        Me.M2Receive.Name = "M2Receive"
        Me.M2Receive.Size = New System.Drawing.Size(45, 22)
        Me.M2Receive.TabIndex = 39
        Me.M2Receive.Text = "M2R"
        Me.M2Receive.UseVisualStyleBackColor = False
        '
        'M3Receive
        '
        Me.M3Receive.BackColor = System.Drawing.Color.DarkKhaki
        Me.M3Receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M3Receive.ForeColor = System.Drawing.Color.Black
        Me.M3Receive.Location = New System.Drawing.Point(270, 201)
        Me.M3Receive.Name = "M3Receive"
        Me.M3Receive.Size = New System.Drawing.Size(45, 22)
        Me.M3Receive.TabIndex = 40
        Me.M3Receive.Text = "M3R"
        Me.M3Receive.UseVisualStyleBackColor = False
        '
        'M2Clear
        '
        Me.M2Clear.BackColor = System.Drawing.Color.DarkKhaki
        Me.M2Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2Clear.ForeColor = System.Drawing.Color.Black
        Me.M2Clear.Location = New System.Drawing.Point(321, 141)
        Me.M2Clear.Name = "M2Clear"
        Me.M2Clear.Size = New System.Drawing.Size(44, 22)
        Me.M2Clear.TabIndex = 41
        Me.M2Clear.Text = "M2C"
        Me.M2Clear.UseVisualStyleBackColor = False
        '
        'M3Clear
        '
        Me.M3Clear.BackColor = System.Drawing.Color.DarkKhaki
        Me.M3Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M3Clear.ForeColor = System.Drawing.Color.Black
        Me.M3Clear.Location = New System.Drawing.Point(321, 201)
        Me.M3Clear.Name = "M3Clear"
        Me.M3Clear.Size = New System.Drawing.Size(44, 22)
        Me.M3Clear.TabIndex = 42
        Me.M3Clear.Text = "M3C"
        Me.M3Clear.UseVisualStyleBackColor = False
        '
        'EcranM1
        '
        Me.EcranM1.BackColor = System.Drawing.Color.DarkKhaki
        Me.EcranM1.ForeColor = System.Drawing.Color.Red
        Me.EcranM1.Location = New System.Drawing.Point(219, 111)
        Me.EcranM1.Name = "EcranM1"
        Me.EcranM1.Size = New System.Drawing.Size(146, 20)
        Me.EcranM1.TabIndex = 43
        Me.EcranM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EcranM2
        '
        Me.EcranM2.BackColor = System.Drawing.Color.DarkKhaki
        Me.EcranM2.ForeColor = System.Drawing.Color.Red
        Me.EcranM2.Location = New System.Drawing.Point(219, 169)
        Me.EcranM2.Name = "EcranM2"
        Me.EcranM2.Size = New System.Drawing.Size(146, 20)
        Me.EcranM2.TabIndex = 44
        Me.EcranM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EcranM3
        '
        Me.EcranM3.BackColor = System.Drawing.Color.DarkKhaki
        Me.EcranM3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EcranM3.ForeColor = System.Drawing.Color.Red
        Me.EcranM3.Location = New System.Drawing.Point(219, 229)
        Me.EcranM3.Name = "EcranM3"
        Me.EcranM3.Size = New System.Drawing.Size(146, 20)
        Me.EcranM3.TabIndex = 45
        Me.EcranM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'plusmoins
        '
        Me.plusmoins.BackColor = System.Drawing.Color.LightYellow
        Me.plusmoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusmoins.ForeColor = System.Drawing.Color.ForestGreen
        Me.plusmoins.Location = New System.Drawing.Point(117, 255)
        Me.plusmoins.Name = "plusmoins"
        Me.plusmoins.Size = New System.Drawing.Size(45, 37)
        Me.plusmoins.TabIndex = 46
        Me.plusmoins.Text = "+/-"
        Me.plusmoins.UseVisualStyleBackColor = False
        '
        'puissance10
        '
        Me.puissance10.BackColor = System.Drawing.Color.LemonChiffon
        Me.puissance10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puissance10.ForeColor = System.Drawing.Color.ForestGreen
        Me.puissance10.Location = New System.Drawing.Point(321, 341)
        Me.puissance10.Name = "puissance10"
        Me.puissance10.Size = New System.Drawing.Size(45, 37)
        Me.puissance10.TabIndex = 47
        Me.puissance10.Text = "e"
        Me.puissance10.UseVisualStyleBackColor = False
        '
        'Pourcent
        '
        Me.Pourcent.BackColor = System.Drawing.Color.LightYellow
        Me.Pourcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pourcent.ForeColor = System.Drawing.Color.ForestGreen
        Me.Pourcent.Location = New System.Drawing.Point(168, 255)
        Me.Pourcent.Name = "Pourcent"
        Me.Pourcent.Size = New System.Drawing.Size(45, 37)
        Me.Pourcent.TabIndex = 48
        Me.Pourcent.Text = "%"
        Me.Pourcent.UseVisualStyleBackColor = False
        '
        'OuvrePar
        '
        Me.OuvrePar.BackColor = System.Drawing.Color.LightYellow
        Me.OuvrePar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OuvrePar.ForeColor = System.Drawing.Color.ForestGreen
        Me.OuvrePar.Location = New System.Drawing.Point(15, 255)
        Me.OuvrePar.Name = "OuvrePar"
        Me.OuvrePar.Size = New System.Drawing.Size(45, 37)
        Me.OuvrePar.TabIndex = 49
        Me.OuvrePar.Text = "("
        Me.OuvrePar.UseVisualStyleBackColor = False
        '
        'FermePar
        '
        Me.FermePar.BackColor = System.Drawing.Color.LightYellow
        Me.FermePar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FermePar.ForeColor = System.Drawing.Color.ForestGreen
        Me.FermePar.Location = New System.Drawing.Point(66, 255)
        Me.FermePar.Name = "FermePar"
        Me.FermePar.Size = New System.Drawing.Size(45, 37)
        Me.FermePar.TabIndex = 50
        Me.FermePar.Text = ")"
        Me.FermePar.UseVisualStyleBackColor = False
        '
        'Calculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(377, 395)
        Me.Controls.Add(Me.FermePar)
        Me.Controls.Add(Me.OuvrePar)
        Me.Controls.Add(Me.Pourcent)
        Me.Controls.Add(Me.puissance10)
        Me.Controls.Add(Me.plusmoins)
        Me.Controls.Add(Me.EcranM3)
        Me.Controls.Add(Me.EcranM2)
        Me.Controls.Add(Me.EcranM1)
        Me.Controls.Add(Me.M3Clear)
        Me.Controls.Add(Me.M2Clear)
        Me.Controls.Add(Me.M3Receive)
        Me.Controls.Add(Me.M2Receive)
        Me.Controls.Add(Me.Mem3)
        Me.Controls.Add(Me.Mem2)
        Me.Controls.Add(Me.Cube)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Tan_inv)
        Me.Controls.Add(Me.Cos_inv)
        Me.Controls.Add(Me.Sin_inv)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Tangeante)
        Me.Controls.Add(Me.Puissance)
        Me.Controls.Add(Me.Inverse)
        Me.Controls.Add(Me.Ecran2)
        Me.Controls.Add(Me.Cosinus)
        Me.Controls.Add(Me.Sinus)
        Me.Controls.Add(Me.Racine)
        Me.Controls.Add(Me.carré)
        Me.Controls.Add(Me.Pi)
        Me.Controls.Add(Me.DelEcran)
        Me.Controls.Add(Me.M1Clear)
        Me.Controls.Add(Me.M1Receive)
        Me.Controls.Add(Me.Mem1)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Egal)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.Bouton0)
        Me.Controls.Add(Me.Moins)
        Me.Controls.Add(Me.Bouton9)
        Me.Controls.Add(Me.Bouton8)
        Me.Controls.Add(Me.Bouton7)
        Me.Controls.Add(Me.Multiplier)
        Me.Controls.Add(Me.Bouton6)
        Me.Controls.Add(Me.Bouton5)
        Me.Controls.Add(Me.Bouton4)
        Me.Controls.Add(Me.Diviser)
        Me.Controls.Add(Me.Bouton3)
        Me.Controls.Add(Me.Bouton1)
        Me.Controls.Add(Me.Bouton2)
        Me.Controls.Add(Me.Ecran)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Calculatrice"
        Me.Text = "Calculatrice by Laurent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ecran As System.Windows.Forms.TextBox
    Friend WithEvents Bouton2 As System.Windows.Forms.Button
    Friend WithEvents Bouton1 As System.Windows.Forms.Button
    Friend WithEvents Bouton3 As System.Windows.Forms.Button
    Friend WithEvents Diviser As System.Windows.Forms.Button
    Friend WithEvents Bouton4 As System.Windows.Forms.Button
    Friend WithEvents Bouton5 As System.Windows.Forms.Button
    Friend WithEvents Bouton6 As System.Windows.Forms.Button
    Friend WithEvents Multiplier As System.Windows.Forms.Button
    Friend WithEvents Bouton7 As System.Windows.Forms.Button
    Friend WithEvents Bouton8 As System.Windows.Forms.Button
    Friend WithEvents Bouton9 As System.Windows.Forms.Button
    Friend WithEvents Moins As System.Windows.Forms.Button
    Friend WithEvents Bouton0 As System.Windows.Forms.Button
    Friend WithEvents Point As System.Windows.Forms.Button
    Friend WithEvents Egal As System.Windows.Forms.Button
    Friend WithEvents Plus As System.Windows.Forms.Button
    Friend WithEvents Mem1 As System.Windows.Forms.Button
    Friend WithEvents M1Receive As System.Windows.Forms.Button
    Friend WithEvents M1Clear As System.Windows.Forms.Button
    Friend WithEvents DelEcran As System.Windows.Forms.Button
    Friend WithEvents Pi As System.Windows.Forms.Button
    Friend WithEvents carré As System.Windows.Forms.Button
    Friend WithEvents Racine As System.Windows.Forms.Button
    Friend WithEvents Sinus As System.Windows.Forms.Button
    Friend WithEvents Cosinus As System.Windows.Forms.Button
    Friend WithEvents Ecran2 As System.Windows.Forms.TextBox
    Friend WithEvents Inverse As System.Windows.Forms.Button
    Friend WithEvents Puissance As System.Windows.Forms.Button
    Friend WithEvents Tangeante As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ln As System.Windows.Forms.Button
    Friend WithEvents Sin_inv As System.Windows.Forms.Button
    Friend WithEvents Cos_inv As System.Windows.Forms.Button
    Friend WithEvents Tan_inv As System.Windows.Forms.Button
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents Cube As System.Windows.Forms.Button
    Friend WithEvents Mem2 As System.Windows.Forms.Button
    Friend WithEvents Mem3 As System.Windows.Forms.Button
    Friend WithEvents M2Receive As System.Windows.Forms.Button
    Friend WithEvents M3Receive As System.Windows.Forms.Button
    Friend WithEvents M2Clear As System.Windows.Forms.Button
    Friend WithEvents M3Clear As System.Windows.Forms.Button
    Friend WithEvents EcranM1 As System.Windows.Forms.TextBox
    Friend WithEvents EcranM2 As System.Windows.Forms.TextBox
    Friend WithEvents EcranM3 As System.Windows.Forms.TextBox
    Friend WithEvents plusmoins As System.Windows.Forms.Button
    Friend WithEvents puissance10 As System.Windows.Forms.Button
    Friend WithEvents Pourcent As System.Windows.Forms.Button
    Friend WithEvents OuvrePar As System.Windows.Forms.Button
    Friend WithEvents FermePar As System.Windows.Forms.Button

End Class
