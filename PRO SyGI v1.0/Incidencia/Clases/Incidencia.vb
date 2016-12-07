Public Class Incidencia

    Private _codIncidencia As Integer
    Public Property codIncidencia() As Integer
        Get
            Return _codIncidencia
        End Get
        Set(ByVal value As Integer)
            _codIncidencia = value
        End Set
    End Property

    Private _usuarioFinal As String
    Public Property usuarioFinal() As String
        Get
            Return _usuarioFinal
        End Get
        Set(ByVal value As String)
            _usuarioFinal = value
        End Set
    End Property

    Private _usuarioSupervisor As String
    Public Property usuarioSupervisor() As String
        Get
            Return _usuarioSupervisor
        End Get
        Set(ByVal value As String)
            _usuarioSupervisor = value
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

    Private _fechaCarga As Date
    Public Property fechaCarga() As Date
        Get
            Return _fechaCarga
        End Get
        Set(ByVal value As Date)
            _fechaCarga = value
        End Set
    End Property

    Private _fecahCierre As Date
    Public Property fechaCierre() As Date
        Get
            Return _fecahCierre
        End Get
        Set(ByVal value As Date)
            _fecahCierre = value
        End Set
    End Property

    Private _area As String
    Public Property area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
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

    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Private _prioridad As String
    Public Property prioridad() As String
        Get
            Return _prioridad
        End Get
        Set(ByVal value As String)
            _prioridad = value
        End Set
    End Property

    Private _dispositivo As String
    Public Property dispositivo() As String
        Get
            Return _dispositivo
        End Get
        Set(ByVal value As String)
            _dispositivo = value
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
