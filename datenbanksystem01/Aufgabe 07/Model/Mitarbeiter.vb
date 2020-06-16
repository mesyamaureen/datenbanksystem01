Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    Public mstrMitarbeiterID As String

    'Konstruktor
    'Parameterloser Konstruktor 
    Sub New()
        MyBase.New
    End Sub




    'Konstruktor mit Parametern 
    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrName, pstrVorname, pdatGebDat)


        ' TODO: create record In Database And Set mstrMitarbeiterID

    End Sub


    'ruft nur fks auf

    'Get & Set
    Public ReadOnly Property MitarbeiterID
        Get
            Return mstrMitarbeiterID
        End Get
    End Property



    Function deleteMitarbeiter()
        'TODO delete object in database

        Finalize()
    End Function

End Class