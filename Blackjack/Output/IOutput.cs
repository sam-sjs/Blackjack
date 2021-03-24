namespace Blackjack.Output
{
    public interface IOutput
    {
        public void WriteLine();
        public void WriteLine(string message);
        public void Write(string message);
    }
}