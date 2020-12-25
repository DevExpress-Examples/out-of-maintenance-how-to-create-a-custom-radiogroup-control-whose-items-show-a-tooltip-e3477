Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls




Namespace TestMyRadioGroup
	<TypeConverter(GetType(MyRadioGroupItemTypeConverter))>
	Public Class MyRadioGroupItem
		Inherits RadioGroupItem
		Private toolTip_Renamed As String


		<Browsable(True), Description("Gets or sets tooltip of the item.")>
		Public Property ToolTip() As String
			Get
				Return toolTip_Renamed
			End Get
			Set(ByVal value As String)
				toolTip_Renamed = value
				Me.ItemChanged()
			End Set
		End Property



		Public Sub New()
			Me.New(Nothing, String.Empty, True, String.Empty)
		End Sub



		Public Sub New(ByVal value As Object, <Localizable(True)> ByVal description As String)
			Me.New(value, description, True, String.Empty)
		End Sub



		Public Sub New(ByVal value As Object, <Localizable(True)> ByVal description As String, ByVal enabled As Boolean)
			Me.New(value, description, enabled, String.Empty)
		End Sub



		Public Sub New(ByVal value As Object, <Localizable(True)> ByVal description As String, ByVal enabled As Boolean, ByVal toolTip As String)
			MyBase.New(value, description, enabled)
			Me.toolTip_Renamed = toolTip
		End Sub



		Public Overrides Function Clone() As Object
			Return New MyRadioGroupItem(Value, Description, Enabled, ToolTip)
		End Function
	End Class
End Namespace
