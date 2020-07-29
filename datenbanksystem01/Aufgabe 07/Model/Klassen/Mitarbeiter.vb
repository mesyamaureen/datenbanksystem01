Imports System.Xml.Serialization

<System.Serializable()>
Public Class Mitarbeiter
    Inherits Benutzer

    'Properties
    'Konstruktor
    'Parameterloser Konstruktor 
    Sub New()
        MyBase.New
    End Sub




    'Konstruktor mit Parametern 
    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date, puintBenutzerID As UInteger)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrName, pstrVorname, pdatGebDat, puintBenutzerID)

    End Sub


    'ruft nur fks auf

    'Keine Get & Sets weil erbt von Benutzer



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