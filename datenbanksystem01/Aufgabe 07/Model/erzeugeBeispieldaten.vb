Module erzeugeBeispieldaten
    ''' <summary>
    ''' Erzeugt eine Liste von Weiterbildungen und liefert diese zurücl, so dass mit Ihnen als Beispieldaten erzeugt werden.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function erzeugeBeispieldaten() As List(Of Weiterbildung)
        'Liste der Weiterbildungs initialisieren
        mlstWeiterbildungen = New List(Of Weiterbildung)

        'Weiterbildungen deklarieren
        Dim agiles, scrum, controlling, bmc As Weiterbildung

        'Weiterbildungen initialisieren
        agiles = New Weiterbildung()
        agiles.Bezeichnung = "Agiles Projektmanagement"
        agiles.Curriculum = "1) Grundlagen des agilen Projektmanagement
                             2) Scrum
                             3) Kanban
                             4) Design Thinking
                             5) User Journey Mapping"
        agiles.Thema = "Projekt-, Prozess- und Changemanagement"
        agiles.Teilnehmerkreis = "Projektmanager und Projektleiter sowie Projektcontroller, -assistenten,
                                 -mitarbeiter und jeder, der seine Fähigkeiten während der Projektarbeit effizienter gestalten möchte."

        ' Liste der Weiterbildungen initialisieren
        scrum = New Weiterbildung("SCRUM", "Projekt-, Prozess- und Changemanagement", "1) Scrum - Herkunft und Entwicklung
                                                                                       2) Die Scrum Philosophie
                                                                                       3) Die Agile Phase", "Dieser Workshop richtet sich an alle, die in ihrem Unternehmen
                                  die mögliche Umstellung auf agiles Produkt- und Projektmanagement übernehmen sollen und dafür z.B. die Anforderungen liefern mussen")
        controlling = New Weiterbildung("Controlling Kompaktseminar", "Controlling", "1) Grundlagen des Controllings,
                                                                                      2) Controlling - Übersicht,
                                                                                      3) Kosten- und Erfolgsrechnung", "Fach- und Führungskräfte, Mitarbeiter der entsprechnenden
                                    Fachabteilung, Finanz- und Budgetverantwortliche, Mitarbeiter des Rechnungswesens sowie der Buchhaltung")
        bmc = New Weiterbildung("Business Model Canvas", "Digital Business", "1) Wer sind meine Kunden und welche Bedürfnisse und Interessen haben Sie?
                                                                              2) Was biete ich an und welchen Mehrwert schaffe ich für meine Kunden?
                                                                              3) Wie sieht meine Einnahme- und Kostenstruktur aus?", "Unternehmer, Projektmanager oder Marketingmitarbeiter,
                                die kreative Methoden ausprobieren wollen, um Ihre Projekte schneller und effizientre zu planen. Start-Ups, die Ihr Geschäftsmodell gestalten
                                möchten. Menschen, die sich strategisch und oranisatorisch mit Produkt- und Serviceinnovationen beschäftigen.")

        'Weiterbildungen zur Liste hinzufügen
        mlstWeiterbildungen.Add(agiles)
        mlstWeiterbildungen.Add(scrum)
        mlstWeiterbildungen.Add(controlling)
        mlstWeiterbildungen.Add(bmc)

        'Liste zurückgeben
        Return mlstWeiterbildungen

    End Function




End Module
