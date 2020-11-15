using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;

namespace YDNSUpdateGUI {

   public static class ObjectExtensions {

      /// <summary>
      /// shortcut for Convert.ToInt16(). Ιf the value is null then returns 0.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static Int16 AsInt16(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToInt16(obj);
         }
         else {
            return 0;
         }
      }

      /// <summary>
      /// shortcut for Convert.ToInt32(). Ιf the value is null then returns 0.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static Int32 AsInt32(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToInt32(obj);
         }
         else {
            return 0;
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToInt64(). If the value is null then returns 0.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static Int64 AsInt64(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToInt64(obj);
         }
         else {
            return 0;
         }
      }

      /// <summary>
      /// shortcut for ToInt32()
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static Int32 AsInt(this object obj) {
         return obj.AsInt32();
      }

      /// <summary>
      /// shortcut for ToInt32()
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="valueIfNull"></param>
      /// <returns></returns>
      public static Int32 AsInt(this object obj, int valueIfNull) {
         if (!obj.IsNull()) {
            return obj.AsInt32();
         }
         else {
            return valueIfNull;
         }
      }

      public static Decimal AsDecimal(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToDecimal(obj);
         }
         else {
            return 0;
         }
      }

      public static Decimal AsDecimal(this object obj, decimal valueIfNull) {
         if (!obj.IsNull()) {
            return obj.AsDecimal();
         }
         else {
            return valueIfNull;
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToString(). If the value is null then returns an empty string.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static string AsText(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToString(obj);
         }
         else {
            return "";
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToString(). If the value is null then returns an empty string.
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="valueIfNull">Η τιμή που θα επιστρέψει στην περίπτωση που είναι Null</param>
      /// <returns></returns>
      public static string AsText(this object obj, object valueIfNull) {
         if (!obj.IsNull()) {
            return Convert.ToString(obj);
         }
         else {
            return Convert.ToString(valueIfNull);
         }
      }

      public static string AsTextInvariant(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToString(obj, CultureInfo.InvariantCulture);
         }
         else {
            return "";
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToString().ToLower(). If the value is null then returns an empty string.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static string AsLowerText(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToString(obj).ToLowerInvariant();
         }
         else {
            return "";
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToString().ToUpper(). If the value is null then returns an empty string.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static string AsUpperText(this object obj) {
         if (!obj.IsNull()) {
            return Convert.ToString(obj).ToUpperInvariant();
         }
         else {
            return "";
         }
      }

      /// <summary>
      /// Shortcut for Convert.ToBoolean().ToLower(). If the value is null then returns an empty string.
      ///  "True" (String) = true
      ///  "False" (String) = false
      ///  "0" (String) = false
      ///  0 (Int) = false
      ///  Any other value = true
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool AsBool(this object obj) {
         if (!obj.IsNull()) {
            if (obj.AsText().IsNumeric()) {
               return Convert.ToBoolean(Convert.ToInt32(obj));
            }
            else {
               return Convert.ToBoolean(obj);
            }
         }
         else {
            return false;
         }
      }

      public static bool IsDBNull(this object obj) {
         return (DBNull.Value.Equals(obj));
      }

      /// <summary>
      /// Checks if value is Null or DBNull
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool IsNull(this object obj) {
         return (obj == null) || obj.IsDBNull();
      }

      /// <summary>
      /// Shortcut for IsNull, IsDBNull and String.IsNullOrEmpty
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public static bool IsNullOrEmpty(this object obj) {
         return (obj == null) || obj.IsDBNull() || String.IsNullOrEmpty(Convert.ToString(obj));
      }

      /// <summary>
      /// Used to simplify and beautify casting an object to a type.
      /// </summary>
      /// <typeparam name="T">Type to be casted</typeparam>
      /// <param name="obj">Object to cast</param>
      /// <returns>Casted object</returns>
      public static T As<T>(this object obj)
          where T : class {
         return (T)obj;
      }

      /// <summary>
      /// Converts given object to a value or enum type using <see cref="Convert.ChangeType(object,TypeCode)"/> or <see cref="Enum.Parse(Type,string)"/> method.
      /// </summary>
      /// <param name="obj">Object to be converted</param>
      /// <typeparam name="T">Type of the target object</typeparam>
      /// <returns>Converted object</returns>
      public static T To<T>(this object obj)
          where T : struct {
         if (typeof(T) == typeof(Guid)) {
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(obj.ToString());
         }

         if (typeof(T).IsEnum) {
            if (Enum.IsDefined(typeof(T), obj)) {
               return (T)Enum.Parse(typeof(T), obj.ToString());
            }
            else {
               throw new ArgumentException($"Enum type undefined '{obj}'.");
            }
         }

         return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.InvariantCulture);
      }

      /// <summary>
      /// Check if an item is in a list.
      /// </summary>
      /// <param name="item">Item to check</param>
      /// <param name="list">List of items</param>
      /// <typeparam name="T">Type of the items</typeparam>
      public static bool IsIn<T>(this T item, params T[] list) {
         return ((IList)list).Contains(item);
      }

      /// <summary>
      /// Checks if an object is a numeric value
      /// </summary>
      /// <param name="Expression"></param>
      /// <returns></returns>
      public static bool IsNumeric(this object Expression) {
         // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
         // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
         return Double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var retNum);
      }

      public static DateTime AsDate(this object obj) {
         if (obj==null) {
            return DateTime.MinValue;
         }

         if (!obj.GetType().Equals(typeof(string))) {
            return DateTime.MinValue;
         }

         if (!obj.IsNull()) {
            return DateTime.ParseExact((string)obj, formatList, new CultureInfo("en-US"), DateTimeStyles.None);
         }
         else {
            return DateTime.MinValue;
         }
      }

      private static string[] formatList = new string[] {
         "yyyy-MM-dd HH:mm:ss",
         "yyyy-MM-dd HH:mm",
         "yyyy-MM-dd",
         "yyyy-MM-ddTHH:mm:ss",
         "yyyy-MM-ddTHH:mm",
         "yyMMddhh"
      };


   }
}
