Public Class TipoDispositivo
    Private _codTipo As Integer
    Public Property codTipo() As Integer
        Get
            Return _codTipo
        End Get
        Set(ByVal value As Integer)
            _codTipo = value
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

    Public Shared Function crearTipoDispositivo(codTipo As Integer, descripcion As String, baja As Boolean) As TipoDispositivo
        Dim tipoDispositivo As New TipoDispositivo
        tipoDispositivo.codTipo = codTipo
        tipoDispositivo.descripcion = descripcion
        tipoDispositivo.baja = baja

        Return tipoDispositivo
    End Function

End Class
