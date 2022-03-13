namespace Code.Progress
{
    public interface IPlayerProgressService
    {
        PlayerProgress Progress { get; }
        PlayerProgress Create();
        void Load(PlayerProgress playerProgress);
    }
}