namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Appointment
{
    public int AppointmentId { get; }

    public DateTime AppointmentDate { get; set; }

    public Patient Patient { get; }

    public Doctor Doctor { get; }

    public Appointment(int id,
        DateTime date,
        Patient patient,
        Doctor doctor)
    {
        AppointmentId = id;
        AppointmentDate = date;
        Patient = patient;
        Doctor = doctor;
    }

    public void Book()
    {
        Console.WriteLine(
            $"Appointment booked for {Patient.Name} with Dr. {Doctor.Name}");
    }
}