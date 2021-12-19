Imports System.Reflection
Imports System.IO
Public Class ManageParts

    Private PartsDB As Products
    Private PartsLoaded As Boolean = False

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        ControlPanel.Show()
    End Sub

    Private Sub btn_editparts_Click(sender As Object, e As EventArgs) Handles btn_editparts.Click
        Me.Hide()
        EditParts.Show()
    End Sub

    Private Sub btn_savepartsDB_Click(sender As Object, e As EventArgs) Handles btn_savepartsDB.Click
        Try
            Dim wrkstr As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) & "\XMLDB\PartsDB.xml"
            Dim c As New Xml.Serialization.XmlSerializer(PartsDB.GetType)
            Dim writer As StreamWriter = New StreamWriter(wrkstr)
            c.Serialize(writer, PartsDB)
            writer.Close()
            writer = Nothing
            c = Nothing
            MsgBox("Parts Saved Ok")
        Catch ex As Exception
            MsgBox("Parts save error - " & ex.Message)
        End Try

    End Sub
    Public Function GetPartsDB() As Products
        Return PartsDB ' this is a refernece type so any changes made to it will be reflected here i think...
    End Function
    Public Sub SetPartsDB(ByRef db As Products)
        PartsDB = db
    End Sub

    Private Sub btn_loadpartsDB_Click(sender As Object, e As EventArgs) Handles btn_loadpartsDB.Click
        Try
            PartsDB = New Products
            Dim wrkstr As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) & "\XMLDB\PartsDB.xml"
            Dim myserializer As New Xml.Serialization.XmlSerializer(PartsDB.GetType)
            Dim myfilestream As FileStream = New FileStream(wrkstr, FileMode.Open)
            PartsDB = CType(myserializer.Deserialize(myfilestream), Products)
            myfilestream.Close()
            myfilestream = Nothing
            myserializer = Nothing
            PartsLoaded = True
            UpdateControlVisibility()
            'MsgBox("Parts Loaded Ok")
        Catch ex As Exception
            MsgBox("Parts load error - " & ex.Message)
        End Try

    End Sub

    Private Sub ManageParts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call UpdateControlVisibility()
    End Sub

    Private Sub UpdateControlVisibility()
        If PartsLoaded Then
            btn_viewparts.Enabled = True
            btn_editparts.Enabled = True
            btn_addparts.Enabled = True
            btn_deleteparts.Enabled = True
        Else
            btn_viewparts.Enabled = False
            btn_editparts.Enabled = False
            btn_addparts.Enabled = False
            btn_deleteparts.Enabled = False
        End If
    End Sub

    Private Sub btn_viewparts_Click(sender As Object, e As EventArgs) Handles btn_viewparts.Click
        Me.Hide()
        ViewParts.LoadParts()
        ViewParts.Show()
    End Sub
End Class