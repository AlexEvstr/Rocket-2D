using System;

namespace Evstr.Generals
{
    public interface IUpdateLoop
    {
        event Action OnUpdate;
    }
}
