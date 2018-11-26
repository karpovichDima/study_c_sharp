using System;
using System.Collections.Generic;
using LambdaAndLINQ.service.attribute;

namespace LambdaAndLINQ
{
   public class User : IEquatable<User>, IComparable<User>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name)
        {
            Random rnd = new Random();
            this.Age = rnd.Next(1, 19);
            this.Name = name;
        }

        public User()
        {
            Random rnd = new Random();
            this.Age = rnd.Next(1, 19);
        }

        protected bool Equals(User other)
        {
            return string.Equals(Name, other.Name) && Age == other.Age;
        }

        bool IEquatable<User>.Equals(User other)
        {
            return Equals(other);
        }

        public int CompareTo(User other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Age;
            }
        }
    }
} 