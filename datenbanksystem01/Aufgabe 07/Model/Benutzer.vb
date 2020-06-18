Imports System.Xml.Serialization

<System.Serializable()>



Public Class Benutzer

    'Properties

    Private mstrName As String
    Private mstrVorname As String
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mdatGebDat As Date

    'Konstruktoren
    Sub New()
        mstrName = String.Empty
        mstrVorname = String.Empty
        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mdatGebDat = Date.MinValue
    End Sub


    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date)

        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrName = pstrName
        mstrVorname = pstrVorname
        mdatGebDat = pdatGebDat

        ' TODO: create record In Database And Set intKundenID

    End Sub

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public ReadOnly Property Vorname As String
        Get
            Return mstrVorname
        End Get
    End Property

    Public ReadOnly Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
    End Property

    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)
            mstrPasswort = value
        End Set
    End Property

    Public Property Geburtsdatum As Date
        Get
            Return mstrPasswort
        End Get
        Set(value As Date)
            ' Prüfen, ob Geburtsdatum in Vergangenheit
            If value < Now() Then
                mdatGebDat = value
            Else
                ' Fehler!
                Debug.Print("Fehler: Geburtsdatum muss in der Vergangenheit liegen.")
            End If
        End Set
    End Property







End Class
