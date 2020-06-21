Module Logic

    'Attribute

    Public mlstAktuellAngemeldeterBenutzer As List(Of Benutzer)
    Public mlstKunde As List(Of Kunde)
    Public mlstMitarbeiter As List(Of Mitarbeiter)
    Public mlstBuchung As List(Of Buchung)
    Public mlstKurs As List(Of Kurs)
    Public mlstWeiterbildungen As List(Of Weiterbildung)
    Public userController As UserController
    Public weiterbildungscontroller As WeiterbildungsController
    Public bookingController As BookingController

    'init funktion


    'Properties 
    Public Property AngemeldeteBenutzer As List(Of Benutzer)
        Get
            Return mlstAktuellAngemeldeterBenutzer
        End Get
        Set(value As List(Of Benutzer))
            mlstAktuellAngemeldeterBenutzer = value
        End Set
    End Property

    Public Property ListeKunden As List(Of Kunde)
        Get
            Return mlstKunde
        End Get
        Set(value As List(Of Kunde))
            mlstKunde = value
        End Set
    End Property

    Public Property ListeMitarbeiter As List(Of Mitarbeiter)
        Get
            Return mlstMitarbeiter
        End Get
        Set(value As List(Of Mitarbeiter))
            mlstMitarbeiter = value
        End Set
    End Property

    Public Property ListeBuchung As List(Of Buchung)
        Get
            Return mlstBuchung
        End Get
        Set(value As List(Of Buchung))
            mlstBuchung = value
        End Set
    End Property

    Public Property ListeKurse As List(Of Kurs)
        Get
            Return mlstKurs
        End Get
        Set(value As List(Of Kurs))
            mlstKurs = value
        End Set
    End Property

    Public Property ListeWeiterbildung As List(Of Weiterbildung)
        Get
            Return mlstWeiterbildungen
        End Get
        Set(value As List(Of Weiterbildung))
            mlstWeiterbildungen = value
        End Set
    End Property

    ''' <summary>
    ''' Erzeugt Beispieldaten von Benutzern, Mitarbeiter, Weiterbildung, mit denen beim ersten Programmstart gearbeitet werden kann.
    ''' </summary>
    '''<remarks>funktion initialise
    '''</remarks>
    Public Function initialise()
        'TODO initialise lists from database
        mlstMitarbeiter = New List(Of Mitarbeiter) From
        {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#)}
        mlstKunde = New List(Of Kunde) From
            {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#)}

        mlstKurs = New List(Of Kurs) From
            {New Kurs(#07/30/2020 01:30:00 PM#, "Raum20", True, 4000, False), New Kurs(#08/21/2020 08:00:00 AM #, "Raum12", True, 1500, False)}
        mlstWeiterbildungen = New List(Of Weiterbildung) From {
            New Weiterbildung("Agil im Arbeitsalltag", "Agiles Projektmanagement", "1. X, 2. Y, 3. Z ", "Führungskräfte von agilen Teams")}

        mlstBuchung = New List(Of Buchung) From {
        New Buchung(1200, #07/21/2020#, mlstKurs)
        }

        userController = New UserController(mlstMitarbeiter, mlstKunde)
        weiterbildungscontroller = New WeiterbildungsController(mlstKurs, mlstWeiterbildungen)
        bookingController = New BookingController(mlstBuchung)

    End Function

    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Return userController.logIn(strBenutzername, strPasswort)

    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date, pstrFirma As String) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat, pstrFirma)
        mlstKunde.Add(kunde)
        Dim strKundenID As String = kunde.KundenID
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
        mlstMitarbeiter.Add(mitarbeiter)

        Dim strMitarbeiterID As String = mitarbeiter.MitarbeiterID()
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
    Public Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal) As String

        Return weiterbildungscontroller.createKurs(pstrOrt, pdatZeitpunkt, pbolavailable, pdecPreis)

    End Function

    Public Function viewKurs(pstrKundenID As String) As Array

        Return weiterbildungscontroller.viewKurs(pstrKundenID)

    End Function

    Public Function changeKurs(pstrKundenID As Integer, pstrOrt As String, datZeitpunkt As Date, pdecPreis As Decimal) As Boolean

        Return weiterbildungscontroller.changeKurs(pstrKundenID, pstrOrt, datZeitpunkt, pdecPreis)

    End Function

    Public Function deleteKurs(pstrKundenID As String) As Boolean

        Return weiterbildungscontroller.deleteKurs(pstrKundenID)

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(pstrBezeichnung As String, pstrThema As String, pstrCurriculum As String) As Integer

        Return weiterbildungscontroller.createWeiterbildung(pstrBezeichnung, pstrThema, pstrCurriculum)

    End Function

    Public Function viewWeiterbildung(pstrWeiterbildungsID As String) As Array

        Return weiterbildungscontroller.viewWeiterbildung(pstrWeiterbildungsID)

    End Function

    Public Function changeWeiterbildung(strWeiterbildungsID As String, strBezeichnung As String, strThema As String, strCurriculum As String) As Boolean

        Return weiterbildungscontroller.changeWeiterbildung(strWeiterbildungsID, strBezeichnung, strThema, strCurriculum)

    End Function

    Public Function deleteWeiterbildung(strWeiterbildungID As String) As Boolean

        Return weiterbildungscontroller.deleteWeiterbildung(strWeiterbildungID)

    End Function

    'BookingController
    Public Function createBooking(pdecPreis As Decimal, pdatDatum As Date) As String

        Return bookingController.createBooking(pdecPreis, pdatDatum)

    End Function

    Public Function viewBooking(pstrBuchungsID) As Array

        Return bookingController.viewBooking(pstrBuchungsID)

    End Function

    Public Function changeBooking(pstrBuchungsID As String, pdecPreis As Decimal, pdatDatum As Date)

        Return bookingController.changeBooking(pstrBuchungsID, pdecPreis, pdatDatum)

    End Function

    Public Function deleteBooking(pstrKundenID As String) As Boolean

        Return bookingController.deleteBooking(pstrKundenID)

    End Function






End Module
