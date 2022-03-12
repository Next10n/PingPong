namespace Code.Core
{
    public class RasquetControlService : IRasquetControlService
    {
        private Rasquet _rasquet;

        public void Register(Rasquet rasquet)
        {
            _rasquet = rasquet;
        }

        public void RegisterControl(IRasquetControl control) =>
            control.ValueChanged += MoveRasquet;

        public void UnregisterControl(IRasquetControl control) =>
            control.ValueChanged -= MoveRasquet;

        private void MoveRasquet(float value)
        {
            _rasquet.Move(value);
        }
    }
}