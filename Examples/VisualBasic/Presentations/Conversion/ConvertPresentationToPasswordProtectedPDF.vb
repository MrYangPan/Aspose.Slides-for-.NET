﻿Imports System
Imports Aspose.Slides.Export

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Presentations.Conversion
    Class ConvertPresentationToPasswordProtectedPDF
        Public Shared Sub Run()
			'ExStart:ConvertPresentationToPasswordProtectedPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Conversion()

            ' Instantiate a Presentation object that represents a presentation file
            Using presentation As New Presentation(dataDir & Convert.ToString("DemoFile.pptx"))
                ' Instantiate the PdfOptions class
                Dim pdfOptions As New PdfOptions()

                ' Setting PDF password
                pdfOptions.Password = "password"

                ' Save the presentation to password protected PDF
                presentation.Save(dataDir & Convert.ToString("PasswordProtectedPDF_out.pdf"), SaveFormat.Pdf, pdfOptions)
            End Using
			'ExEnd:ConvertPresentationToPasswordProtectedPDF
        End Sub
    End Class
End Namespace
