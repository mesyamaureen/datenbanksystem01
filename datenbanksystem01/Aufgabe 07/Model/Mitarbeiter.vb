Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    Public Property strMitarbeiterID As Integer

    'Konstruktor
    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date)

        MyBase.New(strBenutzername, strPasswort, strName, strVorname, datGebDat)

        ' TODO: create record In Database And Set intMitarbeiterID

    End Sub


    'ruft nur fks auf

    'Get & Set
    Function getStrMitarbeiterID()
        Return strMitarbeiterID
    End Function

    Function deleteMitarbeiter()
        'TODO delete object in database

        Finalize()
    End Function

End Class