Public Class Addresses
    Implements jp.polestar.model.pim.IPim

    Private _item As System.Collections.Generic.Dictionary(Of String, Address)

    Public ReadOnly Property Item() As jp.polestar.model.pim.Address()
        Get
            Dim _result As List(Of jp.polestar.model.pim.Address) = New List(Of Address)
            For Each _uuid As String In _item.Keys
                _result.Add(_item(_uuid))
            Next
            Return _result.ToArray
        End Get
    End Property

    Public ReadOnly Property Item(UUID As String) As jp.polestar.model.pim.Address
        Get
            Return _item(UUID)
        End Get
    End Property

    Public Function add(address As Object) As Boolean Implements IPim.add
        Dim _address As jp.polestar.model.pim.Address = CType(address, jp.polestar.model.pim.Address)
        If Me.valid(_address) = True Then
            _item.Add(_address.UUID, _address)
        End If
        Return 0
    End Function

    Public Function modify(address As Object) As Boolean Implements IPim.modify
        Dim _address As jp.polestar.model.pim.Address = CType(address, jp.polestar.model.pim.Address)

        Return 0
    End Function

    Public Function remove(UUID As String) As Boolean Implements IPim.remove
        _item.Remove(UUID)
        Return True
    End Function

    Public Function valid(address As Object) As Boolean Implements IPim.valid
        Dim _address As jp.polestar.model.pim.Address = CType(address, jp.polestar.model.pim.Address)


        Return False
    End Function

    Public Function load() As Long Implements IPim.load
        Return 0
    End Function

    Public Function flash() As Long Implements IPim.flash
        Return 0
    End Function

End Class
