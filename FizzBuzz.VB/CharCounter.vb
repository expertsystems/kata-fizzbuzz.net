Imports System.Xml
Imports Common.Logging

Public Class CharCounter
    Dim LOG As ILog = LogManager.GetLogger("OpenFile")

    Public Overridable Function CountCharacters(input As String) As Dictionary(Of Char, Integer)


        Dim result As New Dictionary(Of Char, Integer)

        If input Is Nothing Then
            Return result
        End If

        For Each currentCharacter As Char In input
            AddCharacterCount(result, currentCharacter, 1)
        Next

        Return result

    End Function

    ''' <summary>
    ''' Add given no of occurrences of a character to the dictionary. Will increase if exists, or insert if not already exists.
    ''' </summary>
    ''' <param name="dictionary"></param>
    ''' <param name="char"></param>
    ''' <param name="occurrences"></param>
    ''' <remarks></remarks>
    Public Shared Sub AddCharacterCount(ByRef dictionary As Dictionary(Of Char, Integer), character As Char, occurrences As Integer)
        Dim total As Integer
        If (Not dictionary.TryGetValue(character, total)) Then total = 0
        total += occurrences
        dictionary(character) = total
    End Sub



End Class
