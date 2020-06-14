Public Class Kunde
    Inherits Benutzer


    'Properties
    Public Property mstrKundenID As String
    Public Property mstrFirma As String

    'Konstruktoren
    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrName As String, pstrVorname As String, pdatGebDat As Date, pstrFirma As String)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrName, pstrVorname, pdatGebDat)
        mstrFirma = pstrFirma
        ' TODO: create record In Database And Set intKundenID

    End Sub


    Function getStrKundenID()
        Return strKundenID
    End Function

End Class
