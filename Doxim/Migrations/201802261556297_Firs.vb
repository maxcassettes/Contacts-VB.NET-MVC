Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Firs
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Contacts", "FirstName", Function(c) c.String(nullable := False))
            AlterColumn("dbo.Contacts", "LastName", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Contacts", "LastName", Function(c) c.String())
            AlterColumn("dbo.Contacts", "FirstName", Function(c) c.String())
        End Sub
    End Class
End Namespace
