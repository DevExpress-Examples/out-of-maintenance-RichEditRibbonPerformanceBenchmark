Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace RichEditRibbonPerformanceBench
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private sw As New Stopwatch()
        Public Sub New()
            sw.Start()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            sw.Stop()
            labelControl1.Text = "<b>Elapsed time:</b><br>" & sw.ElapsedMilliseconds.ToString() & " ms"
            File.AppendAllText(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName & "\Results.txt", sw.ElapsedMilliseconds.ToString() & Environment.NewLine)
        End Sub
    End Class
End Namespace
