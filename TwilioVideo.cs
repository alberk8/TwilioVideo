using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvi.Webrtc;
using TwilioVideo;

namespace TwilioVideo
{
    public partial class LocalParticipant
    {
        public IParticipant.State GetState()
        {
            throw new NotImplementedException();
        }
    }

    public partial class RemoteParticipant
    {
        public IParticipant.State GetState()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Tvi.Webrtc
{
    public partial class TextureBufferImpl
    {
       
        VideoFrame.ITextureBuffer.Type? VideoFrame.ITextureBuffer.GetType()
        {
            throw new NotImplementedException();
        }
    }

    public partial class WrappedNativeVideoEncoder
    {
        public IVideoEncoder.ScalingSettings? GetScalingSettings()
        {
            throw new NotImplementedException();
        }
    }

}
