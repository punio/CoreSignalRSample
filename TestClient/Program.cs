using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;

namespace TestClient
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var connection = new HubConnectionBuilder()
				.WithUrl("http://localhost:58456/hub/data")
				.AddMessagePackProtocol()
				.Build();
			await connection.StartAsync();

			var testData = Enumerable.Range(0, 1024).Select(i => (byte)i).ToArray();
			await connection.InvokeAsync("Upload", testData);

			await connection.DisposeAsync();
		}
	}
}
