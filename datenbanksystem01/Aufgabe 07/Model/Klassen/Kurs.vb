Imports System.Xml.Serialization

<System.Serializable()>
Public Class Kurs

    'Properties
    Public mstrKursID As String
    Public mdatZeitpunkt As Date
    Public mstrOrt As String
    Public mbolVerfuegbar As Boolean
    Public mdecPreis As Decimal
    Public mbolAbgesagt As Boolean
    Public mlstBuchungen As List(Of Buchung)

    'Konstruktoren
    'Parameterloser Konstruktor
    Sub New()
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mbolVerfuegbar = False
        mdecPreis = Nothing
        mbolAbgesagt = False
        mlstBuchungen = New List(Of Buchung)
    End Sub

    'Konstruktor mit Parameter
    Sub New(pdatZeitpunkt As Date, pstrOrt As String, pbolVerfuegbar As Boolean, pdecPreis As Decimal, pbolAbgesagt As Boolean)

        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mbolVerfuegbar = pbolVerfuegbar
        mdecPreis = pdecPreis
        mbolAbgesagt = pbolAbgesagt

    End Sub

    'Properties

    Public ReadOnly Property KursID As String
        Get
            Return mstrKursID
        End Get
    End Property

    Public Property Zeitpunkt As Date
        Get
            Return mdatZeitpunkt
        End Get
        Set(value As Date)
            mdatZeitpunkt = value
        End Set
    End Property

    Public Property Ort As String
        Get
            Return mstrOrt
        End Get
        Set(value As String)
            mstrOrt = value
        End Set
    End Property

    Public Property Verfuegbar As Boolean
        Get
            Return mbolVerfuegbar
        End Get
        Set(value As Boolean)
            mbolVerfuegbar = value
        End Set
    End Property

    Public Property Preis As Decimal
        Get
            Return mdecPreis
        End Get
        Set(value As Decimal)
            If mdecPreis > 0 Then
                mdecPreis = value
            End If
        End Set
    End Property

    Public Property Abgesagt As Decimal
        Get
            Return mbolAbgesagt
        End Get
        Set(value As Decimal)
            mbolAbgesagt = value
        End Set
    End Property

    Public Property Buchungen As List(Of Buchung)
        Get
            Return mlstBuchungen
        End Get
        Set(value As List(Of Buchung))
            mlstBuchungen = value
        End Set
    End Property


    Public Shared Function zeigenAlle() As List(Of Kurs)

        Dim lstKurs As List(Of Kurs)

        lstKurs = Kurs__und_WeiterbildungsDAO.ladenKurse()

        Return lstKurs

    End Function

    Public Shared Sub speichernAlle(pstrKurs As List(Of Kurs))

        Kurs__und_WeiterbildungsDAO.speichernKurs(pstrKurs)

    End Sub



End Class
