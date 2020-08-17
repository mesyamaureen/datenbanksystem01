Public Class UserController

    'Funktionen

    Public Shared Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)
        Dim anzumeldenderBenutzer As Benutzer
        Dim result = New Dictionary(Of String, String) From {{"attempt", "failed"}, {"role", Nothing}}

        For Each mitarbeiter As Mitarbeiter In Logic.ListeMitarbeiter
            If strBenutzername.Equals(mitarbeiter.Benutzername) And strPasswort.Equals(mitarbeiter.Passwort) Then
                anzumeldenderBenutzer = mitarbeiter
                AngemeldeteBenutzer.Add(anzumeldenderBenutzer)
                result("attempt") = "successful"
                result("role") = "mitarbeiter"

            End If
        Next

        For Each kunde As Kunde In Logic.ListeKunden
            If strBenutzername.Equals(kunde.Benutzername) And strPasswort.Equals(kunde.Passwort) Then
                anzumeldenderBenutzer = kunde
                AngemeldeteBenutzer.Add(anzumeldenderBenutzer)
                result("attempt") = "successful"
                result("role") = "kunde"
            End If
        Next

        Return result

    End Function

    Private Shared Function getNextUserID() As UInteger
        Dim userID As UInteger = 0
        For Each mitarbeiter As Mitarbeiter In ListeMitarbeiter
            If mitarbeiter.BenutzerID > userID Then
                userID = mitarbeiter.BenutzerID
            End If
        Next
        For Each kunde As Kunde In ListeKunden
            If kunde.BenutzerID > userID Then
                userID = kunde.BenutzerID
            End If
        Next

        Return userID + 1
    End Function

    Public Shared Function createKunde(strBenutzername As String, strName As String, strVorname As String, strPasswort As String, datGebDat As Date, strFirma As String) As Kunde
        Return New Kunde(strBenutzername,
                         strPasswort,
                         strName,
                         strVorname,
                         datGebDat,
                         getNextUserID,
                         strFirma)
    End Function

    Public Shared Function changeKunde(uintBenutzerID As UInteger, strBenutzername As String, strPasswort As String, strVorname As String, strName As String, strFirma As String, datGebDat As Date) As Boolean
        For i = 0 To ListeKunden.Count - 1
            If ListeKunden(i).BenutzerID = uintBenutzerID Then
                Dim kunde As Kunde = ListeKunden(i)
                kunde.Benutzername = strBenutzername
                kunde.Passwort = strPasswort
                kunde.Vorname = strVorname
                kunde.Name = strName
                kunde.Firma = strFirma
                kunde.Geburtsdatum = datGebDat

                ListeKunden(i) = kunde
                BenutzerDAO.speichernKunde(ListeKunden)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    Public Shared Function deleteKunde(uintBenutzerID As UInteger) As Boolean
        For i = 0 To ListeKunden.Count - 1
            If ListeKunden(i).BenutzerID = uintBenutzerID Then
                ListeKunden.RemoveAt(i)
                BenutzerDAO.speichernKunde(ListeKunden)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function


    Public Shared Function createMitarbeiter(strBenutzername As String, strName As String, strVorname As String, strPasswort As String, datGebDat As Date) As Mitarbeiter
        Return New Mitarbeiter(strBenutzername,
                               strPasswort,
                               strName,
                               strVorname,
                               datGebDat,
                               getNextUserID)
    End Function

    Public Shared Function changeMitarbeiter(uintBenutzerID As UInteger, strBenutzername As String, strPasswort As String, strVorname As String, strName As String, datGebDat As Date) As Boolean
        For i = 0 To ListeMitarbeiter.Count - 1
            If ListeMitarbeiter(i).BenutzerID = uintBenutzerID Then
                Dim mitarbeiter As Mitarbeiter = ListeMitarbeiter(i)
                mitarbeiter.Benutzername = strBenutzername
                mitarbeiter.Passwort = strPasswort
                mitarbeiter.Vorname = strVorname
                mitarbeiter.Name = strName
                mitarbeiter.Geburtsdatum = datGebDat

                ListeMitarbeiter(i) = mitarbeiter
                BenutzerDAO.speichernMitarbeiter(ListeMitarbeiter)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    Public Shared Function deleteMitarbeiter(uintBenutzerID As UInteger) As Boolean
        For i = 0 To ListeMitarbeiter.Count - 1
            If ListeMitarbeiter(i).BenutzerID = uintBenutzerID Then
                ListeMitarbeiter.RemoveAt(i)
                BenutzerDAO.speichernMitarbeiter(ListeMitarbeiter)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

End Class