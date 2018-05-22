
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Reflection;
using System.Xml;

public class ReadXml<T> where T : class
{


    static ReadXml()
    {
    }


    private static T CreateInitiate()
    {
        Type t = typeof(T);
        ConstructorInfo ct = t.GetConstructor(System.Type.EmptyTypes);
        T target = (T)ct.Invoke(null);
        return target;
    }

    public static List<T> Load(string path)
    {
        XmlDocument xml = new XmlDocument();
        XmlReaderSettings set = new XmlReaderSettings();
        set.IgnoreComments = true;
        xml.Load(XmlReader.Create((path), set));
        XmlNodeList xmlNodeList = xml.SelectSingleNode("data").ChildNodes;
        List<T> list = new List<T>();
        foreach (XmlElement xl1 in xmlNodeList)
        {
            T target = CreateInitiate();
            Type t = target.GetType();
            FieldInfo[] fields = t.GetFields();
            string fieldName = string.Empty;
            foreach (FieldInfo f in fields)
            {
                fieldName = f.Name;
                if (!f.FieldType.IsEnum)
                {
                    f.SetValue(target, Convert.ChangeType(xl1.GetAttribute(fieldName), f.FieldType));
                }
                else
                {
                    f.SetValue(target, Enum.Parse(f.FieldType, xl1.GetAttribute(fieldName)));
                }
            }
            list.Add(target);
        }

        return list;
    }
}



