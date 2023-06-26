using OfficeOpenXml;
using System.Reflection;

namespace NimbusSync.Client.Logic
{
    public static class ExcelFile
    {
        public static string[] GetSheetNames(string filePath)
        {
            ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
            return package.Workbook.Worksheets.Select(ws => ws.Name).ToArray();
        }
        public static List<T>? ReadSheet<T>(string filePath, int sheetIndex) where T : new()
        {
            ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
            ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetIndex];
            List<T> values = new List<T>();
            Type type = typeof(T);
            List<PropertyInfo> properties = type.GetProperties().ToList();
            properties = properties
                .Where(p => 
                    p.CanWrite && 
                    p.GetIndexParameters().Length == 0 && 
                    !p.Name.StartsWith("_"))
                .ToList();

            // Verifica se todas as propriedades estão na tabela
            for(int i = 0; i < properties.Count; i++)
            {
                string tableHeader = worksheet.Cells[1, i + 1].Value?.ToString();
                if (properties[i].Name != tableHeader)
                {
                    return null;
                }
            }

            for(int row = 2; row < worksheet.Cells.Rows; row++)
            {
                // Verifica se estamos numa linha vazia
                int nullFields = 0;
                T obj = new();

                for (int column = 1; column < properties.Count + 1; column++)
                {
                    string value = worksheet.Cells[row, column].Value?.ToString();
                    if(value == null)
                    {
                        nullFields++;
                    }

                    PropertyInfo property = properties[column - 1];
                    property.SetValue(obj, value);
                }

                if (nullFields >= properties.Count) break;

                values.Add(obj);
            }

            return values;
        }
    }
}
