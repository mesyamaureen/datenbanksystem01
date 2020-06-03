Module Logic

    'Properties

    Public AktuellAngemeldeterBenutzer As Benutzer
    Private Property lstKunde As List(Of Kunde)
    Private Property lstMitarbeiter As List(Of Mitarbeiter)
    Private Property lstBuchung As List(Of Buchung)
    Private Property lstKurse As List(Of Kurs)
    Private Property lstWeiterbildungen As List(Of Weiterbildung)
    Private Property userController As UserController
    Private Property weiterbildungscontroller As WeiterbildungsController
    Private Property bookingController As BookingController

    'init funktion

    'funktion initialise
    Public Function initialise()
        'TODO initialise lists from database
        lstMitarbeiter = New List(Of Mitarbeiter) From
        {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#)}
        lstKunde = New List(Of Kunde) From
        {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#)}

        userController = New UserController(lstMitarbeiter, lstKunde)
        weiterbildungscontroller = New WeiterbildungsController(lstKurse, lstWeiterbildungen)
        bookingController = New BookingController(lstBuchung)

    End Function
    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Return userController.logIn(strBenutzername, strPasswort)

    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstKunde.Add(kunde)
        Dim strKundenID As String = kunde.getStrKundenID()
        Return strKundenID

    End Function

    Public Function viewKunde(strKundenID) As Array

        Return userController.viewKunde(strKundenID)

    End Function

    Public Function changeKunde(strKundenId As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeKunde(strKundenId, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteKunde(strKundenID As Integer) As Boolean

        Return userController.deleteKunde(strKundenID)

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstMitarbeiter.Add(mitarbeiter)

        Dim strMitarbeiterID As String = mitarbeiter.getStrMitarbeiterID()
        Return strMitarbeiterID

    End Function

    Public Function viewMitarbeiter(strMitarbeiterID As String) As Array

        Return userController.viewMitarbeiter(strMitarbeiterID)

    End Function

    Public Function changeMitarbeiter(strMitarbeiterID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeMitarbeiter(strMitarbeiterID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteMitarbeiter(strMitarbeiterID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return userController.deleteMitarbeiter(strMitarbeiterID)

    End Function

    'TODO Datenbank erstellen (fill with records)

    'WeiterbildungsController
    Public Function createKurs(strOrt As String, datZeitpunkt As Date, bolavailable As Boolean, decPreis As Decimal) As String

        Return weiterbildungscontroller.createKurs(strOrt, datZeitpunkt, bolavailable, decPreis)

    End Function

    Public Function viewKurs(strKundenID As String) As Array

        Return weiterbildungscontroller.viewKurs(strKundenID)

    End Function

    Public Function changeKurs(strKundenID As Integer, strOrt As String, datZeitpunkt As Date, decPreis As Decimal) As Boolean

        Return weiterbildungscontroller.changeKurs(strKundenID, strOrt, datZeitpunkt, decPreis)

    End Function

    Public Function deleteKurs(strKundenID As String) As Boolean

        Return weiterbildungscontroller.deleteKurs(strKundenID)

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String) As Integer

        Return weiterbildungscontroller.createWeiterbildung(strBezeichnung, strThema, strCurriculum)

    End Function

    Public Function viewWeiterbildung(strWeiterbildungsID As String) As Array

        Return weiterbildungscontroller.viewWeiterbildung(strWeiterbildungsID)

    End Function

    Public Function changeWeiterbildung(strWeiterbildungsID As String, strBezeichnung As String, strThema As String, strCurriculum As String) As Boolean

        Return weiterbildungscontroller.changeWeiterbildung(strWeiterbildungsID, strBezeichnung, strThema, strCurriculum)

    End Function

    Public Function deleteWeiterbildung(strWeiterbildungID As String) As Boolean

        Return weiterbildungscontroller.deleteWeiterbildung(strWeiterbildungID)

    End Function

    'BookingController
    Public Function createBooking(decPreis As Decimal, datDatum As Date) As String

        Return bookingController.createBooking(decPreis, datDatum)

    End Function

    Public Function viewBooking(strBuchungsID) As Array

        Return bookingController.viewBooking(strBuchungsID)

    End Function

    Public Function changeBooking(strBuchungsID As String, decPreis As Decimal, datDatum As Date)

        Return bookingController.changeBooking(strBuchungsID, decPreis, datDatum)

    End Function

    Public Function deleteBooking(strKundenID As String) As Boolean

        Return bookingController.deleteBooking(strKundenID)

    End Function






End Module
