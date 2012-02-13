using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace SignalResearch
{
    public static class UserDB
    {
        static Hashtable users = new Hashtable();

        public static void add(string id, string name) {
            users.Add(id, name);
        }

        public static String get(String id) {
            return (String) users[id];
        }

        public static void remove(string id)
        {
            users.Remove(id);
        }

        public static ICollection getAll()
        {
            return users.Values;
        }
    }
}