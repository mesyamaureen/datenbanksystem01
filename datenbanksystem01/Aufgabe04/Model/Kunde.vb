Public Class Kunde
    Inherits Benutzer


    'Properties
    Public Property strFirma As String
    Public Property intKundenID As Integer




    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, strFirma As String, datGebDat As Date)

        Me.strBenutzername = strBenutzername
        Me.strPasswort = strPasswort
        Me.strName = strName
        Me.strVorname = strVorname
        Me.strFirma = strFirma
        Me.datGebDat = datGebDat
        ' TODO: create record In Database And Set intKundenID

    End Sub

    Function getStrBenutzername()

        Return strBenutzername

    End Function

    Function setStrBenutzername(strBenutzername As String)

        Me.strBenutzername = strBenutzername

    End Function

    Function getIntKundenID()
        Return intKundenID
    End Function

    Function deleteKunde()

    End Function

End Class
