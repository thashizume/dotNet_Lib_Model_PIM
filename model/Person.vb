Public Class Person

    Private _firstName As String = String.Empty
    Private _lastName As String = String.Empty
    Private _midName As String = String.Empty
    Private _firstNameKana As String = String.Empty
    Private _lastNameKana As String = String.Empty
    Private _birthDay As Date
    Private _guid As String = String.Empty

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

    Public Property IdentifyID As String
        Get
            Return _guid
        End Get
        Set(value As String)
            _guid = value
        End Set
    End Property

    Public Sub setIdentifyID()
        Me._guid = System.Guid.NewGuid.ToString
    End Sub

    Public ReadOnly Property Age() As Integer
        Get
            Dim result As Integer

            Return result
        End Get
    End Property
End Class

