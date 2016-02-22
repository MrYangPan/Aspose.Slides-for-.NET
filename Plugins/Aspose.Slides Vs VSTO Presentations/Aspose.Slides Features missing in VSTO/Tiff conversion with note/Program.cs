﻿// Copyright (c) Aspose 2002-2014. All Rights Reserved.

using Aspose.Slides.Export;
using Aspose.Slides;

namespace Tiff_conversion_with_note
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyDir = @"Files\";
            //Instantiate a Presentation object that represents a presentation file
            Presentation pres = new Presentation(MyDir + "Conversion.pptx");

            //Saving the presentation to TIFF notes
            pres.Save(MyDir + "ConvertedwithNotes.tiff", SaveFormat.TiffNotes);
        }

    }
}
