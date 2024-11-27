using AElf.Cli.Commands;
using Spectre.Console.Cli;

var app = new CommandApp();
app.Configure(config =>
{
    config.SetApplicationName("aelf");
    config.AddCommand<SendCommand>("send");
});
app.Run(args);