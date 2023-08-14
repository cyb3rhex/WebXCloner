Imports System.Runtime.CompilerServices
Imports HtmlAgilityPack

Module HtmlNodeExtensions

    <Extension()>
    Public Function SelectNodesSafe(ByVal node As HtmlNode, xpath As String) As IEnumerable(Of HtmlNode)
        Dim selectedNodes = node.SelectNodes(xpath)
        If selectedNodes Is Nothing Then Return Enumerable.Empty(Of HtmlNode)()
        Return selectedNodes
    End Function

End Module
