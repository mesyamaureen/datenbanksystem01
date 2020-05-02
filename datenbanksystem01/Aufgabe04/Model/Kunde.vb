Public Class Kunde
    Inherits Benutzer


    'Properties
    Public Property intKundenID As Integer
    Public Property strFirma As String



    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date)

        MyBase.New(strBenutzername, strPasswort, strName, strVorname, datGebDat)

        ' TODO: create record In Database And Set intKundenID

    End Sub


    Function getIntKundenID()
        Return intKundenID
    End Function

    Function deleteKunde()

    End Function

End Class
