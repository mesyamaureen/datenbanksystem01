Imports System.Xml.Serialization

<System.Serializable()>
Public Class Kunde
    Inherits Benutzer


    'Attribute
    Private mstrKundenID As String
    Private mstrFirma As String
    Private mlstListeEigeneBuchungen As List(Of Buchung)

    'Konstruktoren

    Sub New()
        MyBase.New
        mstrFirma = String.Empty
        mlstListeEigeneBuchungen = New List(Of Buchung)
    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date, pstrFirma As String)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrName, pstrVorname, pdatGebDat)
        mstrFirma = pstrFirma
        ' TODO: create record In Database And Set intKundenID

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

    Public Property KundenID
        Get
            Return mstrKundenID
        End Get
        Set(value)
            mstrKundenID = value
        End Set
    End Property

    Public Property EigeneBuchungen As List(Of Buchung)
        Get
            Return mlstListeEigeneBuchungen
        End Get
        Set(value As List(Of Buchung))
            mlstListeEigeneBuchungen = value
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
