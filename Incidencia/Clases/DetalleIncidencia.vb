Public Class DetalleIncidencia

    Private _nroOrden As Integer
    Public Property nroOrden() As Integer
        Get
            Return _nroOrden
        End Get
        Set(ByVal value As Integer)
            _nroOrden = value
        End Set
    End Property

    Private _incidencia As Integer
    Public Property incidencia() As Integer
        Get
            Return _incidencia
        End Get
        Set(ByVal value As Integer)
            _incidencia = value
        End Set
    End Property

    Private _fechaAtencion As Date
    Public Property fechaAtencion() As Date
        Get
            Return _fechaAtencion
        End Get
        Set(ByVal value As Date)
            _fechaAtencion = value
        End Set
    End Property

    Private _duracion As Integer
    Public Property duracion() As Integer
        Get
            Return _duracion
        End Get
        Set(ByVal value As Integer)
            _duracion = value
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

    Private _titulo As String
    Public Property titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    Public Property fechaCierre As Date

End Class
