Public Class Kunde
    Inherits Benutzer


    'Attribute
    Public mstrKundenID As String
    Public mstrFirma As String
    Public mlstListeEigeneBuchungen As List(Of Buchung)

    'Konstruktoren
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

    Public ReadOnly Property KundenID
        Get
            Return mstrKundenID
        End Get
    End Property

    Public Property EigeneBuchungen As List(Of Buchung)
        Get
            Return mlstListeEigeneBuchungen
        End Get
        Set(value As List(Of Buchung))
            mlstListeEigeneBuchungen = value
        End Set
    End Property

End Class
