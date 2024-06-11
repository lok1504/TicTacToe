using Microsoft.AspNetCore.SignalR;

namespace TicTacToe.Hubs;

public class GameHub : Hub
{
    public override Task OnConnectedAsync()
    {
        Console.WriteLine($"Player with ID '{Context.ConnectionId}' connected.");
        return base.OnConnectedAsync();
    }
}
