Imports System.Diagnostics

Public Class Form1
	Sub New()
		Dim sw As New Stopwatch

		sw.Start()
		InitializeComponent()
		sw.Stop()

		MsgBox("InitializeComponent() => " & sw.ElapsedMilliseconds & "ms")
	End Sub

	Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

	End Sub
End Class
