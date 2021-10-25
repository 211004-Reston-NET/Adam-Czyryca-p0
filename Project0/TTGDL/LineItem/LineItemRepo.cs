using System.Collections.Generic;
using TTGModel;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace TTGDL
{
    public class LineItemRepo : ILineItemRepo
    {
        private const string _filePath = "./../TTGDL/Database/LineItems.json";

        private string _jsonString;

        public LineItems AddLineItem(LineItems _Line)
        {
            List<LineItems> ListOfLineItems = GetAllLineItems();
            ListOfLineItems.Add(_Line);

            /*
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            */

            _jsonString = JsonSerializer.Serialize(ListOfLineItems, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_filePath, _jsonString);

            return _Line;

        }

        public List<LineItems> GetAllLineItems()
        {
            _jsonString = File.ReadAllText(_filePath);

            return JsonSerializer.Deserialize<List<LineItems>>(_jsonString);
        }


    }
}