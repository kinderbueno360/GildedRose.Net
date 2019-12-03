using GildedRoseApp.Domain.Annotation;
using GildedRoseApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GildedRoseApp.Application
{
    public static class ItemFactory
    {
        public static ItemBase Create(string name, int sellIn, int quality = 0)
        {
            return FindItemByName(name, sellIn, quality);
        }

        private static ItemBase FindItemByName(string name, int sellIn, int quality)
        {
            Type deliveryType = ReturnTypeIfExist(name, GetDeliveryType());

            ConstructorInfo item = deliveryType.GetConstructors()[0];
            Object[] args = new Object[item.GetParameters().Count()];
            BuildConstructorParameters(name, sellIn, quality, item, args);

            return (ItemBase)Activator.CreateInstance(deliveryType, args);
        }

        private static void BuildConstructorParameters(string name, int sellIn, int quality, ConstructorInfo item, object[] args)
        {
            foreach (var parameter in item.GetParameters())
            {
                if (parameter.Name.ToLowerInvariant().Equals("name"))
                    args[0] = name;

                if (parameter.Name.ToLowerInvariant().Equals("sellin"))
                    args[1] = sellIn;

                if (parameter.Name.ToLowerInvariant().Equals("quality"))
                    args[2] = quality;
            }
        }

        private static IEnumerable<Type> GetDeliveryType()
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(ItemName), false)
                   select t;
        }
        private static Type ReturnTypeIfExist(string name, IEnumerable<Type> types)
        {
            foreach (Type retorno in types)
            {

                System.Reflection.MemberInfo info = retorno;
                object[] attributes = info.GetCustomAttributes(true);
                for (int i = 0; i < attributes.Length; i++)
                {
                    if (attributes[i] is ItemName)
                    {
                        if (name.ToLowerInvariant().Contains(((ItemName)attributes[i]).Name.ToLowerInvariant()))
                            return retorno;
                    }

                }
            }
            return typeof(NormalItem);
        }
    }
}