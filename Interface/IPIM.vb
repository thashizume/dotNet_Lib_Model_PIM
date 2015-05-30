Public Interface IPim

    Function Item(index As Long)
    Function Item(key As String)
    Function add(o As Object) As Object()
    Function modify(o As Object) As Object()
    Function remove(o As Object) As Object()
    Function load(o As Object) As Object
    Function flash(o As Object) As Object

End Interface

