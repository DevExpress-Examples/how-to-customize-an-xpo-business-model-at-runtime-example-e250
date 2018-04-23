Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace MyXPOClassLibrary

	Public Class PersistentObject1
		Inherits XPObject
		'public PersistentObject1()
		'    : base() {
		'    // This constructor is used when an object is loaded from a persistent storage.
		'    // Do not place any code here.
		'}

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
		End Sub
		Private _stringPropertyName As String
		Public Property StringPropertyName() As String
			Get
				Return _stringPropertyName
			End Get
			Set(ByVal value As String)
				SetPropertyValue("StringPropertyName", _stringPropertyName, value)
			End Set
		End Property
		Private _intPropertyName As Integer
		Public Property IntPropertyName() As Integer
			Get
				Return _intPropertyName
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("IntPropertyName", _intPropertyName, value)
			End Set
		End Property
	End Class
End Namespace