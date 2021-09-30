
public class Health 
{
    public float MaxHP { get; }
    public float CurrentHP { get; private set; }

    public Health(float hp, float current)
    {
        MaxHP = hp;
        CurrentHP = current;
    }

    public void ChangeHP(float value) => CurrentHP = value;
   
}
