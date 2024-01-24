
using task3;

Doctor doctor = new Doctor("Maruf", "Dentist", 20);
System.Console.WriteLine(doctor.TreatPatient("Jake"));
System.Console.WriteLine(doctor.PerformMedicalExamination("Jake"));
System.Console.WriteLine(doctor.PrescribeMedication("Jake", "paratsetamol"));
doctor.SetExperience(20);
System.Console.WriteLine("Doctor's experience" + doctor.GetExperience());