Imports System.Xml.Serialization

<System.Serializable()>
Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    Private muintMitarbeiterID As UInteger

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
    Public Property MitarbeiterID As UInteger
        Get
            Return muintMitarbeiterID
        End Get
        Set(value As UInteger)
            muintMitarbeiterID = value
        End Set
    End Property



    Function deleteMitarbeiter()
        'TODO delete object in database

        Finalize()
    End Function

    Public Shared Function zeigenAlle() As List(Of Mitarbeiter)

        Dim lstMitarbeiter As List(Of Mitarbeiter)

        lstMitarbeiter = BenutzerDAO.ladenMitarbeiter()

        Return lstMitarbeiter

    End Function

    Public Shared Sub speichernAlle(pstrMitarbeiter As List(Of Mitarbeiter))

        BenutzerDAO.speichernMitarbeiter(pstrMitarbeiter)

    End Sub




End Class