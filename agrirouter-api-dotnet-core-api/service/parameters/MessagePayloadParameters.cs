using Google.Protobuf;

namespace com.dke.data.agrirouter.api.service.parameters
{
    /**
     * Parameter container definition.
     */
    public class MessagePayloadParameters : Parameters
    {
        public string TypeUrl { get; set; }

        public ByteString Value { get; set; }
    }
}