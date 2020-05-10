using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Cast;
using Android.Gms.Cast.Framework;
using Android.Runtime;

namespace CastSample.Droid.Cast
{
    [Register("CastSample/Android/Cast/CastOptionsProvider")]
    public class CastOptionsProvider : Java.Lang.Object, IOptionsProvider
    {
        public IList<SessionProvider> GetAdditionalSessionProviders(Context appContext) =>
            null;

        public CastOptions GetCastOptions(Context appContext) =>
            new CastOptions.Builder()
                .SetReceiverApplicationId(CastMediaControlIntent.DefaultMediaReceiverApplicationId)
                .Build();
    }
}
