using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlComment
{
    /// <summary>
    /// Merupakan penjelasan utk class , method
    /// </summary>
    /// <summary>
    /// Merupakan penjelasan utk class , method
    /// <list type="bullet">
    /// type list bisa bullet, number, table
    /// bisa bikin list juga di commend
    /// <item>
    /// <term> nama point list </term>
    /// <description> penjelasan utk point list </description>
    /// </item>
    /// <item>
    /// <term> nama point list </term>
    /// <description> penjelasan utk point list </description>
    /// </item>
    /// </list>
    /// </summary>
    /// // <summary>
    /// <c> tag utk menandai suatu bagian sebagai code </c>
    /// </summary>
    /// <summary>
    /// Merupakan penjelasan utk class , method
    /// bisa juga manmbahkan nama variable parameter melalui <paramref name="x"/> dan
    /// <paramref name="y"/>
    /// </summary>
    /// <summary>
    /// Merupakan penjelasan utk class , method
    /// bisa juga manmbahkan nama variable parameter melalui <typeparamref name="x"/> dan
    /// <typeparamref name="y"/>
    /// </summary>
    /// <remarks>
    /// Tambahan penjelasan untuk comment
    /// </remarks>
    /// <remarks>
    /// <para> tag utk memformat sebuah content </para>
    /// </remarks>
    /// <returns>
    /// Penjelasan untuk nilai return
    /// </returns>

    /// <summary></summary>
    /// <example>
    /// <code>
    /// example coding utk sebuah methode
    /// Codingnya ditaruh disini
    /// </code>
    /// </example>
    /// <exception cref="SystemException">
    /// Keterangan exception taruh disini
    /// </exception>


    class XmlCommentTag
    {
        ///<value>
        /// Penjelasan utk sebuah variable atau property
        /// </value>
        /// <param>
        /// Penjelasan paramater input , output dari sebuah methode
        /// </param> 
        /// <typeparam name="x">
        /// Penjelasan parameter input dari sebuah metode global
        /// </typeparam>
        
    }
}
