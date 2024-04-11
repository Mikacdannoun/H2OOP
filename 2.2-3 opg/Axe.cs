
/// <summary>
/// This class represents a Axe. An Axe is 
/// considered to be a weapon.
/// </summary>
public class Axe : Weapon
{
    public static int InitialAxeMinDamage = 20;
    public static int InitialAxeMaxDamage = 50;

    #region Constructor
    public Axe(string description)
        : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
    {
    }
    #endregion

    #region Methods

    public void DullAxe()
    {
        InitialAxeMinDamage -= 3;
        InitialAxeMaxDamage -= 3;
    }

    public void Sharpen()
    {
        InitialAxeMinDamage = 20;
        InitialAxeMaxDamage = 50;
    }

    public int DamageFromAxe()
    {
        int DamageDealtFromAxe = CalculateDamage();
        DullAxe();
        return DamageDealtFromAxe;
    }

    #endregion
}