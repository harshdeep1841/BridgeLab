namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;

public class Hospital
{
    private List<Doctor> doctors = new();

    private List<Patient> patients = new();

    public Hospital(){}

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }
}