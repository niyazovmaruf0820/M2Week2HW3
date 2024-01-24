namespace task3;

public class Doctor
{
    private string FullName;
    private string Speciality;
    private int Experience;
    private string PatientName;
    private string Medication;
    public string PerformMedicalExamination(string patientName) 
    {
        PatientName = patientName;
       return $"{FullName} is performing a medical examination for the patient named {patientName}";
    }
    public string TreatPatient(string patientName)
    {
        return $"{FullName}, {Speciality}, is treating a patient named {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{FullName} prescribes {medication} for the patient named {patientName}";
    }
    public void SetExperience(int years)
    {
        Experience = years;
    }
    public int GetExperience()
    {
        return Experience;
    }
    public Doctor(){} 
    public Doctor(string fullName, string specialty)
    {
        FullName = fullName;
        Speciality = specialty;
    }
    public Doctor(string fullName, string specialty, int experience)
    {
        FullName = fullName;
        Speciality = specialty;
        Experience = experience;
    }
}
