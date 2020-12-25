Imports TestMyRadioGroup.TestMyRadioGroup

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim MyRadioGroupItem1 As MyRadioGroupItem = New MyRadioGroupItem
        Dim MyRadioGroupItem2 As MyRadioGroupItem = New MyRadioGroupItem
        Dim MyRadioGroupItem3 As MyRadioGroupItem = New MyRadioGroupItem
        Dim MyRadioGroupItem4 As MyRadioGroupItem = New MyRadioGroupItem
        Me.MyRadioGroup1 = New MyRadioGroup
        CType(Me.MyRadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyRadioGroup1
        '
        Me.MyRadioGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyRadioGroup1.Location = New System.Drawing.Point(12, 12)
        Me.MyRadioGroup1.Name = "MyRadioGroup1"
        MyRadioGroupItem1.Description = "Item 1"
        MyRadioGroupItem1.ToolTip = "This is tooltip for item 1"
        MyRadioGroupItem1.Value = Nothing
        MyRadioGroupItem2.Description = "Item 2"
        MyRadioGroupItem2.ToolTip = "This is tooltip for item 2"
        MyRadioGroupItem2.Value = Nothing
        MyRadioGroupItem3.Description = "Item 3"
        MyRadioGroupItem3.ToolTip = "This is tooltip for item 3"
        MyRadioGroupItem3.Value = Nothing
        MyRadioGroupItem4.Description = "Item 4"
        MyRadioGroupItem4.ToolTip = "This is tooltip for item 4"
        MyRadioGroupItem4.Value = Nothing
        Me.MyRadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {MyRadioGroupItem1, MyRadioGroupItem2, MyRadioGroupItem3, MyRadioGroupItem4})
        Me.MyRadioGroup1.Size = New System.Drawing.Size(260, 238)
        Me.MyRadioGroup1.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MyRadioGroup1)
        Me.Name = "FormMain"
        Me.Text = "Main form"
        CType(Me.MyRadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyRadioGroup1 As MyRadioGroup

End Class
