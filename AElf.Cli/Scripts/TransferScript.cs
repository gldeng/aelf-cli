using AElf.Types;

namespace AElf.Cli.Scripts;

using AElf.Script;

public class TransferScriptArguments
{
    public Address To { get; set; }
    public string Symbol { get; set; }
    public uint Amount { get; set; }
}

public class TransferScript : Script
{
    public TransferScriptArguments Arguments { get; set; }

    public override async Task RunAsync()
    {
        await this.TransferTokenAsync(Arguments.To, Arguments.Amount);
    }
}