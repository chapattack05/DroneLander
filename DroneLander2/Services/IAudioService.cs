using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander2.Services
{
	public interface IAudioService
	{
		void AdjustVolume(double volume);
		void KillEngine();
		void ToggleEngine();
		Action OnFinishedPlaying { get; set; }
	}
}