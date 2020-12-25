Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils



Namespace TestMyRadioGroup
	Public Class MyRadioGroupViewInfo
		Inherits RadioGroupViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub


		Public Overrides Function GetToolTipInfo(ByVal point As Point) As ToolTipControlInfo
			Dim resInfo As ToolTipControlInfo = MyBase.GetToolTipInfo(point)

			Dim ri As RepositoryItemMyRadioGroup = TryCast(Item, RepositoryItemMyRadioGroup)
			If ri.OwnerEdit IsNot Nothing Then
				For itemIndex As Integer = 0 To Item.Items.Count - 1
					Dim rect As Rectangle = ri.OwnerEdit.GetItemRectangle(itemIndex)
					If rect.Contains(point) AndAlso ri.Items(itemIndex).ToolTip <> String.Empty Then
						resInfo = Nothing
						resInfo = New ToolTipControlInfo(itemIndex, ri.Items(itemIndex).ToolTip)
					End If
				Next itemIndex
			End If

			Return resInfo
		End Function
	End Class
End Namespace
