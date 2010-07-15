Imports CommonSnappableTypes
Imports System.Windows.Forms

<CompanyInfo(Name:="Not So Simpleton Design", Url:="www.notsosimpleton.com")> _
Public Class VBNetSnapIn
    Implements IAppFunctionality

    Public Sub DoIt() Implements CommonSnappableTypes.IAppFunctionality.DoIt
        MessageBox.Show("Incredible, you have managed to use a retarted code standard to create a snap in.")
    End Sub
End Class
