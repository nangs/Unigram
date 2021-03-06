// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateDraftMessage : TLUpdateBase 
	{
		public TLPeerBase Peer { get; set; }
		public TLDraftMessageBase Draft { get; set; }

		public TLUpdateDraftMessage() { }
		public TLUpdateDraftMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateDraftMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLPeerBase>(from);
			Draft = TLFactory.Read<TLDraftMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteObject(Draft);
		}
	}
}