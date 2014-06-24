Imports System.Management.Automation.Runspaces
Imports System.Management.Automation
Imports System.Collections.ObjectModel

Public Class class_PS

    Public Class PwShell
        Dim runSpace As Runspace
        Dim pipeLine As Pipeline

        Sub New()
            ' runspace
            runSpace = RunspaceFactory.CreateRunspace()
            ' open it
            runSpace.Open()
        End Sub

        Function exec(ByVal cmd As String) As Collection(Of PSObject)
            pipeLine = runSpace.CreatePipeline()
            pipeLine.Commands.AddScript(cmd)
            Return pipeLine.Invoke
        End Function

        Sub close()
            runSpace.Close()
        End Sub
    End Class

End Class
