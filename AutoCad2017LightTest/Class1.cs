﻿using AutoCad2017LightTest;
using Autodesk.AutoCAD.Runtime;
using Application = Autodesk.AutoCAD.ApplicationServices.Core.Application;

[assembly: ExtensionApplication(typeof(Class1))]

namespace AutoCad2017LightTest
{
    public class Class1 : IExtensionApplication
    {
        public void Initialize()
        {
            var editor = Application.DocumentManager.MdiActiveDocument.Editor;
            editor.WriteMessage("Hello from .NET Extension, 2017 LT");
        }

        public void Terminate()
        {
        }
    }
}
