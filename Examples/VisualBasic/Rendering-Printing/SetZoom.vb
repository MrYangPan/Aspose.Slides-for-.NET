﻿
Imports System
Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.Slides.Examples.VisualBasic.Rendering.Printing
    Public Class SetZoom
        Public Shared Sub Run()
			'ExStart:SetZoom
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Rendering()

            ' Instantiate a Presentation object that represents a presentation file
            Using presentation As New Presentation()

                ' Setting View Properties of Presentation
                presentation.ViewProperties.SlideViewProperties.Scale = 100
                ' zoom value in percentages for slide view
                presentation.ViewProperties.NotesViewProperties.Scale = 100
                ' zoom value in percentages for notes view 
                presentation.Save(dataDir & Convert.ToString("Zoom_out.pptx"), SaveFormat.Pptx)
            End Using
			'ExEnd:SetZoom
        End Sub
    End Class
End Namespace