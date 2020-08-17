Imports System.Xml.Serialization

<System.Serializable()>
Public Class Kunde
    Inherits Benutzer


    'Attribute
    Private mstrFirma As String

    'Konstruktoren
    Sub New()
        MyBase.New
        Firma = String.Empty
    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date, puintBenutzerID As UInteger, pstrFirma As String)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrName, pstrVorname, pdatGebDat, puintBenutzerID)
        Firma = pstrFirma

    End Sub

    ' Properties 
    Public Property Firma
        Get
            Return mstrFirma
        End Get
        Set(value)
            mstrFirma = value
        End Set
    End Property


    Public Shared Function zeigenAlle() As List(Of Kunde)

        Dim lstKunde As List(Of Kunde)
        lstKunde = BenutzerDAO.ladenKunden()
        Return lstKunde

    End Function

    Public Shared Sub speichernAlle(pstrKunde As List(Of Kunde))

        BenutzerDAO.speichernKunde(pstrKunde)

    End Sub

End Class
