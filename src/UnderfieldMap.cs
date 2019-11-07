using System;
using System.Linq.Expressions;

namespace Underfield
{
    public class UnderfieldMap<T, TR> where TR : class
    {
        public FluentWriteProperty MapWrite(Expression<Func<T, object>> memberExpression)
        {
            return new FluentWriteProperty(typeof(T));
        }
        
        public FluentReadProperty MapRead(Expression<Func<TR, object>> memberExpression)
        {
            return new FluentReadProperty(typeof(TR));
        }
    }
}