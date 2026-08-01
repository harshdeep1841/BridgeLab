namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Bill
{
    public int BillNo { get; }

    public decimal Amount { get; set; }

    public Patient Patient { get; }

    public Bill(int billNo,
        decimal amount,
        Patient patient)
    {
        BillNo = billNo;
        Amount = amount;
        Patient = patient;
    }

    public void GenerateBill()
    {
        Console.WriteLine(
            $"Bill #{BillNo} generated for {Patient.Name}. Amount: {Amount}");
    }
}