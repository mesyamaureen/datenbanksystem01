Public Class Kunde
    Inherits Benutzer


    'Properties
    Public Property strKundenID As String
    Public Property strFirma As String

    'Konstruktoren
    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date)

        MyBase.New(strBenutzername, strPasswort, strName, strVorname, datGebDat)

        ' TODO: create record In Database And Set intKundenID

    End Sub


    Function getStrKundenID()
        Return strKundenID
    End Function

End Class
