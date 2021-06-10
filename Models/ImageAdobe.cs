using System;
using System.Collections.Generic;

namespace ImageProcess.Models
{
	public class ImageAdobe : IImageEffect
	{
		private string _imageUrl;
		private List<Effect> _effects;
		private int _radiusValue;
		private int _size;
		public List<Effect> Effects { get => _effects;  }

		public void ApplyEffects()
		{
			//Apply filters and effects code goes here
		}

		public void SetEffect(List<Effect> effects)
		{
			_effects = effects;
		}

		public void SetImage(string imageUrl)
		{
			_imageUrl = imageUrl;
		}

		public void SetRadius(int radiusValue)
		{
			_radiusValue = radiusValue;
		}

		public void SetSize(int size)
		{
			 _size = size;
		}
	}
}
