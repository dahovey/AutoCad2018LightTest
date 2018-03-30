using AutoCad2018Test;
using Autodesk.AutoCAD.Runtime;
using Application = Autodesk.AutoCAD.ApplicationServices.Core.Application;

[assembly: ExtensionApplication(typeof(Class1))]

namespace AutoCad2018Test
{
    public class Class1 : IExtensionApplication
    {
        public void Initialize()
        {
            var editor = Application.DocumentManager.MdiActiveDocument.Editor;
            editor.WriteMessage("Hello from .NET Extension, 2018");
        }

        public void Terminate()
        {
        }
    }
}
