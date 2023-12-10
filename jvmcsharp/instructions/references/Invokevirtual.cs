﻿using jvmcsharp.instructions.basis;
using jvmcsharp.rtda;
using jvmcsharp.rtda.heap;

namespace jvmcsharp.instructions.references
{
    internal class INVOKE_VIRTUAL : Index16Instruction
    {
        public override void Execute(Frame frame)
        {
            var currentClass = frame.Method.Class!;
            var cp = currentClass.ConstantPool;
            var methodRef = cp.Get<MethodRef>(Index);
            var resolvedMethod = methodRef.ResolveMethod();
            if (resolvedMethod.IsStatic())
            {
                throw new Exception("java.lang.IncompatiblClassChangeeError");
            }
            var @ref = frame.OperandStack.GetRefFromTop(resolvedMethod.ArgSlotCount - 1);
            // 在java.lang.System中
            // public final static PrintStream out = null;
            // out属性被final修饰且为null
            if (@ref == null)
            {
                // Syste.out.println();
                // java.io.PrintStream#println(int)
                if (methodRef.Name == "println")
                {
                    PrintLn(frame, methodRef);
                    return;
                }
                throw new Exception("java.lang.NullPointException");
            }

            if (resolvedMethod.IsProtected()
                && resolvedMethod.Class!.IsSuperClassOf(currentClass)
                && resolvedMethod.Class!.GetPackageName() != currentClass.GetPackageName()
                && @ref.Class != currentClass
                && !@ref.Class.IsSubClassOf(currentClass))
            {
                throw new Exception("java.lang.IllegalAccessError");
            }

            var methodToBeInvoked = MethodRef.LookupMethodInClass(@ref.Class, methodRef.Name, methodRef.Descriptor);
            if (methodToBeInvoked == null || methodToBeInvoked.IsAbstract())
            {
                throw new Exception("java.lang.AbstarctMethodError");
            }
            CommonLogic.InvokeMethod(frame, methodToBeInvoked);
        }

        private static void PrintLn(Frame frame, MethodRef methodRef)
        {
            var stack = frame.OperandStack;
            switch (methodRef.Descriptor)
            {
                case "(Z)V":
                    Console.WriteLine(stack.Pop<int>() != 0);
                    break;
                case "(C)V":
                    Console.WriteLine(stack.Pop<int>());
                    break;
                case "(B)V":
                    Console.WriteLine(stack.Pop<int>());
                    break;
                case "(S)V":
                    Console.WriteLine(stack.Pop<int>());
                    break;
                case "(I)V":
                    Console.WriteLine(stack.Pop<int>());
                    break;
                case "(J)V":
                    Console.WriteLine(stack.Pop<long>());
                    break;
                case "(F)V":
                    Console.WriteLine(stack.Pop<float>());
                    break;
                case "(D)V":
                    Console.WriteLine(stack.Pop<double>());
                    break;
                default:
                    throw new Exception($"println: {methodRef.Descriptor}");
            }
        }
    }
}
