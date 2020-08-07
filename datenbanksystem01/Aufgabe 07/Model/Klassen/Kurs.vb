Imports System.Xml.Serialization

<System.Serializable()>
Public Class Kurs

    'Properties
    Private muintKursID As UInteger
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mbolVerfuegbar As Boolean
    Private mdecPreis As Decimal
    Private mbolAbgesagt As Boolean
    Private mWeiterbildung As Weiterbildung

    'Konstruktoren
    'Parameterloser Konstruktor
    Sub New()
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mbolVerfuegbar = False
        mdecPreis = Nothing
        mbolAbgesagt = False
        mWeiterbildung = New Weiterbildung()
        'mBuchungen = New Buchung
    End Sub

    'Konstruktor mit Parameter
    Sub New(pdatZeitpunkt As Date, pstrOrt As String, pbolVerfuegbar As Boolean, pdecPreis As Decimal, pbolAbgesagt As Boolean, pWeiterbildung As Weiterbildung) ', mBuchungen As Buchung)

        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mbolVerfuegbar = pbolVerfuegbar
        mdecPreis = pdecPreis
        mbolAbgesagt = pbolAbgesagt
        mWeiterbildung = pWeiterbildung

    End Sub

    'Properties

    Public Property KursID As UInteger
        Get
            Return muintKursID
        End Get
        Set(value As UInteger)
            muintKursID = value
        End Set
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

    Public Property Weiterbildung As Weiterbildung
        Get
            Return mWeiterbildung
        End Get
        Set(value As Weiterbildung)
            mWeiterbildung = value
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
