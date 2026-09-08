using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.FileBasedStudentRecordBackupSystem;

public class OperationsOnRecords
{
    public List<StudentRecord> Records = new();
    public void WriteRecordsIntoCsv()
    {
       using StreamWriter streamWriter = new StreamWriter("Records.csv" , true);
       using CsvWriter csvWriter = new CsvWriter(streamWriter , CultureInfo.InvariantCulture );
       csvWriter.WriteRecords(Records);
    }

    public void ReadRecordsFromCsv()
    {
        //using csvHelper
       using StreamReader sr  = new StreamReader("Records.csv");
       using CsvReader csvReader = new CsvReader(sr , CultureInfo.InvariantCulture);
       List<StudentRecord> records = csvReader.GetRecords<StudentRecord>().ToList();
        foreach (StudentRecord record in records)
        {
            Console.WriteLine(record);
        }
        
    }
    

    public void WriteRecordsToJson()
    { 
        string jsonString = JsonConvert.SerializeObject(Records);
       using FileStream fileStream = new FileStream("Records.json", FileMode.OpenOrCreate);
       File.AppendAllText("Records.json", jsonString);
    }

    public void ReadRecordsFromJson()
    {
        string jsonString = File.ReadAllText("Records.json");
        List<StudentRecord> records = JsonConvert.DeserializeObject<List<StudentRecord>>(jsonString);
        foreach (StudentRecord record in records)
        {
            Console.WriteLine(record);
        }
    }

    public void WriteRecordsToBinary()
    {
        using FileStream fileStream =
            new FileStream("Records.dat", FileMode.Create);

        using BufferedStream bufferedStream =
            new BufferedStream(fileStream);

        using BinaryWriter writer =
            new BinaryWriter(bufferedStream);

        writer.Write(Records.Count);

        foreach (StudentRecord record in Records)
        {
            writer.Write(record.Student_Id);
            writer.Write(record.Name);
            writer.Write(record.Grade);
            writer.Write(record.Gpa);
            writer.Write(record.EnrollmentDate.ToBinary());
        }
    }

    public void ReadRecordsFromBinary()
    {
        using FileStream fileStream =
            new FileStream("Records.dat", FileMode.Open);

        using BufferedStream bufferedStream =
            new BufferedStream(fileStream);

        using BinaryReader reader =
            new BinaryReader(bufferedStream);

        int count = reader.ReadInt32();

        List<StudentRecord> records = new();

        for (int i = 0; i < count; i++)
        {
            StudentRecord record = new StudentRecord
            {
                Student_Id = reader.ReadInt32(),
                Name = reader.ReadString(),
                Grade = reader.ReadChar(),
                Gpa = reader.ReadDouble(),
                EnrollmentDate = DateTime.FromBinary(reader.ReadInt64())
            };

            records.Add(record);
        }

        foreach (StudentRecord record in records)
        {
            Console.WriteLine(record);
        }
    }
    

    public void AddRecord(StudentRecord record)
    {
        Records.Add(record);
    }
}