Public Class Contacts
    Private _contacts As System.Collections.Generic.Dictionary(Of String, jp.polestar.model.pim.Contact)

    Public ReadOnly Property Item(index As Long) As jp.polestar.model.pim.Contact()
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Item(internalCode As String) As jp.polestar.model.pim.Contact()
        Get
            Return Nothing
        End Get
    End Property

    Public Function add(contact As jp.polestar.model.pim.Contact) As Long
        If Me.validate(contact) = True Then

        End If
        Return 0
    End Function

    Public Function modify(contact As jp.polestar.model.pim.Contact) As Long
        Return 0
    End Function

    Public Function remove(contact As jp.polestar.model.pim.Contact) As Long
        Return 0
    End Function

    Public Function validate(contact As jp.polestar.model.pim.Contact) As Boolean

        Return False
    End Function

    Public Function load() As Long
        Return 0
    End Function

    Public Function flash() As Long
        Return 0
    End Function

End Class

