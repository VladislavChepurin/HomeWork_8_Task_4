
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
namespace HomeWork_8_Task_4;

class Program
{
    static void Main(string[] args)
    {
        string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Students.dat";

        if (File.Exists(file))
        {
            BinaryFormatter formatter = new();

            using (var fs = new FileStream(file, FileMode.Open))
            {
                //var student = formatter.Deserialize(fs) as Student;  // Ошибка десериализации

                //var student = formatter.Deserialize(fs) as Student[];  // Ошибка десереализации

                //var student = formatter.Deserialize(fs) as DataTable;  // Ошибка десереализации

                //var student = formatter.Deserialize(fs) as DataSet;  // Ошибка десереализации

                //var student = formatter.Deserialize(fs) as DataTableCollection;  // Маловероятно. Ошибка десереализации

                //var student = formatter.Deserialize(fs) as BinaryFormatter;  // Крайне маловероятно. Ошибка десереализации
            }

        }
        Console.ReadKey();
    }
}
