Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    Public Property intMitarbeiterID As Integer

    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String)

        MyBase.New(strBenutzername, strPasswort, strName, strVorname)

        ' TODO: create record In Database And Set intMitarbeiterID

    End Sub


    'ruft nur fks auf


    Function getIntMitarbeiterID()
        Return intMitarbeiterID
    End Function

    Function deleteMitarbeiter()
        'TODO delete object in database


        Finalize()
    End Function

End Class