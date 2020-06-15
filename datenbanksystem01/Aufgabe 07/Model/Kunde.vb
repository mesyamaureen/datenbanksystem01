Public Class Kunde
    Inherits Benutzer


    'Attribute
    Public mstrKundenID As String
    Public mstrFirma As String

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



End Class
