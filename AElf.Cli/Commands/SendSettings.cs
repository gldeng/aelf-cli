using System.ComponentModel;
using Spectre.Console.Cli;

namespace AElf.Cli.Commands;

public class TransferSettings : CommonSettings
{
    [CommandArgument(0, "<TO>")]
    [Description("Receiver of the token.")]
    public string To { get; set; }

    [CommandArgument(1, "<AMOUNT>")]
    [Description("Amount of the token to send.")]
    public uint Amount { get; set; }

    [CommandOption("-s|--symbol <SYMBOL>")]
    [Description("Symbol of the token to send.")]
    [DefaultValue("ELF")]
    public string Symbol { get; set; }
}