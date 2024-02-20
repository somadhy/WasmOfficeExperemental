using System;
using System.IO;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using Aspose.Cells;

Console.WriteLine("Hello, Browser!");

public partial class WasmOffice
{
    [JSExport]
    internal static string Greeting()
    {
        var text = $"Hello, World! Greetings from {GetHRef()}";
        Console.WriteLine(text);
        return text;
    }

    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();

    [JSExport]
    internal static async Task<int> ProcessFile(byte[] file)
    {
		await Task.Delay(100); // эмулируем работу
        return file.Length;
    }

    [JSExport]
    internal static byte[] CreateExcel()
    {
        // initiate an instance of Workbook
        var book = new Workbook();
        // access first (default) worksheet
        var sheet = book.Worksheets[0];
        // access CellsCollection of first worksheet
        var cells = sheet.Cells;
        // write HelloWorld to cells A1
        cells["A1"].Value = "Hello World";
        // save spreadsheet to disc
        using var ms = new MemoryStream();
        // book.Save(ms, SaveFormat.Pdf);        
        book.Save(ms, SaveFormat.Xlsx);
        return ms.ToArray();
    }
}
