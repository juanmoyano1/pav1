Public Class Dispositivo
    Private _codDispositivo As Integer
    Public Property codDispositivo() As Integer
        Get
            Return _codDispositivo
        End Get
        Set(ByVal value As Integer)
            _codDispositivo = value
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

    Private _codTipo As Integer
    Public Property codTipo() As Integer
        Get
            Return _codTipo
        End Get
        Set(ByVal value As Integer)
            _codTipo = value
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

    Public Shared Function crearObjeto(ByVal codDispositivo As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal codTipo As Integer, ByVal baja As Boolean) As Dispositivo
        Dim dispositivo As New Dispositivo
        dispositivo.codDispositivo = codDispositivo
        dispositivo.nombre = nombre
        dispositivo.descripcion = descripcion
        dispositivo.codTipo = codTipo
        dispositivo.baja = baja
        Return dispositivo
    End Function



End Class
