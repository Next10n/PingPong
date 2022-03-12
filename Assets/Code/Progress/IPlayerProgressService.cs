namespace Code.Progress
{
    public interface IPlayerProgressService
    {
        PlayerProgress Progress { get; }
        void Load();
    }
}