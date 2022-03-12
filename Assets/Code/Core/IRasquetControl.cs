using System;

namespace Code.Core
{
    public interface IRasquetControl
    {
        event Action<float> ValueChanged;
    }
}