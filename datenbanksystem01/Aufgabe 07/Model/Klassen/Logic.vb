Module Logic

    'Attribute

    Public mlstAktuellAngemeldeterBenutzer As List(Of Benutzer)
    Public mlstBenutzer As List(Of Benutzer) = New List(Of Benutzer)
    Public mlstKunde As List(Of Kunde) = New List(Of Kunde)
    Public mlstMitarbeiter As List(Of Mitarbeiter) = New List(Of Mitarbeiter)
    Public mlstBuchung As List(Of Buchung) = New List(Of Buchung)
    Public mlstKurs As List(Of Kurs) = New List(Of Kurs)
    Public mlstWeiterbildungen As List(Of Weiterbildung) = New List(Of Weiterbildung)
    Private userController As UserController
    Private weiterbildungscontroller As WeiterbildungsController = New WeiterbildungsController
    Private bookingController As BookingController

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
        mlstAktuellAngemeldeterBenutzer = New List(Of Benutzer)

        'initialise lists from database
        ListeMitarbeiter = BenutzerDAO.ladenMitarbeiter()
        ListeKunden = BenutzerDAO.ladenKunden()
        ListeBuchung = BuchungsDAO.ladenBuchung()
        'ListeKurse = Kurs__und_WeiterbildungsDAO.ladenKurse()
        'ListeWeiterbildung = Kurs__und_WeiterbildungsDAO.ladenWeiterbildung()

        ''Beispieldatensätze erstellen
        'mlstMitarbeiter = New List(Of Mitarbeiter) From
        '  {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#, 1), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#, 2), New Mitarbeiter("off", "pw", "Off", "Thomas", #10/23/1969#, 3)}
        'mlstKunde = New List(Of Kunde) From
        '  {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#, 4, "BlalBla AG"), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#, 5, "ShareNow")}


        ''Weiterbildungen deklarieren
        'Dim agiles, scrum, controlling, bmc As Weiterbildung

        ''Weiterbildungen initialisieren ohne Parameter


        '' Weiterbildungen initialisieren mit Parameter
        'scrum = New Weiterbildung("SCRUM", "Projekt-, Prozess- und Changemanagement", "1) Scrum - Herkunft und Entwicklung
        '                                                                               2) Die Scrum Philosophie
        '                                                                               3) Die Agile Phase", "Dieser Workshop richtet sich an alle, die in ihrem Unternehmen
        '                          die mögliche Umstellung auf agiles Produkt- und Projektmanagement übernehmen sollen und dafür z.B. die Anforderungen liefern mussen", kurs02)
        'controlling = New Weiterbildung("Controlling Kompaktseminar", "Controlling", "1) Grundlagen des Controllings,
        '                                                                              2) Controlling - Übersicht,
        '                                                                              3) Kosten- und Erfolgsrechnung", "Fach- und Führungskräfte, Mitarbeiter der entsprechnenden
        '                            Fachabteilung, Finanz- und Budgetverantwortliche, Mitarbeiter des Rechnungswesens sowie der Buchhaltung", kurs05)
        'bmc = New Weiterbildung("Business Model Canvas", "Digital Business", "1) Wer sind meine Kunden und welche Bedürfnisse und Interessen haben Sie?
        '                                                                      2) Was biete ich an und welchen Mehrwert schaffe ich für meine Kunden?
        '                                                                      3) Wie sieht meine Einnahme- und Kostenstruktur aus?", "Unternehmer, Projektmanager oder Marketingmitarbeiter,
        '                        die kreative Methoden ausprobieren wollen, um Ihre Projekte schneller und effizientre zu planen. Start-Ups, die Ihr Geschäftsmodell gestalten
        '                        möchten. Menschen, die sich strategisch und oranisatorisch mit Produkt- und Serviceinnovationen beschäftigen.", kurs07)
        ''WeiterbildungsID
        'agiles.WeiterbildungsID = "1"
        'scrum.WeiterbildungsID = "2"
        'controlling.WeiterbildungsID = "3"
        'bmc.WeiterbildungsID = "4"

        ''Weiterbildungen zur Liste hinzufügen
        'mlstWeiterbildungen.Add(agiles)
        'mlstWeiterbildungen.Add(scrum)
        'mlstWeiterbildungen.Add(controlling)
        'mlstWeiterbildungen.Add(bmc)


        'weiterbildungen erstellen
        Dim agil As Weiterbildung = weiterbildungscontroller.createWeiterbildung("Agiles Projektmanagement",
                                                                            "1) Grundlagen des agilen Projektmanagement
                                                                            2) Scrum
                                                                            3) Kanban 
                                                                            4) Design Thinking
                                                                            5) User Journey Mapping",
                                                                            "Projektmanager und Projektleiter sowie Projektcontroller, -assistenten, -mitarbeiter und jeder, der seine Fähigkeiten während der Projektarbeit effizienter gestalten möchte.",
                                                                            "Projekt-, Prozess- und Changemanagement")
        ListeWeiterbildung.Add(agil)


        Dim Scrum As Weiterbildung = weiterbildungscontroller.createWeiterbildung("SCRUM",
                                                                            "1) Scrum - Herkunft und Entwicklung
                                                                            2) Die Scrum Philosophie
                                                                            3) Die Agile Phase",
                                                                            "Dieser Workshop richtet sich an alle, die in ihrem Unternehmen die mögliche Umstellung auf agiles Produkt- und Projektmanagement übernehmen sollen und dafür z.B. die Anforderungen liefern mussen",
                                                                            "Projekt-, Prozess- und Changemanagement")
        ListeWeiterbildung.Add(Scrum)

        Dim controlling As Weiterbildung = weiterbildungscontroller.createWeiterbildung("Controlling Kompaktseminar",
                                                                            "1) Grundlagen des Controllings,
                                                                            2) Controlling - Übersicht,
                                                                            3) Kosten- und Erfolgsrechnung",
                                                                            "Fach- und Führungskräfte, Mitarbeiter der entsprechnenden Fachabteilung, Finanz- und Budgetverantwortliche, Mitarbeiter des Rechnungswesens sowie der Buchhaltung",
                                                                            "Controlling")
        ListeWeiterbildung.Add(controlling)

        Dim bmv As Weiterbildung = weiterbildungscontroller.createWeiterbildung("Business Model Canvas",
                                                                            "1) Wer sind meine Kunden und welche Bedürfnisse und Interessen haben Sie?
                                                                             2) Was biete ich an und welchen Mehrwert schaffe ich für meine Kunden?
                                                                             3) Wie sieht meine Einnahme- und Kostenstruktur aus?",
                                                                            "Unternehmer, Projektmanager oder Marketingmitarbeiter, die kreative Methoden ausprobieren wollen, um Ihre Projekte schneller und effizientre zu planen. 
                                                                            Start-Ups, die Ihr Geschäftsmodell gestalten möchten. Menschen, die sich strategisch und oranisatorisch mit Produkt- und Serviceinnovationen beschäftigen.",
                                                                            "Digital Business")
        ListeWeiterbildung.Add(bmv)

        'Kurse erstellen & zur Liste hinzufügen
        MessageBox.Show(ListeKurse.Count)
        Dim kurs1 As Kurs = weiterbildungscontroller.createKurs("Berlin", #07/30/2020#, True, 1500, agil)
        ListeKurse.Add(kurs1)
        Dim kurs2 As Kurs = weiterbildungscontroller.createKurs("Berlin", #08/21/2020#, True, 800, Scrum)
        ListeKurse.Add(kurs2)
        Dim kurs3 As Kurs = weiterbildungscontroller.createKurs("Stuttgart", #09/13/2020#, True, 1800, bmv)
        ListeKurse.Add(kurs3)
        MessageBox.Show(ListeKurse.Count)


        ''Weitere Kurse zur Weiterbildung hinzufügen
        'scrum.LstKurs.Add(kurs03)  'Kurs03 wird zur Witerbildung "Scrum" hinzugefügt
        'controlling.LstKurs.Add(kurs06)
        'bmc.LstKurs.Add(kurs08)


        ''Buchung Datenbank
        'mlstBuchung = New List(Of Buchung) 'From {
        ''New Buchung(1200, #07/21/2020#, mlstKurs)}
        ''Buchungen deklarieren
        'Dim buchung01, buchung02 As Buchung
        ''Buchung initialisieren ohne Parameter
        'buchung01 = New Buchung()
        'buchung01.BuchungsID = Nothing
        'buchung01.gebuchterKurs = Nothing
        ''Buchung initialisieren mit Parameter
        'buchung02 = New Buchung(kurs03, scrum.Bezeichnung)
        ''Buchung ID
        'buchung01.BuchungsID = "1"
        'buchung02.BuchungsID = "2"
        ''Buchung zur Liste hinzufügen
        'mlstBuchung.Add(buchung01)
        'mlstBuchung.Add(buchung02)


        'BenutzerDAO.speichernMitarbeiter(mlstMitarbeiter)
        'BenutzerDAO.speichernKunde(mlstKunde)
        'BuchungsDAO.speichernBuchung(mlstBuchung)
        'Kurs__und_WeiterbildungsDAO.speichernKurs(ListeKurse)
        'Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(mlstWeiterbildungen)

        userController = New UserController(ListeMitarbeiter, ListeKunden)
        'weiterbildungscontroller = New WeiterbildungsController(ListeKurse, ListeWeiterbildung)
        bookingController = New BookingController(ListeBuchung)
    End Function




    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)
        Return userController.logIn(strBenutzername, strPasswort)
    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date, uintBenutzerID As UInteger, pstrFirma As String) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat, uintBenutzerID, pstrFirma)
        mlstKunde.Add(kunde)
        Return uintBenutzerID

    End Function

    Public Function viewKunde(uintBenutzerID) As Array

        Return userController.viewKunde(uintBenutzerID)

    End Function

    Public Function changeKunde(uintBenutzerId As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeKunde(uintBenutzerId, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteKunde(uintBenutzerID As Integer) As Boolean

        Return userController.deleteKunde(uintBenutzerID)

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date, puintBenutzerID As UInteger) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat, puintBenutzerID)
        mlstMitarbeiter.Add(mitarbeiter)

        Dim uintBenutzerID As UInteger = mitarbeiter.BenutzerID()
        Return uintBenutzerID

    End Function

    Public Function viewMitarbeiter(uintBenutzerID As String) As Array

        Return userController.viewMitarbeiter(uintBenutzerID)

    End Function

    Public Function changeMitarbeiter(uintBenutzerID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeMitarbeiter(uintBenutzerID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteMitarbeiter(uintBenutzerID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return userController.deleteMitarbeiter(uintBenutzerID)

    End Function

    'WeiterbildungsController
    Public Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal, pweiterbildung As Weiterbildung) As Kurs

        Return WeiterbildungsController.createKurs(pstrOrt, pdatZeitpunkt, pbolavailable, pdecPreis, pweiterbildung)

    End Function

    Public Function viewKurs(puintKursID As String) As Array

        Return weiterbildungscontroller.viewKurs(puintKursID)

    End Function

    Public Function changeKurs(puintKursID As String, pstrOrt As String, pdatZeitpunkt As Date, pdecPreis As Decimal, pbearbKurs As Kurs) As Boolean

        Return weiterbildungscontroller.changeKurs(puintKursID, pstrOrt, pdatZeitpunkt, pdecPreis, pbearbKurs)

    End Function

    Public Function deleteKurs(puintKursID As String) As Boolean

        Return weiterbildungscontroller.deleteKurs(puintKursID)

    End Function

    'BookingController
    Public Function createBooking(pKurs As Kurs, pbenTeilnehmer As Benutzer) As Buchung

        Return bookingController.createBooking(pKurs, pbenTeilnehmer)

    End Function

    'Public function view Booking wegen Gui überflüssig

    Public Function changeBooking(puintBuchungsID As String, pbearbBuchung As Buchung) As Boolean

        Return bookingController.changeBooking(puintBuchungsID, pbearbBuchung)

    End Function

    Public Function deleteBooking(pstrKundenID As String) As Boolean

        Return bookingController.deleteBooking(pstrKundenID)

    End Function






End Module
