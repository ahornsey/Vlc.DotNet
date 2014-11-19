﻿using System;
using Vlc.DotNet.Core.Interops.Signatures.Rincewind;

namespace Vlc.DotNet.Core.Rincewind
{
    public sealed partial class VlcMediaPlayer
    {
        private EventCallback myOnMediaPlayerBackwardInternalEventCallback;
        public event EventHandler<VlcMediaPlayerBackwardEventArgs> Backward;

        private void OnMediaPlayerBackwardInternal(IntPtr ptr)
        {
            OnMediaPlayerBackward();
        }

        public void OnMediaPlayerBackward()
        {
            var del = Backward;
            if (del != null)
                del(this, new VlcMediaPlayerBackwardEventArgs());
        }
    }
}