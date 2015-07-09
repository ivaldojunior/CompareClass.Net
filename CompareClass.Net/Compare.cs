using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareClass.Net
{
   public class Compare
    {

        static bool isEqual { get; set; }

        public static void Compare<T>(object class1, object class2)
        {
       
            var Class1Properties = class1 != null ? class1.GetType().GetProperties() : null;
            var Class1PropertiesValues = class1 != null ? Class1Properties.Select(n => n.GetValue(class1, null)) : null;

            var Class2Properties = class2 != null ? class2.GetType().GetProperties() : null;
            var Class2PropertiesValues = class2 != null ? Class2Properties.Select(n => n.GetValue(class2, null)) : null;


            isEqual = Class1PropertiesValues.SequenceEqual(Class2PropertiesValues);


            if (!isEqual)
            {
                for (int i = 0; i < Class1PropertiesValues.Count(); i++)
                {

                    if (Convert.ToString(GetPropValue(class1, Class1Properties[i].Name)) != Convert.ToString(GetPropValue(class2, Class2Properties[i].Name)))
                    {
                        
                        Console.WriteLine(Convert.ToString(GetPropValue(class1, Class1Properties[i].Name)));
                        Console.WriteLine(Convert.ToString(GetPropValue(class2, Class1Properties[i].Name)));
                    }


                }
            }

          
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    
   }



}
