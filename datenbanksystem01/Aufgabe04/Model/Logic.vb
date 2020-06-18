Module Logic

    'Properties

    Public AktuellAngemeldeterBenutzer As Benutzer
    Private Property mlstKunde As List(Of Kunde)
    Private Property mlstMitarbeiter As List(Of Mitarbeiter)
    Private Property mlstBuchung As List(Of Buchung)
    Private Property mlstKurse As List(Of Kurs)
    Private Property mlstWeiterbildungen As List(Of Weiterbildung)
    Private Property userController As UserController
    Private Property weiterbildungscontroller As WeiterbildungsController
    Private Property bookingController As BookingController



    'funktion initialise
    Public Function initialise()
        'TODO initialise lists from database
        mlstMitarbeiter = New List(Of Mitarbeiter) From
        {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#)}
        mlstKunde = New List(Of Kunde) From
        {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#)}

        userController = New UserController(mlstMitarbeiter, mlstKunde)
        weiterbildungscontroller = New WeiterbildungsController(mlstKurse, mlstWeiterbildungen)
        bookingController = New BookingController(mlstBuchung)

    End Function
    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Return userController.logIn(strBenutzername, strPasswort)

    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        mlstKunde.Add(kunde)
        Dim intKundenID As Integer = kunde.getIntKundenID()
        Return intKundenID

    End Function

    Public Function viewKunde(intKundenID) As Array

        Return userController.viewKunde(intKundenID)

    End Function

    Public Function changeKunde(intKundenID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeKunde(intKundenID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteKunde(intKundenID As Integer) As Boolean

        Return userController.deleteKunde(intKundenID)

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        mlstMitarbeiter.Add(mitarbeiter)

        Dim intMitarbeiterID As Integer = mitarbeiter.getIntMitarbeiterID()
        Return intMitarbeiterID

    End Function

    Public Function viewMitarbeiter(intMitarbeiterID As Integer) As Array

        Return userController.viewMitarbeiter(intMitarbeiterID)

    End Function

    Public Function changeMitarbeiter(intMitarbeiterID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeMitarbeiter(intMitarbeiterID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteMitarbeiter(intMitarbeiterID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return userController.deleteMitarbeiter(intMitarbeiterID)

    End Function

    'TODO Datenbank erstellen (fill with records)

    'WeiterbildungsController
    Public Function createKurs(strOrt As String, datZeitpunkt As Date, bolavailable As Boolean, decPreis As Decimal) As Integer

        'TODO: Return weiterbildungscontroller.createKurs(strOrt, datZeitpunkt, bolavailable, decPreis)

    End Function

    Public Function viewKurs(intKundenID As Integer) As Array

        Return weiterbildungscontroller.viewKurs(intKundenID)

    End Function

    Public Function changeKurs(intKundenID As Integer, strOrt As String, datZeitpunkt As Date, decPreis As Decimal) As Boolean

        Return weiterbildungscontroller.changeKurs(intKundenID, strOrt, datZeitpunkt, decPreis)

    End Function

    Public Function deleteKurs(intKundenID) As Boolean

        Return weiterbildungscontroller.deleteKurs(intKundenID)

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String) As Integer

        'TODO: Return weiterbildungscontroller.createWeiterbildung(strBezeichnung, strThema, strCurriculum)

    End Function

    Public Function viewWeiterbildung(intWeiterbildungsID As Integer) As Array

        Return weiterbildungscontroller.viewWeiterbildung(intWeiterbildungsID)

    End Function

    Public Function changeWeiterbildung(intWeiterbildungsID As Integer, strBezeichnung As String, strThema As String, strCurriculum As String) As Boolean

        Return weiterbildungscontroller.changeWeiterbildung(intWeiterbildungsID, strBezeichnung, strThema, strCurriculum)

    End Function

    Public Function deleteWeiterbildung(intWeiterbildungID) As Boolean

        Return weiterbildungscontroller.deleteWeiterbildung(intWeiterbildungID)

    End Function

    'BookingController
    Public Function createBooking(decPreis As Decimal, datDatum As Date) As Integer

        Return bookingController.createBooking(decPreis, datDatum)

    End Function

    Public Function viewBooking(intBuchungsID) As Array

        Return bookingController.viewBooking(intBuchungsID)

    End Function

    Public Function changeBooking(intBuchungsID As Integer, decPreis As Decimal, datDatum As Date)

        Return bookingController.changeBooking(intBuchungsID, decPreis, datDatum)

    End Function

    Public Function deleteBooking(intKundenID As Integer) As Boolean

        Return bookingController.deleteBooking(intKundenID)

    End Function






End Module
