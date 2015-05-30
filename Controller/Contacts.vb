Public Class Contacts
    Implements jp.polestar.model.pim.IPim

    Private _item As System.Collections.Generic.Dictionary(Of String, jp.polestar.model.pim.Contact)

    Public ReadOnly Property Item() As jp.polestar.model.pim.Contact()
        Get
            Dim _result As List(Of jp.polestar.model.pim.Contact) = New List(Of Contact)
            For Each _uuid As String In _item.Keys
                _result.Add(_item(_uuid))
            Next
            Return _result.ToArray
        End Get
    End Property

    Public ReadOnly Property Item(UUID As String) As jp.polestar.model.pim.Contact
        Get
            Return _item(UUID)
        End Get
    End Property

    Public Function add(contact As Object) As Boolean Implements IPim.add
        Dim _contact As jp.polestar.model.pim.Contact = CType(contact, jp.polestar.model.pim.Contact)
        If Me.valid(_contact) = True Then
            _item.Add(_contact.UUID, _contact)
        End If
        Return 0
    End Function

    Public Function modify(contact As Object) As Boolean Implements IPim.modify
        Dim _contact As jp.polestar.model.pim.Contact = CType(contact, jp.polestar.model.pim.Contact)


        Return 0
    End Function

    Public Function remove(UUID As String) As Boolean Implements IPim.remove
        _item.Remove(UUID)
        Return 0
    End Function

    Public Function valid(contact As Object) As Boolean Implements IPim.valid
        Dim _contact As Contact = CType(contact, jp.polestar.model.pim.Contact)

        Return False
    End Function

    Public Function load() As Long Implements IPim.load
        Return 0
    End Function

    Public Function flash() As Long Implements IPim.flash
        Return 0
    End Function

End Class

