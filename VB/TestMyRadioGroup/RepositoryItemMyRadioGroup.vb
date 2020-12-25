Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls




Namespace TestMyRadioGroup
	<UserRepositoryItem("RegisterMyRadioGroup")>
	Public Class RepositoryItemMyRadioGroup
		Inherits RepositoryItemRadioGroup
		Friend Const EDITORTypeName_Renamed As String = "MyRadioGroup"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EDITORTypeName_Renamed
			End Get
		End Property



		<Browsable(False)>
		Public Shadows ReadOnly Property OwnerEdit() As MyRadioGroup
			Get
				Return TryCast(MyBase.OwnerEdit, MyRadioGroup)
			End Get
		End Property



		<Description("Gets the collection of items displayed by the current radio group editor."), Category(CategoryName.Data), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Editor("System.ComponentModel.Design.CollectionEditor, System.Design", GetType(System.Drawing.Design.UITypeEditor)), Localizable(True)>
		Public Shadows ReadOnly Property Items() As MyRadioGroupItemCollection
			Get
				Return TryCast(MyBase.Items, MyRadioGroupItemCollection)
			End Get
		End Property



		Shared Sub New()
			RegisterMyRadioGroup()
		End Sub



		Public Sub New()
			MyBase.New()
		End Sub



		Public Shared Sub RegisterMyRadioGroup()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EDITORTypeName_Renamed, GetType(MyRadioGroup), GetType(RepositoryItemMyRadioGroup), GetType(MyRadioGroupViewInfo), New RadioGroupPainter(), True, CType(Nothing, Image), GetType(DevExpress.Accessibility.ButtonEditAccessible)))
		End Sub


		Protected Overrides Function CreateItemCollection() As RadioGroupItemCollection
			Return New MyRadioGroupItemCollection()
		End Function
	End Class

End Namespace
