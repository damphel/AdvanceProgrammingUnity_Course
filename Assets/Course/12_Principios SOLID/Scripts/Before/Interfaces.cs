namespace Course.SOLID.Before
{
    public interface ICharacter
    {
        void Interact();
        void Damage(int value);
        void Heal(int value);
    }
}