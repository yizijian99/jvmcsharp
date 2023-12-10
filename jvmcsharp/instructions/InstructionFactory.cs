﻿using jvmcsharp.instructions.basis;
using jvmcsharp.instructions.comparisons;
using jvmcsharp.instructions.constants;
using jvmcsharp.instructions.control;
using jvmcsharp.instructions.conversions;
using jvmcsharp.instructions.extended;
using jvmcsharp.instructions.loads;
using jvmcsharp.instructions.math;
using jvmcsharp.instructions.references;
using jvmcsharp.instructions.stack;
using jvmcsharp.instructions.stores;

namespace jvmcsharp.instructions
{
    internal class InstructionFactory
    {
        // NoOperandsInstruction singletons
        public static readonly NOP nop = new();
        public static readonly ACONST_NULL aconst_null = new();
        public static readonly ICONST_M1 iconst_m1 = new();
        public static readonly ICONST_0 iconst_0 = new();
        public static readonly ICONST_1 iconst_1 = new();
        public static readonly ICONST_2 iconst_2 = new();
        public static readonly ICONST_3 iconst_3 = new();
        public static readonly ICONST_4 iconst_4 = new();
        public static readonly ICONST_5 iconst_5 = new();
        public static readonly LCONST_0 lconst_0 = new();
        public static readonly LCONST_1 lconst_1 = new();
        public static readonly FCONST_0 fconst_0 = new();
        public static readonly FCONST_1 fconst_1 = new();
        public static readonly FCONST_2 fconst_2 = new();
        public static readonly DCONST_0 dconst_0 = new();
        public static readonly DCONST_1 dconst_1 = new();
        public static readonly ILOAD_0 iload_0 = new();
        public static readonly ILOAD_1 iload_1 = new();
        public static readonly ILOAD_2 iload_2 = new();
        public static readonly ILOAD_3 iload_3 = new();
        public static readonly LLOAD_0 lload_0 = new();
        public static readonly LLOAD_1 lload_1 = new();
        public static readonly LLOAD_2 lload_2 = new();
        public static readonly LLOAD_3 lload_3 = new();
        public static readonly FLOAD_0 fload_0 = new();
        public static readonly FLOAD_1 fload_1 = new();
        public static readonly FLOAD_2 fload_2 = new();
        public static readonly FLOAD_3 fload_3 = new();
        public static readonly DLOAD_0 dload_0 = new();
        public static readonly DLOAD_1 dload_1 = new();
        public static readonly DLOAD_2 dload_2 = new();
        public static readonly DLOAD_3 dload_3 = new();
        public static readonly ALOAD_0 aload_0 = new();
        public static readonly ALOAD_1 aload_1 = new();
        public static readonly ALOAD_2 aload_2 = new();
        public static readonly ALOAD_3 aload_3 = new();
        // public static readonly IALOAD iaload = new();
        // public static readonly LALOAD laload = new();
        // public static readonly FALOAD faload = new();
        // public static readonly DALOAD daload = new();
        // public static readonly AALOAD aaload = new();
        // public static readonly BALOAD baload = new();
        // public static readonly CALOAD caload = new();
        // public static readonly SALOAD saload = new();
        public static readonly ISTORE_0 istore_0 = new();
        public static readonly ISTORE_1 istore_1 = new();
        public static readonly ISTORE_2 istore_2 = new();
        public static readonly ISTORE_3 istore_3 = new();
        public static readonly LSTORE_0 lstore_0 = new();
        public static readonly LSTORE_1 lstore_1 = new();
        public static readonly LSTORE_2 lstore_2 = new();
        public static readonly LSTORE_3 lstore_3 = new();
        public static readonly FSTORE_0 fstore_0 = new();
        public static readonly FSTORE_1 fstore_1 = new();
        public static readonly FSTORE_2 fstore_2 = new();
        public static readonly FSTORE_3 fstore_3 = new();
        public static readonly DSTORE_0 dstore_0 = new();
        public static readonly DSTORE_1 dstore_1 = new();
        public static readonly DSTORE_2 dstore_2 = new();
        public static readonly DSTORE_3 dstore_3 = new();
        public static readonly ASTORE_0 astore_0 = new();
        public static readonly ASTORE_1 astore_1 = new();
        public static readonly ASTORE_2 astore_2 = new();
        public static readonly ASTORE_3 astore_3 = new();
        // public static readonly IASTORE iastore  = new();
        // public static readonly LASTORE lastore  = new();
        // public static readonly FASTORE fastore  = new();
        // public static readonly DASTORE dastore  = new();
        // public static readonly AASTORE aastore  = new();
        // public static readonly BASTORE bastore  = new();
        // public static readonly CASTORE castore  = new();
        // public static readonly SASTORE sastore  = new();
        public static readonly POP pop = new();
        public static readonly POP2 pop2 = new();
        public static readonly DUP dup = new();
        public static readonly DUP_X1 dup_x1 = new();
        public static readonly DUP_X2 dup_x2 = new();
        public static readonly DUP2 dup2 = new();
        public static readonly DUP2_X1 dup2_x1 = new();
        public static readonly DUP2_X2 dup2_x2 = new();
        public static readonly SWAP swap = new();
        public static readonly IADD iadd = new();
        public static readonly LADD ladd = new();
        public static readonly FADD fadd = new();
        public static readonly DADD dadd = new();
        public static readonly ISUB isub = new();
        public static readonly LSUB lsub = new();
        public static readonly FSUB fsub = new();
        public static readonly DSUB dsub = new();
        public static readonly IMUL imul = new();
        public static readonly LMUL lmul = new();
        public static readonly FMUL fmul = new();
        public static readonly DMUL dmul = new();
        public static readonly IDIV idiv = new();
        public static readonly LDIV ldiv = new();
        public static readonly FDIV fdiv = new();
        public static readonly DDIV ddiv = new();
        public static readonly IREM irem = new();
        public static readonly LREM lrem = new();
        public static readonly FREM frem = new();
        public static readonly DREM drem = new();
        public static readonly INEG ineg = new();
        public static readonly LNEG lneg = new();
        public static readonly FNEG fneg = new();
        public static readonly DNEG dneg = new();
        public static readonly ISHL ishl = new();
        public static readonly LSHL lshl = new();
        public static readonly ISHR ishr = new();
        public static readonly LSHR lshr = new();
        public static readonly IUSHR iushr = new();
        public static readonly LUSHR lushr = new();
        public static readonly IAND iand = new();
        public static readonly LAND land = new();
        public static readonly IOR ior = new();
        public static readonly LOR lor = new();
        public static readonly IXOR ixor = new();
        public static readonly LXOR lxor = new();
        public static readonly I2L i2l = new();
        public static readonly I2F i2f = new();
        public static readonly I2D i2d = new();
        public static readonly L2I l2i = new();
        public static readonly L2F l2f = new();
        public static readonly L2D l2d = new();
        public static readonly F2I f2i = new();
        public static readonly F2L f2l = new();
        public static readonly F2D f2d = new();
        public static readonly D2I d2i = new();
        public static readonly D2L d2l = new();
        public static readonly D2F d2f = new();
        public static readonly I2B i2b = new();
        public static readonly I2C i2c = new();
        public static readonly I2S i2s = new();
        public static readonly LCMP lcmp = new();
        public static readonly FCMPL fcmpl = new();
        public static readonly FCMPG fcmpg = new();
        public static readonly DCMPL dcmpl = new();
        public static readonly DCMPG dcmpg = new();
        public static readonly IRETURN ireturn = new();
        public static readonly LRETURN lreturn = new();
        public static readonly FRETURN freturn = new();
        public static readonly DRETURN dreturn = new();
        public static readonly ARETURN areturn = new();
        public static readonly RETURN @return = new();
        // public static readonly ARRAY_LENGTH arraylength = new();
        // public static readonly ATHROW athrow = new();
        // public static readonly MONITOR_ENTER monitorenter = new();
        // public static readonly MONITOR_EXIT monitorexit = new();
        // public static readonly INVOKE_NATIVE invoke_native = new();

