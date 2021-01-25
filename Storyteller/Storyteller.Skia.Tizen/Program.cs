using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Storyteller.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new Storyteller.App(), args);
			host.Run();
		}
	}
}
