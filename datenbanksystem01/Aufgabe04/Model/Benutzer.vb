Public Class Benutzer

    'Properties
    Public Property strBenutzername As String
    Public Property strVorname As String
    Public Property strName As String
    Public Property strPasswort As String
    Public Property datGebDat As Date


    Sub New(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date)

        Me.strBenutzername = strBenutzername
        Me.strPasswort = strPasswort
        Me.strName = strName
        Me.strVorname = strVorname
        Me.datGebDat = datGebDat

        ' TODO: create record In Database And Set intKundenID

    End Sub

    Function getStrPasswort() As String

        Return strPasswort

    End Function

    Function getStrBenutzername()

        Return strBenutzername

    End Function

    Function setStrBenutzername(strBenutzername As String)

        Me.strBenutzername = strBenutzername

    End Function








End Class
