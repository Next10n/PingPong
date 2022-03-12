namespace Code.Core
{
    public interface IRasquetControlService
    {
        void Register(Rasquet rasquet);
        void RegisterControl(IRasquetControl control);
    }
}