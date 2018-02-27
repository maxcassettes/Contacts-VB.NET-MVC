Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations


Namespace Models
    Public Class Contact

        Public Property Id As Integer
        <Required(ErrorMessage:="First Name is required")>
        <Display(Name:="First Name")>
        Public Property FirstName As String
        <Display(Name:="Last Name")>
        <Required(ErrorMessage:="Last Name is required")>
        Public Property LastName As String
        <Phone>
        Const pattern As String = "\d{3}-\d{3}-\d{4}"
        <RegularExpression(pattern)>
        <Display(Name:="Phone #")>
        Public Property PhoneNum As String
        <EmailAddress>
        Public Property Email As String

    End Class

    Public Class ContactsDBContext
        Inherits ApplicationDbContext

        Public Property Contacts As DbSet(Of Contact)

    End Class

End Namespace
