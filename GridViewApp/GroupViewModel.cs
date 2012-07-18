using System.Collections.Generic;

namespace GridViewApp
{
    public abstract class GroupViewModel<TKey, TItem> : List<TItem>
    {
        protected GroupViewModel(TKey key, IEnumerable<TItem> collection)
            : base(collection)
        {
            Key = key;
        }

        protected TKey Key { get; set; }

        public string Identifier { get { return Key.ToString(); } }
    }
}