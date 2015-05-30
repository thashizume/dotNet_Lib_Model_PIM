Public Class Addresses

    Private _addresses As System.Collections.Generic.Dictionary(Of String, Address)

    Public ReadOnly Property Item(index As Long) As jp.polestar.model.pim.Address()
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Item(internalCode As String) As jp.polestar.model.pim.Address()
        Get
            Return Nothing
        End Get
    End Property

    Public Function add(address As jp.polestar.model.pim.Address) As Long
        If Me.validate(address) = True Then

        End If
        Return 0
    End Function

    Public Function modify(address As jp.polestar.model.pim.Address) As Long
        Return 0
    End Function

    Public Function remove(address As jp.polestar.model.pim.Address) As Long
        Return 0
    End Function

    Public Function validate(address As jp.polestar.model.pim.Address) As Boolean

        Return False
    End Function

    Public Function load() As Long
        Return 0
    End Function

    Public Function flash() As Long
        Return 0
    End Function


End Class
