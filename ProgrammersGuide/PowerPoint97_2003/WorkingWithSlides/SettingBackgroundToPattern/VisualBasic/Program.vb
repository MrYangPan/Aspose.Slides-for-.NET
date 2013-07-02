'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides

Namespace SettingBackgroundToPattern
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Presentation object that represents a PPT file
			Dim pres As New Presentation(dataDir & "demo.ppt")


			'Accessing a slide using its slide position
			Dim slide As Slide = pres.GetSlideByPosition(1)


			'Disable following master background settings
			slide.FollowMasterBackground = False


			'Setting the fill type of the background to picture
			slide.Background.FillFormat.Type = FillType.Pattern


			'Setting Pattern Style
			slide.Background.FillFormat.PatternStyle = PatternStyle.DiagonalBrick

			slide.Background.FillFormat.ForeColor = System.Drawing.Color.Chocolate


			'Writing the presentation as a PPT file
			pres.Write(dataDir & "modified.ppt")
		End Sub
	End Class
End Namespace