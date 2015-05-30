Public Class Address

    Private _addressType As ENUM_ADDRESS_TYPE = ENUM_ADDRESS_TYPE.NONE
    Private _zipCode As String = String.Empty
    Private _prefecture As String = String.Empty
    Private _city As String = String.Empty
    Private _address_1 As String = String.Empty
    Private _address_2 As String = String.Empty

    Public Property AddressType As ENUM_ADDRESS_TYPE
        Get
            Return Me._addressType
        End Get
        Set(value As ENUM_ADDRESS_TYPE)
            Me._addressType = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return Me._zipCode
        End Get
        Set(value As String)
            Me._zipCode = value
        End Set
    End Property

    Public Property Prefecture As String
        Get
            Return Me._prefecture
        End Get
        Set(value As String)
            Me._prefecture = value
        End Set
    End Property

    Public Property City As String
        Get
            Return Me._city
        End Get
        Set(value As String)
            Me._city = value
        End Set
    End Property


    Public Property Address1 As String
        Get
            Return Me._address_1
        End Get
        Set(value As String)
            Me._address_1 = value
        End Set
    End Property


    Public Property Adddress_2 As String
        Get
            Return Me._address_2
        End Get
        Set(value As String)
            _address_2 = value
        End Set
    End Property


End Class

Public Enum ENUM_ADDRESS_TYPE As Long
    NONE = 0
    HOME = 1
    OFFICE = 2

End Enum
