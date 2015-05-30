Public Interface IPim

    Function add(o As Object) As Boolean
    Function modify(o As Object) As Boolean
    Function remove(s As String) As Boolean

    Function valid(o As Object) As Boolean

    Function load() As Long
    Function flash() As Long

End Interface

