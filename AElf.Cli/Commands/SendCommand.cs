using AElf.Cli.Scripts;
using AElf.Script;
using AElf.Types;
using Nito.AsyncEx;
using Spectre.Console.Cli;

namespace AElf.Cli.Commands;

public class SendCommand : Command<TransferSettings>
{
    public override int Execute(CommandContext context, TransferSettings settings)
    {
        Environment.SetEnvironmentVariable(EnvVarNames.AELF_RPC_URL.ToString(), settings.Endpoint);
        Environment.SetEnvironmentVariable(EnvVarNames.DEPLOYER_PRIVATE_KEY.ToString(), settings.PrivateKey);
        var arguments = new TransferScriptArguments()
        {
            To = Address.FromBase58(settings.To),
            Amount = settings.Amount,
            Symbol = settings.Symbol
        };

        var script = new TransferScript()
        {
            Arguments = arguments
        };
        AsyncContext.Run(script.RunAsync);
        return 0;
    }
}