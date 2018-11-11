Public Class AddressBook


    'Member Variables 
    Private strName As String 'hold name
    Private strEmail As String 'hold emal address
    Private strPhone As String 'hold phone number
    Private strComment As String 'hold comment

    'constructor
    Public Sub NewAddress()
        Debug.WriteLine("AddressBook object being created")
        strName = "(unknown)"
        strEmail = "(unknown)"
        strPhone = "(unknown)"
        strComment = "(unknown)"
    End Sub

    'Name property procedure
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    'Email address property Procedure
    Public Property EmailAddress() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    ' phone number property procedure 
    Public Property PhoneNumber() As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property

    'Comment property procedure
    Public Property Notes() As String
        Get
            Return strComment
        End Get
        Set(ByVal value As String)
            strComment = value
        End Set
    End Property



End Class
