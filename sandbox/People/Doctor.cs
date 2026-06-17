namespace People;

public class Doctor(string firstName, string lastName, int age, int weight, string degree) : Person(firstName, lastName,
    age, weight)
{
    private string _degree = degree;

    public string GetDoctorInformation()
    {
        return $"{GetPersonInformation()}, Education: {_degree}";
    }
}