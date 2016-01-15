Imports System.Xml
Imports Common.Logging

Public Class OpenFile

    Dim LOG As ILog = LogManager.GetLogger("OpenFile")


    ''' <summary>
    ''' Extract strings from "<data />" tags in provided XML document, and return as a list
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function ParseXml(input As XmlDocument) As IList(Of String)


        Dim xmlTextList As New List(Of String)

        Dim theDataNodes As XmlNodeList = input.SelectNodes("//data")

        For i As Integer = 0 To theDataNodes.Count - 1
            Dim theDataNode As XmlNode = theDataNodes.ItemOf(i)

            If Not theDataNode Is Nothing Then
                LOG.Info("For i = " + i.ToString() + " we found node " + theDataNode.InnerText + " with value ")
            Else
                LOG.Info("For i = " + i.ToString() + " nothing found!")
            End If

            xmlTextList.Add(theDataNode.InnerText)
        Next


        Return xmlTextList

    End Function

    Function CountChar(input As String) As Dictionary(Of Char, Integer)



    End Function
End Class
