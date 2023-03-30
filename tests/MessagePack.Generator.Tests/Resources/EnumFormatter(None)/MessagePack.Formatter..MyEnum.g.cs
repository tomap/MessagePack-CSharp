﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

namespace MessagePack.Formatters
{
    using MsgPack = global::MessagePack;

    public sealed class MyEnumFormatter : MsgPack::Formatters.IMessagePackFormatter<global::MyEnum>
    {
        public void Serialize(ref MsgPack::MessagePackWriter writer, global::MyEnum value, MsgPack::MessagePackSerializerOptions options)
        {
            writer.Write((int)value);
        }

        public global::MyEnum Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
        {
            return (global::MyEnum)reader.ReadInt32();
        }
    }
}
