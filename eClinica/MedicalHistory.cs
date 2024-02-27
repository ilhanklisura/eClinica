namespace eClinica;

public class MedicalHistory
{
	public int Id { get; set; }
	public int PatientId { get; set; }
	public string Diagnosis { get; set; }
	public string Prescription { get; set; }
}