using System.Globalization;
using CsvHelper;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.CSVDataHandling;

public class CsvSample
{
    
    public void ReadCsvFile()
    {
        FileStream fileStream = new FileStream("csv-sample-1.csv", FileMode.OpenOrCreate);
        StreamReader sr =  new StreamReader(fileStream);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string [] columns = line.Split(',');
            Console.WriteLine($"ID : {columns[0]} NAME :  {columns[1]}");
        }
        
        
    }

    public void ReadCsvUsingCsvHelper()
    {
        var reader = new StreamReader("csv-sample-1.csv");
        var csv = new CsvReader(reader , CultureInfo.InvariantCulture);
        var records = csv.GetRecords<EmployeeCsv>();
        foreach (var record in records)
        {
            Console.WriteLine($"{record.ID} | {record.Name} |  {record.Department} | {record.Salary}");
        }
    }

    public void WriteCSVUsingCsvHelper()
    {
      using  var writer = new StreamWriter("csv-sample-1.csv" , true);
      using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
      List<EmployeeCsv> employees = new List<EmployeeCsv>()
        {
            new EmployeeCsv { ID = 104, Name = "Alice Williams", Department = "Finance", Salary = 62000 },
            new EmployeeCsv { ID = 105, Name = "Bob Johnson", Department = "Sales", Salary = 58000 }

        };
        
        csv.WriteRecords(employees);
    }

    public void SortCsvUsingCsvHelper()
    {
        List<EmployeeCsv> sortedRecords;
        {
            using StreamReader sr = new StreamReader("csv-sample-1.csv");
            using var csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);
            var records = csvReader.GetRecords<EmployeeCsv>();
            sortedRecords = records.OrderByDescending(employee => employee.Salary).ToList();
            
        }
        foreach (var record in sortedRecords)
        {
                Console.WriteLine(record.Name);
        }
        
        using  StreamWriter sw = new StreamWriter("csv-sample-1.csv");
      using  var csvWriter = new CsvWriter(sw , CultureInfo.InvariantCulture);
      csvWriter.WriteRecords(sortedRecords);
    }
}