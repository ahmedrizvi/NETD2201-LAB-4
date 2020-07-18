Option Strict On
' This class creates car objects, including their model, make, year, and price.

Public Class Car

#Region "Properties"
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 1920
    Private carPrice As Decimal = 0
    Private newStatus As Boolean = False
    Private carID As Integer = -1
    Shared carCount As Integer = 0
#End Region

#Region "Constructors"
    ' Default constructor
    Public Sub New()
        carID = carCount
        carCount += 1
    End Sub
    ' Parameterized constructor
    Public Sub New(make As String, model As String, year As Integer, price As Decimal, newCar As Boolean)
        Me.New() ' Calls the default constructor
        Me.Make = make
        Me.Model = model
        Me.Year = year
        Me.Price = price
        Me.NewCar = newCar
    End Sub
#End Region

#Region "Property Methods"
    ' Car's make property
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    ' Car's model property
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    ' Car's model year property
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property
    ' Car's listed price property
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(ByVal value As Decimal)
            carPrice = value
        End Set
    End Property
    ' Boolean of whether the car is new property
    Public Property NewCar() As Boolean
        Get
            Return newStatus
        End Get
        Set(ByVal value As Boolean)
            newStatus = value
        End Set
    End Property

    Public ReadOnly Property IDofCar() As Integer
        Get
            Return carID
        End Get
    End Property

    Public ReadOnly Property Total() As Integer
        Get
            Return carCount
        End Get
    End Property

#End Region

#Region "Methods"
    ' A function that prints a string, containing a car's details.
    Public Function GetCarData() As String
        Return "The " & Me.Make & " " & Me.Model & " is listed at $" & Me.Price
    End Function
#End Region
End Class
