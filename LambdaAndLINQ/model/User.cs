﻿using System;
using System.Collections.Generic;

namespace LambdaAndLINQ
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name)
        {
            Random rnd = new Random();
            this.Age = rnd.Next(1, 19);
            this.Name = name;
        }

        protected bool Equals(User other)
        {
            return string.Equals(Name, other.Name) && Age == other.Age;
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