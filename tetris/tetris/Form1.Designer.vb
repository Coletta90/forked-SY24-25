<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        car = New PictureBox()
        Timer1 = New Timer(components)
        henny = New PictureBox()
        family1 = New PictureBox()
        family2 = New PictureBox()
        cop = New PictureBox()
        cop2 = New PictureBox()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        CType(henny, ComponentModel.ISupportInitialize).BeginInit()
        CType(family1, ComponentModel.ISupportInitialize).BeginInit()
        CType(family2, ComponentModel.ISupportInitialize).BeginInit()
        CType(cop, ComponentModel.ISupportInitialize).BeginInit()
        CType(cop2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' car
        ' 
        car.Image = CType(resources.GetObject("car.Image"), Image)
        car.Location = New Point(33, 33)
        car.Name = "car"
        car.Size = New Size(150, 102)
        car.SizeMode = PictureBoxSizeMode.StretchImage
        car.TabIndex = 0
        car.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' henny
        ' 
        henny.Image = CType(resources.GetObject("henny.Image"), Image)
        henny.Location = New Point(44, 261)
        henny.Name = "henny"
        henny.Size = New Size(93, 120)
        henny.SizeMode = PictureBoxSizeMode.StretchImage
        henny.TabIndex = 1
        henny.TabStop = False
        ' 
        ' family1
        ' 
        family1.Image = CType(resources.GetObject("family1.Image"), Image)
        family1.Location = New Point(330, 261)
        family1.Name = "family1"
        family1.Size = New Size(236, 120)
        family1.SizeMode = PictureBoxSizeMode.StretchImage
        family1.TabIndex = 2
        family1.TabStop = False
        ' 
        ' family2
        ' 
        family2.Image = CType(resources.GetObject("family2.Image"), Image)
        family2.Location = New Point(405, 15)
        family2.Name = "family2"
        family2.Size = New Size(140, 120)
        family2.SizeMode = PictureBoxSizeMode.StretchImage
        family2.TabIndex = 3
        family2.TabStop = False
        ' 
        ' cop
        ' 
        cop.Image = CType(resources.GetObject("cop.Image"), Image)
        cop.Location = New Point(1045, 17)
        cop.Name = "cop"
        cop.Size = New Size(108, 118)
        cop.SizeMode = PictureBoxSizeMode.StretchImage
        cop.TabIndex = 4
        cop.TabStop = False
        ' 
        ' cop2
        ' 
        cop2.Image = CType(resources.GetObject("cop2.Image"), Image)
        cop2.Location = New Point(931, 17)
        cop2.Name = "cop2"
        cop2.Size = New Size(108, 118)
        cop2.SizeMode = PictureBoxSizeMode.StretchImage
        cop2.TabIndex = 5
        cop2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1177, 661)
        Controls.Add(cop2)
        Controls.Add(cop)
        Controls.Add(family2)
        Controls.Add(family1)
        Controls.Add(henny)
        Controls.Add(car)
        Name = "Form1"
        Text = "Form1"
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        CType(henny, ComponentModel.ISupportInitialize).EndInit()
        CType(family1, ComponentModel.ISupportInitialize).EndInit()
        CType(family2, ComponentModel.ISupportInitialize).EndInit()
        CType(cop, ComponentModel.ISupportInitialize).EndInit()
        CType(cop2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents car As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents henny As PictureBox
    Friend WithEvents family1 As PictureBox
    Friend WithEvents family2 As PictureBox
    Friend WithEvents cop As PictureBox
    Friend WithEvents cop2 As PictureBox

End Class
