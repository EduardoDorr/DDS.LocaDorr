using DDS.LocaDorr.Common.ValueObjects;

namespace DDS.LocaDorr.Common.Entities;

public interface ILogin
{
    public Password Password { get; }
}