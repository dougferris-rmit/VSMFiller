Imports System.IO
Imports System.Web
Imports System.Object
Public Class Form1

    Public Class GlobalVariables
        Public Shared DefaultBrowserExe As String = "chrome.exe"
        Public Shared path As String = "I:\NAP\Procedures\Helpdesk\Apps\Doug\vsmfillerresources"
        Public Shared Officername As String
        Public Shared userid_withoutesx As String
        Public Shared google_url As String
        Public Shared cn As String
        Public Shared iexplore As String
    End Class

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)


        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next

        Return False

    End Function


    Private Function validateuserid()
        GlobalVariables.userid_withoutesx = userid_input.Text
        If userid_input.Text = "" Then
            If GlobalVariables.cn = "" Then
                MsgBox("Please enter userid")
            End If
        Else
            If lbuserid.Text.ToString = "E" Then
                userid_input.MaxLength = 5
                GlobalVariables.cn = "E" + GlobalVariables.userid_withoutesx
                iexplore_button.Enabled = False
                GlobalVariables.google_url = "https://www.google.com/a/cpanel/rmit.edu.au/CPanelHome# Search/filter=ALL&query=" + GlobalVariables.cn
            ElseIf lbuserid.Text = "S" Then
                userid_input.MaxLength = 8
                GlobalVariables.iexplore = GlobalVariables.userid_withoutesx
                If CheckForAlphaCharacters(GlobalVariables.iexplore) Then
                    GlobalVariables.cn = lbuserid.Text + GlobalVariables.iexplore.Substring(0, 7)
                Else
                    GlobalVariables.cn = lbuserid.Text + GlobalVariables.iexplore
                End If
                iexplore_button.Enabled = True
                GlobalVariables.google_url = "https://www.google.com/a/cpanel/rmit.edu.au/Organization?userEmail=" + GlobalVariables.cn + "@student.rmit.edu.au"
            ElseIf lbuserid.Text = "X" Then
                userid_input.MaxLength = 5
                GlobalVariables.cn = "X" + GlobalVariables.userid_withoutesx
                iexplore_button.Enabled = False
                GlobalVariables.google_url = "https://www.google.com/a/cpanel/rmit.edu.au/CPanelHome#Search/filter=ALL&query=" + GlobalVariables.cn
            End If
        End If
        Return 0
    End Function

    ' Setup
    Private Sub cbBrowser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBrowser.SelectedIndexChanged
        If cbBrowser.Text = "Google Chrome" Then
            GlobalVariables.DefaultBrowserExe = "chrome.exe"
        ElseIf cbBrowser.Text = "Mozilla Firefox" Then
            GlobalVariables.DefaultBrowserExe = "firefox.exe"
        ElseIf cbBrowser.Text = "Opera" Then
            GlobalVariables.DefaultBrowserExe = "opera.exe"
        ElseIf cbBrowser.Text = "Internet Explorer" Then
            GlobalVariables.DefaultBrowserExe = "iexplore.exe"
        End If
    End Sub

    Private Sub tbOfficerName_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbOfficerName.TextChanged
        GlobalVariables.Officername = tbOfficerName.Text
    End Sub

    Dim EmailHeader As String
     'Start Bookmarks
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://learninghub.rmit.edu.au")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://iexplore.rmit.edu.au/IExplore/staffs/FirstPage.aspx")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://www.google.com/a/rmit.edu.au/ServiceLogin?service=CPanel&passive=1209600&cpbps=1&continue=https://www.google.com/a/cpanel/rmit.edu.au/Dashboard&followup=https://www.google.com/a/cpanel/rmit.edu.au/Dashboard")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "http://propertycentral.gm.rmit.edu.au/customDefault/home/")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Process.Start("explorer.exe", "I:/NAP/public/NAP-Support-Areas/")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start("iexplore.exe", "https://servicemanager.rmit.edu.au/VSM/ServiceManager.aspx")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://docs.google.com/a/rmit.edu.au/document/d/1KdXpnfDQcVb1xPrdfU3uRmaQshROfE5IRr-pRXJGQ1o/")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://sams.rmit.edu.au/psp/ps/EMPLOYEE/HRMS/h/?tab=DEFAULT")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://itstpmcsprov01.rmit.edu.au/prov/")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "http://callpilot.rmit.edu.au/cpmgr/login.asp")
    End Sub
    

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start("explorer.exe", "I:\NAP\Procedures\Helpdesk\Job Log templates 2011")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://docs.google.com/a/rmit.edu.au/spreadsheet/ccc?key=0AsngNHqytUu5dE1DdFBQR010SlZWWmpiNjltTnkwVFE#gid=0")
    End Sub
    Private Sub btnNovell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovell.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://imanager.rmit.edu.au/nps/servlet/webacc?taskId=fw.Startup")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Process.Start(GlobalVariables.DefaultBrowserExe, "http://pcutprdap01.rmit.internal:9191/app")
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Process.Start("dsa.msc", "/domain=rmit.internal")
    End Sub
    Private Sub btnDeploy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeploy.Click
        Process.Start("C:\Program Files\RMIT\ServiceDeskTools\Software Distribution.msc")
    End Sub
    Private Sub btnToolkit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToolkit.Click
        Process.Start("C:\Program Files\RMIT\ServiceDeskTools\RMIT UNIVERSITY IT SERVICE DESK TOOLKIT.msc")
    End Sub
    'End Bookmarks

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub



    'Email Templates
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim emailtemplate As String
        emailtemplate = ""
        Dim header As String
        Dim footer As String
        header = "Hi " + cbEmailCustomer.Text + "," + Environment.NewLine + Environment.NewLine
        footer = Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + GlobalVariables.Officername
        If cbCall.Checked = "False" Then
            If cbEmailTemplate.Text = "STS Down July 2012" Then emailtemplate = header + "There are currently a large number of students using the Student Timetable Service (STS). Please note that this peak usage may result in unavoidable delays. We recognise that your email relating to this matter is critical and will respond to you within 24 hours." + Environment.NewLine + Environment.NewLine + "If you are experiencing any difficulty with STS please close your browser and try again. Please do not refresh your browser." + footer
            If cbEmailTemplate.Text = "More Information reqeust" Then emailtemplate = header + "Please provide us with the following information so we can send out a technician to assist you." + Environment.NewLine + Environment.NewLine + "- Your location (building,level,room)" + Environment.NewLine + "- The lease asset number of the computer. (Red Barcode Sticker number)" + Environment.NewLine + "- Your contact number" + footer
            If cbEmailTemplate.Text = "Gmail - Android" Then emailtemplate = header + "For information regarding how to configure your Android device for use on the RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mail/bin/topic.py?hl=en&topic=2451697&parent=2451730&ctx=topic" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - iOS" Then emailtemplate = header + "For information regarding how to configure your iOS device for RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mobile/bin/answer.py?hl=en&answer=138740" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - Blackberry" Then emailtemplate = header + "For information regarding how to configure your Blackberry device for use on the RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mail/bin/answer.py?hl=en&answer=175692&topic=21368&ctx=topic" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - Calendar sharing" Then emailtemplate = header + "For information regarding how to setup your calendar for sharing, please see the following link" + Environment.NewLine + "http://support.google.com/calendar/bin/answer.py?hl=en&answer=143754." + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            My.Computer.Clipboard.SetText(emailtemplate)
            cbEmailCustomer.Text = ""
            cbEmailTemplate.Text = ""
            MsgBox("Copied template to clipboard and cleared form")
        Else
            Dim TriedToCall As String = "I tried to call you but was unable to reach you." + Environment.NewLine + Environment.NewLine
            If cbEmailTemplate.Text = "STS Down July 2012" Then emailtemplate = header + TriedToCall + "There are currently a large number of students using the Student Timetable Service (STS). Please note that this peak usage may result in unavoidable delays. We recognise that your email relating to this matter is critical and will respond to you within 24 hours." + Environment.NewLine + Environment.NewLine + "If you are experiencing any difficulty with STS please close your browser and try again. Please do not refresh your browser." + footer
            If cbEmailTemplate.Text = "More Information reqeust" Then emailtemplate = header + TriedToCall + "Please provide us with the following information so we can send out a technician to assist you." + Environment.NewLine + Environment.NewLine + "- Your location (building,level,room)" + Environment.NewLine + "- The lease asset number of the computer. (Red Barcode Sticker number)" + Environment.NewLine + "- Your contact number" + footer
            If cbEmailTemplate.Text = "Gmail - Android" Then emailtemplate = header + TriedToCall + "For information regarding how to configure your Android device for use on the RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mail/bin/topic.py?hl=en&topic=2451697&parent=2451730&ctx=topic" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - iOS" Then emailtemplate = header + TriedToCall + "For information regarding how to configure your iOS device for RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mobile/bin/answer.py?hl=en&answer=138740" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - Blackberry" Then emailtemplate = header + TriedToCall + "For information regarding how to configure your Blackberry device for use on the RMIT Gmail, please see the following link" + Environment.NewLine + "http://support.google.com/mail/bin/answer.py?hl=en&answer=175692&topic=21368&ctx=topic" + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            If cbEmailTemplate.Text = "Gmail - Calendar sharing" Then emailtemplate = header + TriedToCall + "For information regarding how to setup your calendar for sharing, please see the following link" + Environment.NewLine + "http://support.google.com/calendar/bin/answer.py?hl=en&answer=143754." + Environment.NewLine + "If you require any further assistance, please call the IT Service Desk on (03) 9925 8888 or email us on itservicedesk@rmit.edu.au so that we can assist you further" + footer
            My.Computer.Clipboard.SetText(emailtemplate)
            cbEmailCustomer.Text = ""
            cbEmailTemplate.Text = ""
            cbCall.Checked = "false"
            MsgBox("Copied template to clipboard and cleared form")
        End If
    End Sub

    Private Sub iexplore_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iexplore_button.Click
        validateuserid()
        Dim iexplore_url As String = "https://iexplore.rmit.edu.au/IExplore/staffs/StudentDetails.aspx?StudentId=" + GlobalVariables.iexplore
        Process.Start(GlobalVariables.DefaultBrowserExe, iexplore_url)
    End Sub

    Private Sub Google_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Google_Button.Click
        validateuserid()
        Process.Start(GlobalVariables.DefaultBrowserExe, GlobalVariables.google_url)
    End Sub

    Private Sub ontopBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ontopBtn.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            ontopBtn.Text = "Currently on bottom"
        ElseIf Me.TopMost = False Then
            Me.TopMost = True
            ontopBtn.Text = "Currently on top"
        End If
    End Sub

    Private bigcharsets() As String = {"abcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZ"}
    Private smallcharsets() As String = {"0123456789", "~!@#$%*_+-.,"}

    Private Sub Password_gen_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Password_gen.MouseDoubleClick

        Password_gen.ForeColor = SystemColors.WindowText
        Dim r As New System.Security.Cryptography.RNGCryptoServiceProvider()

        Dim randomNumbers(200) As Byte
        r.GetBytes(randomNumbers)

        Dim charcount As Integer = 10

        Dim output As String = ""

        For i As Integer = 0 To charcount - 1
            Dim c As Char = " "
            Dim charType As Integer = randomNumbers(i) Mod 2
            Dim currentSet As String = bigcharsets(charType)

            c = currentSet.Chars(randomNumbers(i + 1 + charcount) Mod currentSet.Length)

            output = output + c
        Next

        Dim charToReplace As Integer = randomNumbers((2 + (charcount * 2))) Mod (charcount - 1)
        Dim replaceCharType As Integer = randomNumbers(3 + (charcount * 2)) Mod 2
        output = output.Insert(charToReplace, smallcharsets(replaceCharType).Chars(randomNumbers(4 + (charcount * 2)) Mod smallcharsets(replaceCharType).Length))
        If (output.Length >= charcount) Then
            output = output.Substring(0, charcount)
        End If


        Password_gen.Text = output
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim emailtemplate As String
        emailtemplate = ""
        Dim header As String
        Dim footer As String
        Dim requestforoffshoreid As String
        Dim requestforonshoreid As String
        Dim onshoregooglestudent As String
        Dim internationalpassword As String
        Dim passwordcriteria As String
        Dim initialpassword As String
        Dim onshoregraceloginsreset As String
        Dim internationalgraceloginrest As String
        '     Dim internationalinitialpassword As String

        header = "Hi " + tbStudentName.Text + "," + Environment.NewLine + Environment.NewLine
        footer = Environment.NewLine + Environment.NewLine + "Kind regards," + Environment.NewLine + GlobalVariables.Officername
        requestforoffshoreid = "- Student/Employee ID" + Environment.NewLine + "- Your Full Name" + Environment.NewLine + "- Your Date of Birth " + Environment.NewLine + "- Current residential address as registered with RMIT" + Environment.NewLine + "- What are you trying to login to. " + Environment.NewLine + Environment.NewLine + "Alternatively, you can phone the IT Service Desk on +613 9925 8888  and give us the details, once we receive these details we will give you a temporary password"
        requestforonshoreid = "However, for us to do this we will need to ask you some security questions to confirm your identity." + Environment.NewLine + "Please contact the IT Service Desk on (03) 9925-8888 so that we can proceed with the password reset."
        internationalpassword = "I have set your temporary password as " + Password_gen.Text + Environment.NewLine + "You have a limited number of logins to allow you time to change your password. " + Environment.NewLine + "Please follow the steps below to set your 180 day password at the link provided." + Environment.NewLine + Environment.NewLine + "From the following link (http://www.rmit.edu.au/its/password) do the following: " + Environment.NewLine + Environment.NewLine + "- Select 'Change your password'" + Environment.NewLine + "- Select Change your password (under 'How to change your password' section)" + Environment.NewLine + "- Enter your 's' if your a student followed by your student ID; or 'e' followed by your staff ID" + Environment.NewLine + "- Enter your current password. Press Logon." + Environment.NewLine + Environment.NewLine + "Once you have successfully logged in enter the temporary password in the old password field (the password you have just used to login)."
        passwordcriteria = "Password criteria" + Environment.NewLine + Environment.NewLine + "Your password should conform to the following criteria:" + Environment.NewLine + Environment.NewLine + "    Passwords cannot contain the user's account name or parts of the user's full name that exceed two consecutive characters" + Environment.NewLine + "    Passwords must be at least eight characters in length" + Environment.NewLine + "    Passwords must contain characters from three of the following four categories:" + Environment.NewLine + "        English uppercase characters (A through Z)." + Environment.NewLine + "        English lowercase characters (a through z)." + Environment.NewLine + "        Numeral digits (0 through 9)." + Environment.NewLine + "        Non-alphabetic characters: ~!@#$%^*_-+=`|\(){}[]:;<>,./ (with the exception of & and/or ? which are not supported by some systems)" + Environment.NewLine + "        Cannot be one of your previous 15 passwords" + Environment.NewLine + Environment.NewLine + "Please refer to the ITS Password Security Policy for more detail." + Environment.NewLine + Environment.NewLine + "Then set a Challenge question." + Environment.NewLine + Environment.NewLine + "That should renew your password."
        initialpassword = "Please be advised that your username is " + " and the default password is pYYYYMMDD! where YYYY is four digits for the year you were born, MM is two digits for the month, DD is two digits for the day, so if you were born on the 12th of November 1985, your password would be p19851112!" + Environment.NewLine + Environment.NewLine + "If you cannot log in using this password format, we will need to set a temporary password for you." + "However, for us to do this we will need to ask you some security questions to confirm your identity." + "Please contact the IT Service Desk on (03) 9925-8888 so that we can proceed with the password reset."
        onshoregooglestudent = "Please see http://www.rmit.edu.au/students/services/email  for information regarding logging into Gmail for the first time." + Environment.NewLine + Environment.NewLine + "If you cannot sign on using the default password, please call the IT Service Desk on (03) 9925 8888 so that we can verbally verify your identity and help set a new password for you."
        onshoregraceloginsreset = "Your password has expired. I have reset the number of grace logins that you have. If you remember your old password, please follow the steps below to change your password at the link provided." + Environment.NewLine + Environment.NewLine + "- Select ""Change your password""" + Environment.NewLine + "- Enter your 's' if your a student followed by your - student ID; or 'e' followed by your staff ID" + Environment.NewLine + "- Enter your current password. Press Logon." + Environment.NewLine + Environment.NewLine + "Once you have successfully logged in enter the temporary password in the old password field (the password you have just used to login)." + Environment.NewLine + Environment.NewLine + passwordcriteria
        internationalgraceloginrest = "Your password has expired. I have reset the number of grace logins that you have. If you remember your old password, please follow the steps below to change your password at the link provided." + Environment.NewLine + Environment.NewLine + "- Select ""Change your password""" + Environment.NewLine + "- Enter your 's' if your a student followed by your - student ID; or 'e' followed by your staff ID" + Environment.NewLine + "- Enter your current password. Press Logon." + Environment.NewLine + Environment.NewLine + "Once you have successfully logged in enter the temporary password in the old password field (the password you have just used to login)." + Environment.NewLine + Environment.NewLine + passwordcriteria + Environment.NewLine + Environment.NewLine + "If you cannot remember your password we will have to reset your password for you, however to do that we will have to verify your identity" + Environment.NewLine + "Please send us an e-mail containing the following details:" + Environment.NewLine + requestforoffshoreid

        If tbPasswordType.Text = "On Shore Grace Login Reset" Then emailtemplate = header + onshoregraceloginsreset + footer
        If tbPasswordType.Text = "International Grace Login Reset" Then emailtemplate = header + internationalgraceloginrest + footer
        If tbPasswordType.Text = "International request for details" Then emailtemplate = header + "We will need to set a temporary password for you." + Environment.NewLine + Environment.NewLine + "Please send us an e-mail containing the following details:" + Environment.NewLine + Environment.NewLine + requestforoffshoreid + footer
        If tbPasswordType.Text = "International Password Reset Grace Logins" Then emailtemplate = header


        If tbPasswordType.Text = "International Password Reset" Then emailtemplate = header + internationalpassword + Environment.NewLine + Environment.NewLine + passwordcriteria + footer
        '      If tbPassword.TabIndex = "International initial NDS login" Then
        If tbPasswordType.Text = "On shore request for details" Then emailtemplate = header + "We will need to set a temporary password for you." + Environment.NewLine + requestforonshoreid + footer
        If tbPasswordType.Text = "On shore initial NDS login" Then emailtemplate = header + initialpassword + footer
        If tbPasswordType.Text = "On shore unlock account" Then emailtemplate = header + "You were unable to login as your account was locked." + Environment.NewLine + "I have unlocked your account; so you should be able to login now using your existing password." + Environment.NewLine + Environment.NewLine + "If you have forgotten your password we will need to set a temporary password for you." + Environment.NewLine + "For us to do this we will need to ask you some verbal security questions to confirm your identity." + Environment.NewLine + "Please contact the IT Service Desk on (03) 9925-8888 so that we can proceed with the password reset." + footer
        If tbPasswordType.Text = "On shore initial Gmail login" Then emailtemplate = header + onshoregooglestudent + footer
        If emailtemplate = "" Then
            MsgBox("Don't use a blank template")
        Else
            My.Computer.Clipboard.SetText(emailtemplate)
        End If

    End Sub

    Private Function ADUNlockBat()
        Dim batpath As String = "c:\scratch\adunlock.bat"
        Using batwriter As New StreamWriter(batpath)
            batwriter.Write("@echo off" + Environment.NewLine)
            batwriter.WriteLine(GlobalVariables.path + "\adsetrest.exe " + GlobalVariables.cn + " al = no" + Environment.NewLine + "echo Unlocked" + Environment.NewLine + "pause" + Environment.NewLine + "exit")
            batwriter.Close()
        End Using

        Dim p As New Process
        With p
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = False
            p.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            p.StartInfo.Arguments = "/k " + batpath
        End With
        p.Start()
        Return 0
    End Function

    Private Function ADReset()
        Dim batpath2 As String = "c:\scratch\adreset.bat"
        Using batwriter As New StreamWriter(batpath2)
            batwriter.Write("@echo off" + Environment.NewLine)
            batwriter.WriteLine(GlobalVariables.path + "\adsetrest.exe " + GlobalVariables.cn + " al = no" + Environment.NewLine + "echo Unlocked" + Environment.NewLine)
            batwriter.WriteLine(GlobalVariables.path + "\adsetpwd.exe " + GlobalVariables.cn + " " + Password_gen.Text + Environment.NewLine + "echo Password reset to " + Password_gen.Text + Environment.NewLine + Environment.NewLine + "pause" + Environment.NewLine + "exit")
            batwriter.Close()
        End Using
        Dim p As New Process
        With p
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = False
            p.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            p.StartInfo.Arguments = "/k " + batpath2
        End With
        p.Start()
        Return 0
    End Function

    Private Sub btnADUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADUnlock.Click
        validateuserid()
        If userid_input.Text = "" Then
            MsgBox("Please enter user id")
        Else
            ADUNlockBat()
            GlobalVariables.cn = lbuserid.Text + userid_input.Text
            cbPreviousCustomers.Items.Add(GlobalVariables.cn + " , " + "Unlocked")
            cbPreviousCustomers.Text = GlobalVariables.cn + " , " + "Unlocked"
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        validateuserid()
        If userid_input.Text = "" Then
            MsgBox("Please enter userID")
        ElseIf Password_gen.Text = "Double click to generate password" Then
            MsgBox("Please generate password")
        Else
            If Password_gen.Text = "Double click to generate password" Then
                MsgBox("Unlocked, but password not changed, please generate new password.")
            Else
                ADReset()
                GlobalVariables.cn = lbuserid.Text + userid_input.Text
                cbPreviousCustomers.Items.Add(GlobalVariables.cn + " , " + Password_gen.Text)
                cbPreviousCustomers.Text = GlobalVariables.cn + " , " + Password_gen.Text
                tbStudentName.Text = ""
                userid_input.Text = ""
                tbPasswordType.Text = ""
            End If
        End If
    End Sub




    'Test login
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestLogin.Click
        Process.Start("chrome", "--incognito http://my.rmit.edu.au")
    End Sub
    '
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIManagerUser.Click
        validateuserid()
        If userid_input.Text = "" Then
            If GlobalVariables.cn = "" Then
                MsgBox("Please enter username")
            Else
                My.Computer.Clipboard.SetText(GlobalVariables.cn + ".rmit")
            End If
        Else
            validateuserid()
            My.Computer.Clipboard.SetText(GlobalVariables.cn + ".rmit")
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVSMUser.Click
        If userid_input.Text = "" Then
            If GlobalVariables.cn = "" Then
                MsgBox("Please enter username")
            Else
                My.Computer.Clipboard.SetText(GlobalVariables.cn)
            End If
        Else
            validateuserid()
            My.Computer.Clipboard.SetText(GlobalVariables.cn)
        End If
    End Sub

    'Knowledge base search and dropdown
    Private Sub btnKnowledgeBaseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnowledgeBaseSearch.Click
        Dim searchterm As String = tbKnowledgeBaseSearchInput.Text
        Dim urlsearch As String
        If searchterm.Contains(" ") Then
            urlsearch = searchterm.Replace(" ", "+")
        Else
            urlsearch = searchterm
        End If
        Process.Start(GlobalVariables.DefaultBrowserExe, "https://sites.google.com/a/rmit.edu.au/knowledge-management/system/app/pages/search?scope=search-site&q=" + urlsearch)
    End Sub

    Private Sub btnKnowledgeBaseService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnowledgeBaseService.Click
        Dim KnowledgeBaseURL As String = ""
        If cbKnowledgeBaseDropdown.Text = "Blackboard" Then KnowledgeBaseURL = "https://sites.google.com/a/rmit.edu.au/knowledge-management/applications/gold-applications/blackboard"
        If cbKnowledgeBaseDropdown.Text = "ESS" Then KnowledgeBaseURL = "https://sites.google.com/a/rmit.edu.au/knowledge-management/applications/silver-applications/ess"
        If cbKnowledgeBaseDropdown.Text = "MyPerformance MyCareer" Then KnowledgeBaseURL = "https://sites.google.com/a/rmit.edu.au/knowledge-management/applications/silver-applications/myperformance-mycareer"
        Process.Start(GlobalVariables.DefaultBrowserExe, KnowledgeBaseURL)
    End Sub

    'Validation of inputs
    Private Sub btnValidateInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        validateuserid()
    End Sub

    Private Sub lbuserid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbuserid.SelectedIndexChanged
        validateuserid()
    End Sub

    Private Sub btnCopySelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopySelected.Click
        My.Computer.Clipboard.SetText(cbPreviousCustomers.Text)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        validateuserid()
        getquestions()
    End Sub
    Private Sub adgetrest_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adgetrest_btn.Click
        validateuserid()
        Dim batlocation As String = "c:\scratch\adgetrest.bat"
        Dim cnwriter As New System.IO.StreamWriter(batlocation)
        cnwriter.Write("@echo off" + Environment.NewLine + GlobalVariables.path + "\adgetrest.exe " + GlobalVariables.cn + Environment.NewLine + "pause" + Environment.NewLine + "exit")
        cnwriter.Close()
        ' Process.Start(batlocation)
        Dim p As New Process
        With p
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = False
            .StartInfo.FileName = "c:\windows\system32\cmd.exe"
            .StartInfo.Arguments = "/k " + batlocation
        End With
        p.Start()
    End Sub

    Private Function getquestions()
        Dim batlocation As String = "c:\scratch\vsmfillerldapquery.bat"
        Dim cnwriter As New System.IO.StreamWriter(batlocation)
        cnwriter.Write("@echo off" + Environment.NewLine + GlobalVariables.path + "\ldapsearch.exe -v -b ""o=rmit"" -h 131.170.18.64 ""cn=" + GlobalVariables.cn + """ cn sasLoginSecret fullname" + Environment.NewLine + "pause" + Environment.NewLine + "exit")
        cnwriter.Close()
        ' Process.Start(batlocation)
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

    Private Sub lbuserid_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbuserid.SelectedValueChanged
        validateuserid()
    End Sub

    Private Sub PasswdForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswdForm.Click

    End Sub


    Private Function sccmcheck()

        If sccmsearch_tb.Text = "" Then
            MsgBox("Please enter search criteria")
        ElseIf sccmsearch_tb.Text.Substring(0, 1) = "w" Then
            sccmworkstation()
        ElseIf sccmsearch_tb.Text.Substring(0, 1) = "W" Then
            sccmworkstation()
        Else
            sccmuser()
        End If
        Return 0
    End Function

    Private Function sccmworkstation()
        Dim sccm As New Process
        With sccm
            .StartInfo.FileName = "C:\Program Files\Internet Explorer\iexplore.exe"
            .StartInfo.Arguments = "http://sccmprdss01.rmit.internal/SMSReporting_P01/MachDetails.asp"
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = False
        End With
        sccm.Start()
        Return 0
    End Function

    Private Function sccmuser()
        Process.Start(GlobalVariables.DefaultBrowserExe, "http://sccmprdss01.rmit.internal/SMSReporting_P01/Report.asp?ReportID=12&variable=" + sccmsearch_tb.Text)
        Return 0
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sccmcheck()
    End Sub

    Private Sub btnAutoComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoComplete.Click
        frmAHK.Show()
    End Sub

    Private Sub btnRemoteConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoteConnect.Click
        Dim hostname As String = tbHostName.Text
        Dim batlocation As String = "c:\scratch\remoteconnect.bat"
        Dim cnwriter As New System.IO.StreamWriter(batlocation)
        Dim remoteconnect As New Process
        With remoteconnect
            .StartInfo.FileName = "cmd.exe"
            .StartInfo.Arguments = "/k " + batlocation
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = False
        End With
        If hostname = "" Then
            MsgBox("Please enter hostname")
        Else
            If hostname.Substring(0, 3) = "131" Then
                hostname = hostname
                MsgBox("Please use hostname rather than IP." + Environment.NewLine + "If you don't know how, open cmd and run the following command:" + Environment.NewLine + "nslookup " + hostname)
            ElseIf hostname.Substring(0, 1) = "w" Then
                hostname = hostname
                cnwriter.Write("@echo off" + Environment.NewLine + "SET mgruser=mgr-%USERNAME%" + Environment.NewLine + "runas /savecred /user:rmit\%mgruser% ""C:\Program Files (x86)\Microsoft\ConfigurationManager2007RemoteControl\RC.exe 1 " + hostname + Environment.NewLine + "exit")
                cnwriter.Close()
                remoteconnect.Start()
            Else
                hostname = "w" + hostname
                cnwriter.Write("@echo off" + Environment.NewLine + "SET mgruser=mgr-%USERNAME%" + Environment.NewLine + "runas /savecred /user:rmit\%mgruser% ""C:\Program Files (x86)\Microsoft\ConfigurationManager2007RemoteControl\RC.exe 1 " + hostname + Environment.NewLine + "exit")
                cnwriter.Close()
                remoteconnect.Start()
            End If
        End If
    End Sub
End Class