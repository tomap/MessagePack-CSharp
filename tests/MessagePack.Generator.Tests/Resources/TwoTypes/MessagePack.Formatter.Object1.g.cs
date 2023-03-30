﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

namespace MessagePack.Formatters
{
	using MsgPack = global::MessagePack;

	public sealed class Object1Formatter : MsgPack::Formatters.IMessagePackFormatter<global::Object1>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::Object1 value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			writer.WriteArrayHeader(0);
		}

		public global::Object1 Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			reader.Skip();
			return new global::Object1();
		}
	}
}
