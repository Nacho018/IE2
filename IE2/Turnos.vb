Public Class Turnos


    Dim Id_ As Integer

    Dim Fecha_ As Date
    Dim Asign_, Doc_, Vocal1_, Vocal2_ As String

    Public Property Id() As Integer
        Get

            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property Fecha() As Date
        Get

            Return Fecha_

        End Get
        Set(ByVal value As Date)

            Fecha_ = value

        End Set
    End Property


    Public Property Asign() As String
        Get

            Return Asign_

        End Get
        Set(ByVal value As String)

            Asign_ = value

        End Set
    End Property
    Public Property Doc() As String
        Get

            Return Doc_

        End Get
        Set(ByVal value As String)

            Doc_ = value

        End Set
    End Property
    Public Property Vocal1() As String
        Get

            Return Vocal1_

        End Get
        Set(ByVal value As String)

            Vocal1_ = value

        End Set
    End Property
    Public Property Vocal2() As String
        Get

            Return Vocal2_

        End Get
        Set(ByVal value As String)

            Vocal2_ = value

        End Set
    End Property

End Class
