namespace com.dke.data.agrirouter.api.service.parameters
{
    /**
     * Abstract parameter container definition.
     */
    public abstract class Parameters
    {
        private static int _applicationMessageSeqNo = 1;

        public static long ApplicationMessageSeqNo => _applicationMessageSeqNo++;

        public string ApplicationMessageId { get; set; }

        public string TeamsetContextId { get; set; }
    }
}