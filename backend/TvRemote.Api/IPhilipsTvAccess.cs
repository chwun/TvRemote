using System;

namespace TvRemote.Api;

public interface IPhilipsTvAccess
{
    Task<bool> SendPowerOn();
    Task<bool> SendPowerOff();
    Task<bool> SendHome();
    Task<bool> SendSource();
    Task<bool> SendSettings();
    Task<bool> SendBack();
    Task<bool> SendOk();
    Task<bool> SendUp();
    Task<bool> SendDown();
    Task<bool> SendLeft();
    Task<bool> SendRight();
    Task<bool> SendPause();
    Task<bool> SendPlay();

}
