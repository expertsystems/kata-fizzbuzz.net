Imports System.Xml

Public Class FileCharacterCounter

    Public MyCharCounter As New CharCounter

    Public MyFileReader As New OpenFile

    Public Function CountCharacters(document As XmlDocument) As Dictionary(Of Char, Integer)
        Dim lines As IList(Of String) = MyFileReader.ParseXml(document)

        Dim result As New Dictionary(Of Char, Integer)
        Dim charCountsForLine As Dictionary(Of Char, Integer)
        For Each line As String In lines
            charCountsForLine = MyCharCounter.CountCharacters(line)
            For Each character As Char In charCountsForLine.Keys
                CharCounter.AddCharacterCount(result, character, charCountsForLine(character))
            Next
        Next
        Return result
    End Function

End Class
