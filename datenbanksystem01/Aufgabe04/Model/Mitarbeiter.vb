Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    Public Property intMitarbeiterID As Integer

    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, strFirma As String, datGebDat As Date)

        Me.strBenutzername = strBenutzername
        Me.strPasswort = strPasswort
        Me.strName = strName
        Me.strVorname = strVorname
        Me.datGebDat = datGebDat
        ' TODO: create record In Database And Set intMitarbeiterID

    End Sub



    'ruft nur fks auf
    Function getStrBenutzername()

        Return strBenutzername

    End Function

    Function setStrBenutzername(strBenutzername As String)

        Me.strBenutzername = strBenutzername

    End Function

    Function getIntMitarbeiterID()
        Return intMitarbeiterID
    End Function

    Function deleteMitarbeiter()

    End Function



End Class

