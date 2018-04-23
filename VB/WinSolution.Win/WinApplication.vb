Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win

Namespace WinSolution.Win
	Partial Public Class WinSolutionWindowsFormsApplication
		Inherits WinApplication
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub WinSolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
	End Class
End Namespace
