using System.ComponentModel;

namespace AElf.Cli;

using Spectre.Console.Cli;

public class CommonSettings : CommandSettings
{
    [CommandOption("-e|--endpoint <ENDPOINT>")]
    [Description("The endpoint to the aelf node api.")]
    [DefaultValue("http://localhost:8000")]
    public string Endpoint { get; set; }

    [CommandOption("-k|--private-key <PRIVATEKEY>")]
    [Description("The private key used to send transactions.")]
    [DefaultValue("1111111111111111111111111111111111111111111111111111111111111111")]
    public string PrivateKey { get; set; }
}