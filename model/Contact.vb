Public Class Contact

    Private _uuid As String = String.Empty
    Private _contactType As jp.polestar.model.pim.ENUM_CONTACT_TYPE
    Private _contactName As String = String.Empty
    Private _contactValue As String = String.Empty

    Public Sub New()
        Me._uuid = System.Guid.NewGuid.ToString
    End Sub

    Public ReadOnly Property UUID As String
        Get
            Return Me._uuid
        End Get
    End Property

    Public Property ContactType As jp.polestar.model.pim.ENUM_CONTACT_TYPE
        Get
            Return _contactType
        End Get
        Set(value As jp.polestar.model.pim.ENUM_CONTACT_TYPE)
            _contactType = value
        End Set
    End Property

    Public Property ContactName As String
        Get
            Return _contactName
        End Get
        Set(value As String)
            _contactName = value
        End Set
    End Property

    Public Property ContactValue As String
        Get
            Return _contactValue
        End Get
        Set(value As String)
            _contactValue = value
        End Set
    End Property

End Class

Public Enum ENUM_CONTACT_TYPE As Long
    PHONE_CELL = 0
    PHONE_HOME = 1
    PHONE_OFFICE = 2
    PHONE_ETC = 3
    EMAIL_PERSONAL = 4
    EMAIL_OFFICE = 5
    OTHER = 99

End Enum
