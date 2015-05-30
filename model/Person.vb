Public Class Person

    Private _uuid As String = String.Empty
    Private _firstName As String = String.Empty
    Private _lastName As String = String.Empty
    Private _midName As String = String.Empty
    Private _firstNameKana As String = String.Empty
    Private _lastNameKana As String = String.Empty
    Private _birthDay As Date

    Private _contacts As jp.polestar.model.pim.Contacts
    Private _address As jp.polestar.model.pim.Addresses

    Public Sub New()
        Me._uuid = System.Guid.NewGuid.ToString
    End Sub

    Public ReadOnly Property UUID As String
        Get
            Return Me._uuid
        End Get
    End Property

    Public Property FirstName As String
        Get
            Return Me._firstName
        End Get
        Set(value As String)
            Me._firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return Me._lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property Birthday As Date
        Get
            Return Me._birthDay
        End Get
        Set(value As Date)
            Me._birthDay = value
        End Set
    End Property

    Public Property FirstNameKana As String
        Get
            Return Me._firstNameKana
        End Get
        Set(value As String)
            Me._firstNameKana = value
        End Set
    End Property

    Public Property LastNameKana As String
        Get
            Return Me._lastNameKana
        End Get
        Set(value As String)
            Me._lastNameKana = value
        End Set
    End Property

    Public ReadOnly Property Age() As Integer
        Get
            Dim result As Integer

            Return result
        End Get
    End Property

    Public ReadOnly Property Contacts As jp.polestar.model.pim.Contact()
        Get
            Return Me._contacts.Item
        End Get
    End Property

    Public ReadOnly Property Addresses As jp.polestar.model.pim.Address()
        Get
            Return Me._address.Item
        End Get
    End Property

    Public Sub addContact()

    End Sub

    Public Sub addAddress()

    End Sub

    Public Sub removeContact()

    End Sub

    Public Sub removeAddress()

    End Sub

    Public Sub modifyContact()

    End Sub

    Public Sub modifyAddress()

    End Sub




End Class

