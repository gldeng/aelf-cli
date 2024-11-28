using AElf.Cli.Scripts;
using AElf.Script;
using AElf.Types;
using Nito.AsyncEx;
using Spectre.Console.Cli;

namespace AElf.Cli.Commands;

public class GetBalanceCommand : Command<GetBalanceSettings>
{
    public override int Execute(CommandContext context, GetBalanceSettings settings)
    {
        Environment.SetEnvironmentVariable(EnvVarNames.AELF_RPC_URL.ToString(), settings.Endpoint);
        Environment.SetEnvironmentVariable(EnvVarNames.DEPLOYER_PRIVATE_KEY.ToString(), settings.PrivateKey);
        var script = new GetBalanceScript()
        {
            Address = Address.FromBase58(settings.Address),
            Symbol = settings.Symbol
        };
        AsyncContext.Run(script.RunAsync);
        Console.WriteLine($"The {settings.Symbol} balance of {settings.Address} is {script.Balance}.");
        return 0;
    }
}