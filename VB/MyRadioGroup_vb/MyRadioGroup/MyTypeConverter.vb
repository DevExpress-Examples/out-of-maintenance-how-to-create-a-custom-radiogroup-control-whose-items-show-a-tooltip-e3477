Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization




Namespace DevExpress.MyControl
	Public Class MyRadioGroupItemTypeConverter
		Inherits ExpandableObjectConverter
		Protected Function GetInstanceDescriptor(ByVal value As Object) As InstanceDescriptor
			Dim item As MyRadioGroupItem = CType(value, MyRadioGroupItem)
			Dim ctor As ConstructorInfo = Nothing
			Dim parameters() As Object = Nothing
			If item.Value Is Nothing AndAlso item.Description = String.Empty AndAlso item.Enabled AndAlso item.ToolTip = String.Empty Then
				ctor = GetType(MyRadioGroupItem).GetConstructor(New Type() { })
				parameters = New Object() { }
			Else
				ctor = GetType(MyRadioGroupItem).GetConstructor(New Type() { GetType(Object), GetType(String), GetType(Boolean), GetType(String) })
				parameters = New Object() { item.Value, item.Description, item.Enabled, item.ToolTip }
			End If
			Return New InstanceDescriptor(ctor, parameters)
		End Function
	End Class
End Namespace

