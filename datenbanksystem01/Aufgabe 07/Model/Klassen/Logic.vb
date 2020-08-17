Module Logic

    'Attribute
    Private mlstAktuellAngemeldeterBenutzer As List(Of Benutzer)
    Private mlstKunde As List(Of Kunde) = New List(Of Kunde)
    Private mlstMitarbeiter As List(Of Mitarbeiter) = New List(Of Mitarbeiter)
    Private mlstBuchung As List(Of Buchung) = New List(Of Buchung)
    Private mlstKurs As List(Of Kurs) = New List(Of Kurs)
    Private mlstWeiterbildungen As List(Of Weiterbildung) = New List(Of Weiterbildung)


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
    Public Sub initialise()
        mlstAktuellAngemeldeterBenutzer = New List(Of Benutzer)

        'initialise lists from database
        ListeMitarbeiter = BenutzerDAO.ladenMitarbeiter()
        ListeKunden = BenutzerDAO.ladenKunden()
        ListeWeiterbildung = Kurs__und_WeiterbildungsDAO.ladenWeiterbildung()
        ListeKurse = Kurs__und_WeiterbildungsDAO.ladenKurse()
        ListeBuchung = BuchungsDAO.ladenBuchung()

        'Beispieldatensätze erstellen
        'createSampleData()

        'BenutzerDAO.speichernMitarbeiter(ListeMitarbeiter)
        'BenutzerDAO.speichernKunde(ListeKunden)
        'Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(ListeWeiterbildung)
        'Kurs__und_WeiterbildungsDAO.speichernKurs(ListeKurse)
        'BuchungsDAO.speichernBuchung(ListeBuchung)
    End Sub

    Private Sub createSampleData()
        'Benutzer erstellen
        ListeMitarbeiter.Add(UserController.createMitarbeiter("jeynie", "Jeynie", "Mesya Maureen", "pw", #09/24/1997#))
        ListeMitarbeiter.Add(UserController.createMitarbeiter("hochtritt", "Hochtritt", "Nina", "pw", #10/21/1999#))
        ListeMitarbeiter.Add(UserController.createMitarbeiter("off", "Off", "Thomas", "pw", #10/23/1969#))

        ListeKunden.Add(UserController.createKunde("mueller", "Mueller", "Micha", "pw", #03/22/1966#, "BlaBla AG"))
        ListeKunden.Add(UserController.createKunde("meier", "Meier", "Jens", "pw", #05/15/1978#, "ShareNow"))


        'Weiterbildungen erstellen
        Dim agil As Weiterbildung = WeiterbildungsController.createWeiterbildung("Agiles Projektmanagement",
                                                                            "1) Grundlagen des agilen Projektmanagement
                                                                            2) Scrum
                                                                            3) Kanban 
                                                                            4) Design Thinking
                                                                            5) User Journey Mapping",
                                                                            "Projektmanager und Projektleiter sowie Projektcontroller, -assistenten, -mitarbeiter und jeder, der seine Fähigkeiten während der Projektarbeit effizienter gestalten möchte.",
                                                                            "Projekt-, Prozess- und Changemanagement")
        ListeWeiterbildung.Add(agil)


        Dim Scrum As Weiterbildung = WeiterbildungsController.createWeiterbildung("SCRUM",
                                                                            "1) Scrum - Herkunft und Entwicklung
                                                                            2) Die Scrum Philosophie
                                                                            3) Die Agile Phase",
                                                                            "Dieser Workshop richtet sich an alle, die in ihrem Unternehmen die mögliche Umstellung auf agiles Produkt- und Projektmanagement übernehmen sollen und dafür z.B. die Anforderungen liefern mussen",
                                                                            "Projekt-, Prozess- und Changemanagement")
        ListeWeiterbildung.Add(Scrum)

        Dim controlling As Weiterbildung = WeiterbildungsController.createWeiterbildung("Controlling Kompaktseminar",
                                                                            "1) Grundlagen des Controllings,
                                                                            2) Controlling - Übersicht,
                                                                            3) Kosten- und Erfolgsrechnung",
                                                                            "Fach- und Führungskräfte, Mitarbeiter der entsprechnenden Fachabteilung, Finanz- und Budgetverantwortliche, Mitarbeiter des Rechnungswesens sowie der Buchhaltung",
                                                                            "Controlling")
        ListeWeiterbildung.Add(controlling)

        Dim bmv As Weiterbildung = WeiterbildungsController.createWeiterbildung("Business Model Canvas",
                                                                            "1) Wer sind meine Kunden und welche Bedürfnisse und Interessen haben Sie?
                                                                             2) Was biete ich an und welchen Mehrwert schaffe ich für meine Kunden?
                                                                             3) Wie sieht meine Einnahme- und Kostenstruktur aus?",
                                                                            "Unternehmer, Projektmanager oder Marketingmitarbeiter, die kreative Methoden ausprobieren wollen, um Ihre Projekte schneller und effizientre zu planen. 
                                                                            Start-Ups, die Ihr Geschäftsmodell gestalten möchten. Menschen, die sich strategisch und oranisatorisch mit Produkt- und Serviceinnovationen beschäftigen.",
                                                                            "Digital Business")
        ListeWeiterbildung.Add(bmv)

        'Kurse erstellen
        Dim kurs1 As Kurs = createKurs("Berlin", #07/30/2020#, True, 1500, agil)
        ListeKurse.Add(kurs1)
        Dim kurs2 As Kurs = createKurs("Berlin", #08/21/2020#, True, 800, Scrum)
        ListeKurse.Add(kurs2)
        Dim kurs3 As Kurs = createKurs("Stuttgart", #09/13/2020#, True, 1800, bmv)
        ListeKurse.Add(kurs3)


        'Buchung erstellen
        Dim buchung As Buchung = BookingController.createBooking(kurs1, ListeKunden(0))
        ListeBuchung.Add(buchung)
    End Sub


    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)
        Return UserController.logIn(strBenutzername, strPasswort)
    End Function

    Public Sub createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date, pstrFirma As String)
        Dim kunde As Kunde = UserController.createKunde(strBenutzername, strName, strVorname, strPasswort, datGebDat, pstrFirma)
        ListeKunden.Add(kunde)
    End Sub

    Public Function changeKunde(uintBenutzerId As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String, strFirma As String, datGebDat As Date) As Boolean

        Return UserController.changeKunde(uintBenutzerId, strBenutzername, strPasswort, strVorname, strName, strFirma, datGebDat)

    End Function

    Public Function deleteKunde(uintBenutzerID As Integer) As Boolean

        Return UserController.deleteKunde(uintBenutzerID)

    End Function


    Public Sub createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date)

        Dim mitarbeiter As Mitarbeiter = UserController.createMitarbeiter(strBenutzername, strName, strVorname, strPasswort, datGebDat)
        ListeMitarbeiter.Add(mitarbeiter)

    End Sub

    Public Function changeMitarbeiter(uintBenutzerID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String, datGebDat As Date) As Boolean

        Return UserController.changeMitarbeiter(uintBenutzerID, strBenutzername, strPasswort, strVorname, strName, datGebDat)

    End Function

    Public Function deleteMitarbeiter(uintBenutzerID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return UserController.deleteMitarbeiter(uintBenutzerID)

    End Function

    'WeiterbildungsController
    Public Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal, pweiterbildung As Weiterbildung) As Kurs

        Return WeiterbildungsController.createKurs(pstrOrt, pdatZeitpunkt, pbolavailable, pdecPreis, pweiterbildung)

    End Function

    Public Function viewKurs(puintKursID As UInteger) As Array

        Return WeiterbildungsController.viewKurs(puintKursID)

    End Function

    Public Function changeKurs(puintKursID As String, pstrOrt As String, pdatZeitpunkt As Date, pdecPreis As Decimal, pboolAbgesagt As Boolean) As Boolean

        Return WeiterbildungsController.changeKurs(puintKursID, pstrOrt, pdatZeitpunkt, pdecPreis, pboolAbgesagt)

    End Function

    Public Function deleteKurs(puintKursID As UInteger) As Boolean

        Return WeiterbildungsController.deleteKurs(puintKursID)

    End Function

    'BookingController
    Public Function createBooking(pKurs As Kurs, pbenTeilnehmer As Benutzer) As Buchung

        Return BookingController.createBooking(pKurs, pbenTeilnehmer)

    End Function

    'Public function view Booking wegen Gui überflüssig

    Public Function deleteBooking(pstrKundenID As String) As Boolean

        Return BookingController.deleteBooking(pstrKundenID)

    End Function

End Module
