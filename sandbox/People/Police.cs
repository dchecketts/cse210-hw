namespace People;

public class Police : Person
{
    private string _weapon;

    public Police(string firstName, string lastName, int age, int weight, string weapon) : base (firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public string GetPoliceInformation()
    {
        return $"{GetPersonInformation()}, Weapon: {_weapon}";
    }
}