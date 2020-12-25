Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls



Namespace TestMyRadioGroup
	<ListBindable(False)>
	Public Class MyRadioGroupItemCollection
		Inherits RadioGroupItemCollection
		Default Public Shadows Property Item(ByVal index As Integer) As MyRadioGroupItem
			Get
				Return TryCast(List(index), MyRadioGroupItem)
			End Get
			Set(ByVal value As MyRadioGroupItem)
				List(index) = value
			End Set
		End Property


		Public Sub New()
			MyBase.New()
		End Sub
	End Class
End Namespace
