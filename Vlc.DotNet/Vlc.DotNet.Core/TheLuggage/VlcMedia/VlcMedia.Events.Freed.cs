﻿using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Signatures.TheLuggage;

namespace Vlc.DotNet.Core.TheLuggage
{
    public partial class VlcMedia
    {
        private EventCallback myOnMediaFreedInternalEventCallback;
        public event EventHandler<VlcMediaFreedEventArgs> Freed;

        private void OnMediaFreedInternal(IntPtr ptr)
        {
            var args = (VlcEventArg) Marshal.PtrToStructure(ptr, typeof (VlcEventArg));
            //OnMediaFreed(args.MediaFreed.MediaInstance);
            OnMediaFreed();
        }

        public void OnMediaFreed()
        {
            var del = Freed;
            if (del != null)
                del(this, new VlcMediaFreedEventArgs());
        }
    }
}