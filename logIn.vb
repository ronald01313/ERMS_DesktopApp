
Imports MongoDB.Bson
Imports MongoDB.Driver


Public Class logIn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_adminLogin.Click

        MongoDBConnection()

        Dim username As String = txt_adminUser.Text
        Dim password As String = txt_adminPass.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            MessageBox.Show("Admin login successful!")
            Me.Hide()
            dashBoard.Show()

        Else
            MessageBox.Show("Admin login failed. Please check your credentials.")
        End If
    End Sub

    Public Sub MongoDBConnection()
        Dim connectionString As String = "mongodb+srv://ERMS_database:123456QWErty@atlascluster.knzwerw.mongodb.net/?retryWrites=true&w=majority"
        Dim client As MongoClient = New MongoClient(connectionString)

        Dim database As IMongoDatabase = client.GetDatabase("ERMS_ADMIN")
        Dim usersCollection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("ADMIN")

    End Sub

End Class