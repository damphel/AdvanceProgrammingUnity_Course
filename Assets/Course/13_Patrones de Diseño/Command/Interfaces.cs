namespace Course.PatronesDiseno.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
