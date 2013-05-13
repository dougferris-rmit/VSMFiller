Imports System.IO
Imports System.Web
Imports System.Object
Public Class frmAHK
    Private Class GlobalVariables
        Public Shared location As String
    End Class

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Function kill()
 
        Dim pkill As String = "taskkill /IM "
        Dim batpath As String = "c:\scratch\ahkkill.bat"
        Using batwriter As New StreamWriter(batpath)
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " and.exe "" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " ess.exe "" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " gapps.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " ipad.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " iph.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " mac.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " mydesktop.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " nds.exe"" /f")
            batwriter.WriteLine(pkill + """" + GlobalVariables.location + " win7.exe"" /f")
        End Using
        Return 0
    End Function

    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKill.Click
        Dim backuploc As String = GlobalVariables.location
        Dim batpath As String = "c:\scratch\ahkkill.bat"
        Using batwriter As New StreamWriter(batpath)
            batwriter.Write("@echo off" + Environment.NewLine)
        End Using

        GlobalVariables.location = "00803"
        kill()
        GlobalVariables.location = "brunswick"
        kill()
        GlobalVariables.location = "bundoora"
        kill()
        GlobalVariables.location = "sab"
        kill()
        GlobalVariables.location = "sd"
        kill()
        GlobalVariables.location = "swanston"
        kill()
        'Using batwriter As New StreamWriter(batpath)
        '   batwriter.WriteLine("exit")
        'End Using
        Dim p As New Process
        With p
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = False
            p.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            p.StartInfo.Arguments = "/k c:\scratch\ahkkill.bat"
        End With
        p.Start()
        GlobalVariables.location = backuploc
    End Sub

    Function makeAHKBat()
        Dim batlocation As String = "c:\scratch\ahk.bat"
        Dim cnwriter As New System.IO.StreamWriter(batlocation)
        cnwriter.Write("@echo on")
        cnwriter.WriteLine(" ")
        cnwriter.WriteLine("i: ")
        cnwriter.WriteLine("cd ""I:\NAP\Procedures\Helpdesk\Apps\Doug\vsmfillerresources\0-ahk\" + GlobalVariables.location + "")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " and.exe""" + " " + """" + GlobalVariables.location + " and.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " ess.exe""" + " " + """" + GlobalVariables.location + " ess.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " gapps.exe""" + " " + """" + GlobalVariables.location + " gapps.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " iPad.exe""" + " " + """" + GlobalVariables.location + " iPad.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " iph.exe""" + " " + """" + GlobalVariables.location + " iph.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " mac.exe""" + " " + """" + GlobalVariables.location + " mac.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " win7.exe""" + " " + """" + GlobalVariables.location + " win7.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " nds.exe""" + " " + """" + GlobalVariables.location + " nds.exe""")
        cnwriter.WriteLine("start " + """" + GlobalVariables.location + " mydesktop.exe""" + " " + """" + GlobalVariables.location + " mydesktop.exe""")
        cnwriter.WriteLine("exit")
        cnwriter.Close()
        Dim p As New Process
        With p
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = False
            .StartInfo.FileName = "c:\windows\system32\cmd.exe"
            .StartInfo.Arguments = "/k " + batlocation
        End With
        p.Start()
        Return 0
    End Function

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
       If lbLoc.SelectedItem = "Service Desk" Then
            GlobalVariables.location = "sd"
            makeAHKBat()
        ElseIf lbLoc.SelectedItem = "Swanston Library" Then
            GlobalVariables.location = "swanston"
            makeAHKBat()
        ElseIf lbLoc.SelectedItem = "Brunswick Library" Then
            GlobalVariables.location = "brunswick"
            makeAHKBat()
        ElseIf lbLoc.SelectedItem = "Bundoora Library" Then
            GlobalVariables.location = "bundoora"
            makeAHKBat()
        Else
            MsgBox("Please select a location")
        End If

    End Sub

    Private Sub ahkReadMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ahkReadMe.Click
        Process.Start("I:\NAP\Procedures\Helpdesk\Apps\Doug\vsmfillerresources\0-ahk\README.txt")
    End Sub
End Class