        public static Instruction Create(byte opcode)
        {
            return opcode switch
            {
                0x00 => nop,
                0x01 => aconst_null,
                0x02 => iconst_m1,
                0x03 => iconst_0,
                0x04 => iconst_1,
                0x05 => iconst_2,
                0x06 => iconst_3,
                0x07 => iconst_4,
                0x08 => iconst_5,
                0x09 => lconst_0,
                0x0a => lconst_1,
                0x0b => fconst_0,
                0x0c => fconst_1,
                0x0d => fconst_2,
                0x0e => dconst_0,
                0x0f => dconst_1,
                0x10 => new BIPUSH(),
                0x11 => new SIPUSH(),
                0x12 => new LDC(),
                0x13 => new LDC_W(),
                0x14 => new LDC2_W(),
                0x15 => new ILOAD(),
                0x16 => new LLOAD(),
                0x17 => new FLOAD(),
                0x18 => new DLOAD(),
                0x19 => new ALOAD(),
                0x1a => iload_0,
                0x1b => iload_1,
                0x1c => iload_2,
                0x1d => iload_3,
                0x1e => lload_0,
                0x1f => lload_1,
                0x20 => lload_2,
                0x21 => lload_3,
                0x22 => fload_0,
                0x23 => fload_1,
                0x24 => fload_2,
                0x25 => fload_3,
                0x26 => dload_0,
                0x27 => dload_1,
                0x28 => dload_2,
                0x29 => dload_3,
                0x2a => aload_0,
                0x2b => aload_1,
                0x2c => aload_2,
                0x2d => aload_3,
                // 0x2e => iaload,
                // 0x2f => laload,
                // 0x30 => faload,
                // 0x31 => daload,
                // 0x32 => aaload,
                // 0x33 => baload,
                // 0x34 => caload,
                // 0x35 => saload,
                0x36 => new ISTORE(),
                0x37 => new LSTORE(),
                0x38 => new FSTORE(),
                0x39 => new DSTORE(),
                0x3a => new ASTORE(),
                0x3b => istore_0,
                0x3c => istore_1,
                0x3d => istore_2,
                0x3e => istore_3,
                0x3f => lstore_0,
                0x40 => lstore_1,
                0x41 => lstore_2,
                0x42 => lstore_3,
                0x43 => fstore_0,
                0x44 => fstore_1,
                0x45 => fstore_2,
                0x46 => fstore_3,
                0x47 => dstore_0,
                0x48 => dstore_1,
                0x49 => dstore_2,
                0x4a => dstore_3,
                0x4b => astore_0,
                0x4c => astore_1,
                0x4d => astore_2,
                0x4e => astore_3,
                // 0x4f => iastore,
                // 0x50 => lastore,
                // 0x51 => fastore,
                // 0x52 => dastore,
                // 0x53 => aastore,
                // 0x54 => bastore,
                // 0x55 => castore,
                // 0x56 => sastore,
                0x57 => pop,
                0x58 => pop2,
                0x59 => dup,
                0x5a => dup_x1,
                0x5b => dup_x2,
                0x5c => dup2,
                0x5d => dup2_x1,
                0x5e => dup2_x2,
                0x5f => swap,
                0x60 => iadd,
                0x61 => ladd,
                0x62 => fadd,
                0x63 => dadd,
                0x64 => isub,
                0x65 => lsub,
                0x66 => fsub,
                0x67 => dsub,
                0x68 => imul,
                0x69 => lmul,
                0x6a => fmul,
                0x6b => dmul,
                0x6c => idiv,
                0x6d => ldiv,
                0x6e => fdiv,
                0x6f => ddiv,
                0x70 => irem,
                0x71 => lrem,
                0x72 => frem,
                0x73 => drem,
                0x74 => ineg,
                0x75 => lneg,
                0x76 => fneg,
                0x77 => dneg,
                0x78 => ishl,
                0x79 => lshl,
                0x7a => ishr,
                0x7b => lshr,
                0x7c => iushr,
                0x7d => lushr,
                0x7e => iand,
                0x7f => land,
                0x80 => ior,
                0x81 => lor,
                0x82 => ixor,
                0x83 => lxor,
                0x84 => new IINC(),
                0x85 => i2l,
                0x86 => i2f,
                0x87 => i2d,
                0x88 => l2i,
                0x89 => l2f,
                0x8a => l2d,
                0x8b => f2i,
                0x8c => f2l,
                0x8d => f2d,
                0x8e => d2i,
                0x8f => d2l,
                0x90 => d2f,
                0x91 => i2b,
                0x92 => i2c,
                0x93 => i2s,
                0x94 => lcmp,
                0x95 => fcmpl,
                0x96 => fcmpg,
                0x97 => dcmpl,
                0x98 => dcmpg,
                0x99 => new IFEQ(),
                0x9a => new IFNE(),
                0x9b => new IFLT(),
                0x9c => new IFGE(),
                0x9d => new IFGT(),
                0x9e => new IFLE(),
                0x9f => new IF_ICMPEQ(),
                0xa0 => new IF_ICMPNE(),
                0xa1 => new IF_ICMPLT(),
                0xa2 => new IF_ICMPGE(),
                0xa3 => new IF_ICMPGT(),
                0xa4 => new IF_ICMPLE(),
                0xa5 => new IF_ACMPEQ(),
                0xa6 => new IF_ACMPNE(),
                0xa7 => new GOTO(),
                // 0xa8 => new JSR(),
                // 0xa9 => new RET(),
                0xaa => new TABLE_SWITCH(),
                0xab => new LOOKUP_SWITCH(),
                0xac => ireturn,
                0xad => lreturn,
                0xae => freturn,
                0xaf => dreturn,
                0xb0 => areturn,
                0xb1 => @return,
                0xb2 => new GET_STATIC(),
                0xb3 => new PUT_STATIC(),
                0xb4 => new GET_FIELD(),
                0xb5 => new PUT_FIELD(),
                0xb6 => new INVOKE_VIRTUAL(),
                0xb7 => new INVOKE_SPECIAL(),
                0xb8 => new INVOKE_STATIC(),
                0xb9 => new INVOKE_INTERFACE(),
                // 0xba => new INVOKE_DYNAMIC(),
                0xbb => new NEW(),
                // 0xbc => new NEW_ARRAY(),
                // 0xbd => new ANEW_ARRAY(),
                // 0xbe => arraylength,
                // 0xbf => athrow,
                0xc0 => new CHECK_CAST(),
                0xc1 => new INSTANCE_OF(),
                // 0xc2 => monitorenter,
                // 0xc3 => monitorexit,
                0xc4 => new WIDE(),
                // 0xc5 => new MULTI_ANEW_ARRAY(),
                0xc6 => new IFNULL(),
                0xc7 => new IFNONNULL(),
                0xc8 => new GOTO_W(),
                // 0xc9 => new JSR_W(),
                // 0xca => breakpoint,
                // 0xfe => impdep1,
                // 0xff => impdep2,
                _ => throw new Exception($"Unsupported opcode => {opcode:X2}!"),
            };
        }
    }
}
