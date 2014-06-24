Imports System.DirectoryServices

Public Class form_Main

    Public LDAPAddr As String = "wprod.ds.aphp.fr"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Ldap As DirectoryEntry

        Try

            Ldap = New DirectoryEntry("LDAP://" & LDAPAddr, login_username.Text, login_password.Text)
            Dim Root As String = Ldap.Name
        Catch Ex As Exception
            Label5.Text = Ex.Message


        End Try
        Label6.Text = "Connexion OK"
        Label6.ForeColor = Color.Green
        'MsgBox(Ldap.Name)
    End Sub

End Class
