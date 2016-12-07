Public Class Estado

    Private _codEstado As Integer
    Public Property codEstado() As Integer
        Get
            Return codEstado
        End Get
        Set(ByVal value As Integer)
            _codEstado = value
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

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
