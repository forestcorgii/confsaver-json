Imports Newtonsoft.Json

Public Class JSONSerialization
    Public Function ReadFromFile(path As String, model As Object)
        If model Is Nothing Then
            Throw New ArgumentNullException(NameOf(model))
        End If

        Using f As New IO.StreamReader(path)
            Dim deserializer As New Newtonsoft.Json.JsonSerializer
            deserializer.Deserialize(f, model.GetType)
        End Using
    End Function

    Public Function WriteToFile(path As String, model As Object)
        Using writer As IO.StreamWriter = IO.File.CreateText(path)
            Dim serializer As New JsonSerializer
            serializer.Serialize(writer, model)
        End Using
    End Function
End Class
