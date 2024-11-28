using System.ComponentModel;
using Spectre.Console.Cli;

namespace AElf.Cli.Commands;

public class GetBalanceSettings : CommonSettings
{
    [CommandArgument(0, "<ADDRESS>")]
    [Description("Receiver of the token.")]
    public string Address { get; set; }

    [CommandOption("-s|--symbol <SYMBOL>")]
    [Description("Symbol of the token to send.")]
    [DefaultValue("ELF")]
    public string Symbol { get; set; }
}