Imports System.Net
Imports HtmlAgilityPack
Imports System.IO
Imports System.Text.RegularExpressions


Public Class Form1

    Private errors As New List(Of String)() ' For error logging

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code
    End Sub


    Private Sub btnSelectPath_Click(sender As Object, e As EventArgs) Handles btnSelectPath.Click
        Using folderDialog As New FolderBrowserDialog()
            If folderDialog.ShowDialog() = DialogResult.OK Then
                txtSavePath.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub btnStartClone_Click(sender As Object, e As EventArgs) Handles btnStartClone.Click
        Dim websiteUrl As String = txtWebsiteUrl.Text.Trim()
        Dim savePath As String = txtSavePath.Text.Trim()

        If String.IsNullOrEmpty(websiteUrl) OrElse String.IsNullOrEmpty(savePath) Then
            MessageBox.Show("Please provide the website URL and select a save path.")
            Return
        End If

        Try
            ' Download the main page
            Dim doc As HtmlDocument = FetchDocument(websiteUrl)

            ' Initialize progress bar
            myProgressBar.Value = 0

            ' Process the main document and download its resources
            ProcessDocument(websiteUrl, doc, savePath)

            ' Save the modified main HTML content
            Dim mainHtmlPath As String = Path.Combine(savePath, "index.html")
            File.WriteAllText(mainHtmlPath, doc.Text)

            If errors.Any() Then
                MessageBox.Show("Website cloned with some errors. Check logs.")
            Else
                MessageBox.Show("Website cloned successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub ProcessDocument(baseWebsiteUrl As String, doc As HtmlDocument, saveFolder As String)
        ' Download Images
        For Each imgNode As HtmlNode In doc.DocumentNode.SelectNodesSafe("//img[@src]")
            Dim imgUrl As String = imgNode.GetAttributeValue("src", "")
            DownloadResource(baseWebsiteUrl, imgUrl, saveFolder)
            imgNode.SetAttributeValue("src", Path.GetFileName(imgUrl))
        Next

        ' Download CSS & its resources
        For Each linkNode As HtmlNode In doc.DocumentNode.SelectNodesSafe("//link[@rel='stylesheet']")
            Dim cssUrl As String = linkNode.GetAttributeValue("href", "")
            Dim cssContent = DownloadResource(baseWebsiteUrl, cssUrl, saveFolder, returnContent:=True)
            If Not String.IsNullOrWhiteSpace(cssContent) Then
                ' Check for any URL references within the CSS and download them
                Dim urlMatches = Regex.Matches(cssContent, "url\(['""]?(?<url>[^'""\)]+)['""]?\)")
                For Each match As Match In urlMatches
                    Dim innerResource = match.Groups("url").Value
                    DownloadResource(baseWebsiteUrl, innerResource, saveFolder)
                    cssContent = cssContent.Replace(innerResource, Path.GetFileName(innerResource))
                Next
                ' Save the modified CSS content
                File.WriteAllText(Path.Combine(saveFolder, Path.GetFileName(cssUrl)), cssContent)
            End If
            linkNode.SetAttributeValue("href", Path.GetFileName(cssUrl))
        Next

        ' Download JS
        For Each scriptNode As HtmlNode In doc.DocumentNode.SelectNodesSafe("//script[@src]")
            Dim jsUrl As String = scriptNode.GetAttributeValue("src", "")
            DownloadResource(baseWebsiteUrl, jsUrl, saveFolder)
            scriptNode.SetAttributeValue("src", Path.GetFileName(jsUrl))
        Next
    End Sub

    Private Function FetchDocument(url As String) As HtmlDocument
        Dim web As New HtmlWeb()
        Return web.Load(url)
    End Function

    Private Function DownloadResource(baseWebsiteUrl As String, resourceUrl As String, saveFolder As String, Optional returnContent As Boolean = False) As String
        Dim content As String = String.Empty
        Try
            Dim client As New WebClient()
            Dim absoluteResourceUrl As Uri

            If Uri.IsWellFormedUriString(resourceUrl, UriKind.Absolute) Then
                absoluteResourceUrl = New Uri(resourceUrl)
            Else
                absoluteResourceUrl = New Uri(New Uri(baseWebsiteUrl), resourceUrl)
            End If

            ' Preserve the directory structure
            Dim relativePath = absoluteResourceUrl.AbsolutePath
            Dim savePath As String = Path.Combine(saveFolder, relativePath.TrimStart("/"c))

            ' Ensure the directory exists before saving the file

            Dim saveDirectory = Path.GetDirectoryName(savePath)
            If Not System.IO.Directory.Exists(saveDirectory) Then
                System.IO.Directory.CreateDirectory(saveDirectory)
            End If


            If returnContent Then
                content = client.DownloadString(absoluteResourceUrl)
            Else
                client.DownloadFile(absoluteResourceUrl, savePath)
            End If

        Catch ex As Exception
            errors.Add($"Failed to download {resourceUrl}. Error: {ex.Message}")
        Finally
            myProgressBar.Value += 1
        End Try

        Return content
    End Function


    ' Helper function to safely select nodes
    Private Function HtmlNodeCollection_SelectNodesSafe(node As HtmlNode, xpath As String) As IEnumerable(Of HtmlNode)
        Dim selectedNodes = node.SelectNodes(xpath)
        If selectedNodes Is Nothing Then Return Enumerable.Empty(Of HtmlNode)()
        Return selectedNodes
    End Function

End Class
