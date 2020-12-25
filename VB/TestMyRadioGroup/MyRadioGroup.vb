Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports System.Runtime.CompilerServices



Namespace TestMyRadioGroup
	<ToolboxItem(True), DefaultEvent("SelectedIndexChanged"), Description("Supports the selection of one of several options.")>
	Public Class MyRadioGroup
		Inherits RadioGroup
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyRadioGroup.EDITORTypeName_Renamed
			End Get
		End Property



		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyRadioGroup
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyRadioGroup)
			End Get
		End Property



		Shared Sub New()
			RepositoryItemMyRadioGroup.RegisterMyRadioGroup()
		End Sub



		Public Sub New()
			MyBase.New()
		End Sub
	End Class
End Namespace

