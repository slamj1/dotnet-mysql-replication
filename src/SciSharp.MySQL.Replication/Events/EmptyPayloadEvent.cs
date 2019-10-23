using System;
using System.Buffers;

namespace SciSharp.MySQL.Replication
{
    public sealed class EmptyPayloadEvent : LogEvent
    {
        public EmptyPayloadEvent(LogEventType eventType)
        {
            EventType = eventType;
        }

        protected override void DecodeBody(ref SequenceReader<byte> reader)
        {

        }
    }

    class EmptyPayloadEventFactory : ILogEventFactory
    {
        public LogEventType EventType { get; private set; }

        public EmptyPayloadEventFactory(LogEventType eventType)
        {
            EventTyp = eventType;
        }

        public LogEvent Create()
        {
            return new EmptyPayloadEvent(EventType);
        }
    }
}