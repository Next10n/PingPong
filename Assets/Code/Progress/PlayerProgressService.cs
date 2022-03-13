namespace Code.Progress
{
    public class PlayerProgressService : IPlayerProgressService
    {
        public PlayerProgress Progress { get; private set; }

        public PlayerProgress Create()
        {
            Progress = new PlayerProgress();
            return Progress;
        }

        public void Load(PlayerProgress playerProgress) =>
            Progress = playerProgress;
    }
}