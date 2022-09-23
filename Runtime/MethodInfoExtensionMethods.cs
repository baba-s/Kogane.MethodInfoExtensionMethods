using System.Reflection;
using System.Runtime.CompilerServices;

namespace Kogane
{
    /// <summary>
    /// MethodInfo の拡張メソッドを管理するクラス
    /// </summary>
    public static class MethodInfoExtensionMethods
    {
        /// <summary>
        /// 拡張メソッドの場合 true を返します
        /// </summary>
        public static bool IsExtensionMethod( this MethodInfo self )
        {
            return self.IsDefined( typeof( ExtensionAttribute ), true );
        }
    }
}