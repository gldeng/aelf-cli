using AElf.Script;
using AElf.Types;

namespace AElf.Cli.Scripts;

public class GetBalanceScript : Script.Script
{
    public Address Address { get; set; }
    public string Symbol { get; set; }
    public long Balance { get; private set; }

    public override async Task RunAsync()
    {
        Balance = await this.GetBalanceAsync(Address, Symbol);
    }
}