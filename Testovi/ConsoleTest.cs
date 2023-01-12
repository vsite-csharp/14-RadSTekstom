﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.IO;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine()
            {
                output.Enqueue(string.Empty);
            }
            public override void WriteLine(string? value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(char value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(int value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(double value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(object? value)
            {
                output.Enqueue(value);
            }

            public string? GetString()
            {
                return (string?)output.Dequeue();
            }

            public char? GetChar()
            {
                return (char?)output.Dequeue();
            }

            public int? GetInt()
            {
                return (int?)output.Dequeue();
            }

            public double? GetDouble()
            {
                return (double?)output.Dequeue();
            }

            public DateTime? GetDate()
            {
                return (DateTime?)output.Dequeue();
            }

            public object? GetObject()
            {
                return output.Dequeue();
            }

            public bool IsEmpty
            {
                get { return output.Count == 0; }
            }

            public int Count
            {
                get { return output.Count; }
            }

            readonly Queue output = new Queue();
        }

        protected ConsoleTestWriter? cw = null;

        [TestInitialize()]
        public virtual void Initialize()
        {
            cw = new ConsoleTestWriter();
            Console.SetOut(cw);
        }

        [TestCleanup()]
        public virtual void Cleanup()
        {
            cw?.Dispose();
        }
    }
}
