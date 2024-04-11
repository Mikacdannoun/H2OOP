
/// <summary>
/// This class represents a Wand. A Wand is 
/// considered to be a weapon.
/// </summary>
public class Wand : Weapon
{
    public bool IsEnchanted { get; set; }

    public const int InitialWandMinDamage = 10;
    public const int InitialWandMaxDamage = 30;

    #region Constructor
    public Wand(string description)
        : base(description, InitialWandMinDamage, InitialWandMaxDamage)
    {
    }
    #endregion

    #region Method
        
    public int DamageFromWand()
    {
        int DamageDealtFromWand = CalculateDamage();
        if (IsEnchanted)
        {
            int EnchantedWandDamage = DamageDealtFromWand * 2;
            return EnchantedWandDamage;
        }
        else
        {
            return DamageDealtFromWand;
        }
    }

    #endregion
}
