Public Class MetronomeRule

    Public Sub New(ByVal index As Integer, ByVal name As String, ByVal tempo As Integer, ByVal timeSignature As String, ByVal duration As Integer)

        Me._index = index
        Me._name = name
        Me._tempo = tempo
        Me._timeSignature = timeSignature
        Me._duration = duration

    End Sub

    Public _index As Integer
    Public _name As String
    Public _tempo As Integer
    Public _timeSignature As String
    Public _duration As Integer


End Class
