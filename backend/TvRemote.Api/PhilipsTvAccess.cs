using System;
using CliWrap;

namespace TvRemote.Api;

public class PhilipsTvAccess : IPhilipsTvAccess
{
    private const string philipsTvAppName = "philipstv";

    private async Task<bool> SendCommand(IEnumerable<string> args)
    {
        var result = await Cli.Wrap(philipsTvAppName)
            .WithArguments(args)
            .WithValidation(CommandResultValidation.None)
            .ExecuteAsync();

        return result.IsSuccess;
    }

    public async Task<bool> SendPowerOff()
    {
        return await SendCommand(["power", "set", "off"]);
    }

    public async Task<bool> SendPowerOn()
    {
        return await SendCommand(["power", "set", "on"]);
    }

    public async Task<bool> SendHome()
    {
        return await SendCommand(["key", "home"]);
    }

    public async Task<bool> SendSource()
    {
        return await SendCommand(["key", "source"]);
    }

    public async Task<bool> SendSettings()
    {
        return await SendCommand(["key", "adjust"]);
    }

    public async Task<bool> SendBack()
    {
        return await SendCommand(["key", "back"]);
    }

    public async Task<bool> SendOk()
    {
        return await SendCommand(["key", "ok"]);
    }

    public async Task<bool> SendUp()
    {
        return await SendCommand(["key", "up"]);
    }

    public async Task<bool> SendDown()
    {
        return await SendCommand(["key", "down"]);
    }

    public async Task<bool> SendLeft()
    {
        return await SendCommand(["key", "left"]);
    }

    public async Task<bool> SendRight()
    {
        return await SendCommand(["key", "right"]);
    }

    public async Task<bool> SendPause()
    {
        return await SendCommand(["key", "pause"]);
    }

    public async Task<bool> SendPlay()
    {
        return await SendCommand(["key", "play"]);
    }
}
