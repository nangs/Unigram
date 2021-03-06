// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageUploadPhotoAction : TLSendMessageActionBase 
	{
		public Int32 Progress { get; set; }

		public TLSendMessageUploadPhotoAction() { }
		public TLSendMessageUploadPhotoAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageUploadPhotoAction; } }

		public override void Read(TLBinaryReader from)
		{
			Progress = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Progress);
		}
	}
}