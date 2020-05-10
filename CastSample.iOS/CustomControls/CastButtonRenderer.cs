using CastSample.CustomControls;
using CastSample.iOS.CustomControls;
using Google.Cast;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CastButton), typeof(CastButtonRenderer))]
namespace CastSample.iOS.CustomControls
{
    public class CastButtonRenderer : ViewRenderer<CastButton, UICastButton>
    {
        UICastButton _nativeCastButton;
        
        protected override void OnElementChanged(ElementChangedEventArgs<CastButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _nativeCastButton = new UICastButton();
                SetNativeControl(_nativeCastButton);
                _nativeCastButton.SetNeedsLayout();
	        }
        }
    }
}
