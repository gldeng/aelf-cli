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
        var record = TransactionHistory.GetLastTransaction();
        if (record.Result.Status == TransactionResultStatus.Mined)
        {
            Console.WriteLine($"Transferred {Arguments.Amount} {Arguments.Symbol} at TxId {record.TransactionId} in block {record.Result.BlockNumber}.");
        }
        else
        {
            Console.WriteLine($"Transaction {record.TransactionId} failed in block {record.Result.BlockNumber}.");
        }
    }
}