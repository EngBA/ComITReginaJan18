using System;
using System.Diagnostics;


// https://conductofcode.io/post/entities-and-value-objects-in-csharp-for-ddd/

namespace FreightManagement.ValueObj
{
    [DebuggerDisplay("{Value}")]
    public class Email : IEquatable<Email>, IEquatable<string>
    {
        public string Value { get; }

        public Email(string value)
        {
            if (!value.Contains("@")) throw new Exception("Email is invalid");

            Value = value;
        }

        #region Conversion

        public static implicit operator string(Email value)
        {
            return value.Value;
        }

        public static implicit operator Email(string value)
        {
            return new Email(value);
        }

        #endregion

        #region Equality

        public override bool Equals(object obj)
        {
            var other = obj as Email;

            return other != null ? Equals(other) : Equals(obj as string);
        }

        public bool Equals(Email other) => other != null && Value == other.Value;

        public bool Equals(string other) => Value == other;

        public static bool operator ==(Email a, Email b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (((object)a == null) || ((object)b == null)) return false;

            return a.Value == b.Value;
        }

        public static bool operator !=(Email a, Email b) => !(a == b);

        #endregion

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value;
    }
}
