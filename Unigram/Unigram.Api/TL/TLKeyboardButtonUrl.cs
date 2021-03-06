// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonUrl : TLKeyboardButtonBase 
	{
		public String Url { get; set; }

		public TLKeyboardButtonUrl() { }
		public TLKeyboardButtonUrl(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonUrl; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
			Url = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Text ?? string.Empty);
			to.WriteString(Url ?? string.Empty);
		}
	}
}