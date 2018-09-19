﻿namespace Gensler.Revit.Excelerator
{
    using Autodesk.Revit.Attributes;
    using Autodesk.Revit.DB;
    using Autodesk.Revit.UI;
    using Gensler.Revit.Excelerator.Views;

    [Transaction(TransactionMode.Manual)]
    public class RevitCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {        
            _Document = commandData.Application.ActiveUIDocument.Document;

            var window = new MainWindow();
            window.ShowDialog();

            return Result.Succeeded;
        }

        public static Document _Document;
    }
}
