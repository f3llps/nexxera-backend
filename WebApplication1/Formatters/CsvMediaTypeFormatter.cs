using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;

namespace WebApplication1.Formatters
{
    public class CsvMediaTypeFormatter : BufferedMediaTypeFormatter
    {
        public CsvMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/csv"));
        }
        public override bool CanReadType(Type type)
        {
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            if(type == null)
            {
                throw new ArgumentNullException("type");
            }
            return true;
        }

        //TODO: A Finalizar.

        public override void WriteToStream(Type type, object value, System.IO.Stream writeStream,HttpContent content)
        //{
        //    using (StreamWriter writer = new StringWriter(writeStream))
        //    {
        //        IEnumerable enumerable = value as IEnumerable;
        //        writer.WriteLine(string.Join(";", GetPropertyNames(type)));
        //        if (enumerable == null)
        //        {
        //            WriteElement(value, writer);
        //        }
        //        else
        //        {
        //            foreach (var item in enumerable)
        //            {
        //                WriteElement(item, writer);
        //            }
        //        }
        //    }
       // } 

        private IEnumerable<string> GetPropertyNames(Type type)
        {
            return type.GetProperties().Select(s => s.Name);
        }

        private void WriteElement(object item, StreamWriter writer)
        {
            string value = string.Empty;
            foreach(string property in GetPropertyNames(item.GetType()))
            {
                var propertyValue = item.GetType().GetProperty(property).GetValue(item);
                if (propertyValue != null)
                {
                    value += propertyValue.ToString();
                }
                value += ";";
            }
            writer.WriteLine(value.Substring(0, -1));
        }

    }
}