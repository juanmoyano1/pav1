Public Class Area

    Private _codArea As Integer
    Public Property codArea() As Integer
        Get
            Return _codArea
        End Get
        Set(ByVal value As Integer)
            _codArea = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _baja As Boolean
    Public Property baja() As Boolean
        Get
            Return _baja
        End Get
        Set(ByVal value As Boolean)
            _baja = value
        End Set
    End Property

    Public Shared Function crearObjeto(ByVal codArea As Integer, ByVal nombre As String, ByVal baja As Boolean) As Area
        Dim area As New Area
        area.codArea = codArea
        area.nombre = nombre
        area.baja = baja
        Return area
    End Function

End Class
