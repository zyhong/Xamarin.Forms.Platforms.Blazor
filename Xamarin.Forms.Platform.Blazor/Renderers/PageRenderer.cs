﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Blazor.RenderTree;

[assembly: Xamarin.Forms.Platform.Blazor.ExportRenderer(
	typeof(Xamarin.Forms.Page),
	typeof(Xamarin.Forms.Platform.Blazor.Renderers.PageRenderer))]

namespace Xamarin.Forms.Platform.Blazor.Renderers
{
	public class PageRenderer : ViewRenderer<Page>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged(e);
			if (e.NewElement == null)
				return;

			var cp = e.NewElement as ContentPage;
			if (cp == null)
				return;

			// TODO: Get real window size
			// cp.Content.Layout(new Rectangle(0, 0, 1920, 1080));
		}

		protected override void RenderContent(RenderTreeBuilder builder)
		{
			base.RenderContent(builder);
			var cp = this.Element as ContentPage;
			if (cp == null)
				return;

			this.RenderChild(builder, cp);
		}
	}
}
