
namespace Internship_4_oop_and_architecture
{
    public class Warrior : Hero
    {
        public void RageAttack(double HealthPoints, double Damage )
        {
            HealthPoints = 0.85 * HealthPoints;
            Damage = 2 * Damage;

        }
    }
}
