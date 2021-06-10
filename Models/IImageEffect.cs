using System.Collections.Generic;

namespace ImageProcess.Models
{
	public interface IImageEffect
	{
		List<Effect> Effects { get; }
		void SetEffect(List<Effect> effects);
		void SetRadius(int radiusValue);
		void SetSize(int size);
		void SetImage(string imageUrl);
		void ApplyEffects();

	}
}
