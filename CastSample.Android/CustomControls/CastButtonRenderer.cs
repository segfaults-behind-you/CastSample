using Android.Content;
using Android.Gms.Cast.Framework;
using Android.Support.V7.App;
using CastSample.CustomControls;
using CastSample.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CastButton), typeof(CastButtonRenderer))]
namespace CastSample.Droid.CustomControls
{
    public class CastButtonRenderer : ViewRenderer<CastButton, MediaRouteButton>
    {
        Context _context;
        MediaRouteButton _nativeCastButton;

        public CastButtonRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CastButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
				_nativeCastButton = new MediaRouteButton(_context);
				SetNativeControl(_nativeCastButton);
				CastButtonFactory.SetUpMediaRouteButton(_context, _nativeCastButton);
	        }
        }
    }
}
