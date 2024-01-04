namespace Course.PatronesDiseno.Strategy
{
    public interface IWeapon
    {
        void Attack();
    }

    public interface IDamage
    {
        void DoDamage(int damage);
    }
}
