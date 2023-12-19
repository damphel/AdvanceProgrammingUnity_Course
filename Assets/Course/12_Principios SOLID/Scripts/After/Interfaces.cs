namespace Course.SOLID.After
{
    public interface IInteract
    {
        void Interact();
    }

    public interface IDamage
    {
        void Damage(int value);
    }

    public interface IHeal
    {
        void Heal(int value);
    }
}