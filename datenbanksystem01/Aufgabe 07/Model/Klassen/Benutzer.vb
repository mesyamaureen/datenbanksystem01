Imports System.Xml.Serialization


<System.Serializable()>
Public Class Benutzer


    Private mstrName As String
    Private mstrVorname As String
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mdatGebDat As Date
    Private muintBenutzerID As UInteger


    'Konstruktoren
    Sub New()
        Name = String.Empty
        Vorname = String.Empty
        Benutzername = String.Empty
        Passwort = String.Empty
        Geburtsdatum = Date.MinValue
        BenutzerID = Nothing
    End Sub


    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date, puintBenutzerID As UInteger)
        Benutzername = pstrBenutzername
        Passwort = pstrPasswort
        Name = pstrName
        Vorname = pstrVorname
        Geburtsdatum = pdatGebDat
        BenutzerID = puintBenutzerID
    End Sub

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
            mstrVorname = value
        End Set
    End Property

    Public Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
            mstrBenutzername = value
        End Set
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
            Return mdatGebDat
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

    Public Property BenutzerID As UInteger
        Get
            Return muintBenutzerID
        End Get
        Set(value As UInteger)
            muintBenutzerID = value
        End Set
    End Property

End Class
