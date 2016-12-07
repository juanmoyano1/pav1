Public Class Prioridad
    Private _codPrioridad As Integer
    Public Property codPrioridad() As Integer
        Get
            Return _codPrioridad
        End Get
        Set(ByVal value As Integer)
            _codPrioridad = value
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

    Private _color As String
    Public Property color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
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


End Class
