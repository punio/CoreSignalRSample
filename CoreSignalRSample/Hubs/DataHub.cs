using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace CoreSignalRSample.Hubs
{
	public class DataHub : Hub
	{
		public void Upload(byte[] data)
		{
			System.Diagnostics.Debug.WriteLine($"Receive {data.Length}bytes.");
		}
	}
}
